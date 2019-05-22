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
        public Form1()
        {
            InitializeComponent();

            container.load();
            dataGridView1.Columns.Add("GId", "Артикул");
            dataGridView1.Columns.Add("GType", "Тип");
            dataGridView1.Columns.Add("GModle", "Модель");
            dataGridView1.Columns.Add("GManufacturer", "Производитель");
            RefillTable();

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
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (var good in container.getGoods())
            {
                int id = good.getId();
                string type = good.getType();
                string model = good.getModel();
                string man = good.getManufacturer();
                dataGridView1.Rows.Add(id, type, model, man);
            }
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
    }
}
