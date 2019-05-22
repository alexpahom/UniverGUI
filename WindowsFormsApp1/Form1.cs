using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }

        private void CreateHeaders()
        {
            dt.Columns.Add("Артикул", typeof(int));
            dt.Columns.Add("Тип", typeof(string));
            dt.Columns.Add("Модель", typeof(string));
            dt.Columns.Add("Производитель", typeof(string));
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
            // TODO: No rows selected validation
            int id;
            id = (int)dataGridView1.SelectedCells[0].Value;
            GoodPartial partial = new GoodPartial(this);
            partial.Show();
            partial.Edit(id);
        }

        private void DropGood_Click(object sender, EventArgs e)
        {
            // TODO: Empty selection validation
            int id;
            id = (int)dataGridView1.SelectedCells[0].Value;
            container.drop_by_id(id);
            RefillTable();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            container.save();
        }

        private void Search(object sender, EventArgs e, string attribute, string query)
        {
            dt.DefaultView.RowFilter = $"Convert({attribute}, 'System.String') LIKE '%{query}%'";
        }

        private void FilterInput_TextChanged(object sender, EventArgs e)
        {
            string attribute, query;
            if (RId.Checked)
                attribute = "Артикул";
            else if (RType.Checked)
                attribute = "Тип";
            else if (RModel.Checked)
                attribute = "Модель";
            else
                attribute = "Производитель";

            query = FilterInput.Text;
            Search(sender, e, attribute, query);
        }
    }
}
