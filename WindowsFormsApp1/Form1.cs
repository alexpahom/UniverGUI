using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Wrapper;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public static WGoodContainer container = new WGoodContainer();
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            container.load();
            CreateHeaders();
            RefillTable();
            FilterInput.KeyPress += new KeyPressEventHandler(FilterInput_KeyPressed);
            FilterInput.GotFocus += new EventHandler(HidePlaceholder);
            FilterInput.LostFocus += new EventHandler(ShowPlaceholder);
        }

        private void CreateHeaders()
        {
            dt.Columns.Add("Stock Number", typeof(int));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("Manufacturer", typeof(string));
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddGood_Click(object sender, EventArgs e)
        {
            GoodPartial partial = new GoodPartial(this);
            partial.Show();
        }

        public void RefillTable()
        {
            BindingSource bs = new BindingSource();

            dt.Rows.Clear();
            foreach (var good in container.getGoods())
            {
                int id = good.getId();
                string type = good.getType();
                string model = good.getModel();
                string man = good.getManufacturer();
                dt.Rows.Add(new object[] { id, type, model, man });
            }

            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }

        private void EditGood_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].Value;
            GoodPartial partial = new GoodPartial(this);
            partial.Show();
            partial.Edit(id);
        }

        private void DropGood_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].Value;
            container.drop_by_id(id);
            RefillTable();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            container.save();
        }

        private void Search(object sender, EventArgs e, string attribute, string query)
        {
            dt.DefaultView.RowFilter = $"Convert([{attribute}], 'System.String') LIKE '%{query}%'";
        }

        private void FilterInput_TextChanged(object sender, EventArgs e)
        {
            string attribute, query;
            if (RId.Checked)
                attribute = "Stock Number";
            else if (RType.Checked)
                attribute = "Type";
            else if (RModel.Checked)
                attribute = "Model";
            else
                attribute = "Manufacturer";

            query = FilterInput.Text;
            Search(sender, e, attribute, query);
        }

        private void FilterInput_KeyPressed(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex("%|'");
            if (regex.IsMatch(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void ShowPlaceholder(object sender, EventArgs e)
        {
            if(FilterInput.Text == "")
            {
                FilterInput.TextChanged -= new EventHandler(FilterInput_TextChanged);
                FilterInput.ForeColor = SystemColors.ScrollBar;
                FilterInput.Text = "Search...";
                FilterInput.TextChanged += new EventHandler(FilterInput_TextChanged);
            }
        }

        private void HidePlaceholder(object sender, EventArgs e)
        {
            if(FilterInput.Text == "Search...")
            {
                FilterInput.TextChanged -= new EventHandler(FilterInput_TextChanged);
                FilterInput.ForeColor = SystemColors.WindowText;
                FilterInput.Text = "";
                FilterInput.TextChanged += new EventHandler(FilterInput_TextChanged);
            }
        }
    }
}
