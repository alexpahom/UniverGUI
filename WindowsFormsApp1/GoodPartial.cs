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
    public partial class GoodPartial : Form
    {
        private bool editMode;
        private Form1 form;

        public GoodPartial(Form1 f)
        {
            InitializeComponent();
            form = f;
            editMode = false;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            int id;
            string type, model, manufacturer;

            id = IdParse(sender, e);
            if (id <= 0)
            {
                LError.Text = "Stock Number should be positive";
                LError.Visible = true;
                return;
            }
            type = TypeTextBox.Text;
            model = ModelTextBox.Text;
            manufacturer = ManTextBox.Text;
            if (!IsIdValid(id) && !editMode)
            {
                LError.Text = "Given Stock Number already exists";
                LError.Visible = true;
            }
            else if (!IsStringValid(type) || !IsStringValid(model) || !IsStringValid(manufacturer))
            {
                LError.Text = "Type / Model / Manufacturer cannot be empty";
                LError.Visible = true;
            }
            else
            {
                WGood good = new WGood(id, type, model, manufacturer);
                if (editMode)
                {
                    UpdateGood(good); 
                }
                else
                {
                    CreateGood(good);
                }
                Close();
                form.RefillTable();
            }
            
        }

        private void CreateGood(WGood good)
        {
            Form1.container.add(good);
        }

        private void UpdateGood(WGood good)
        {
            Form1.container.drop_by_id(good.getId());
            Form1.container.add(good);
        }

        public void Edit(int id)
        {
            editMode = true;
            WGood good = new WGood();
            good = Form1.container.find_by_id(id);
            IdTextBox.Text = good.getId().ToString();
            IdTextBox.ReadOnly = true;
            TypeTextBox.Text = good.getType();
            ModelTextBox.Text = good.getModel();
            ManTextBox.Text = good.getManufacturer();
        }

        private bool IsIdValid(int id) => Form1.container.is_id_unique(id);

        private bool IsStringValid(string s)  => s != "";

        private void Good_Partial_TextChanged(object sender, EventArgs e)
        {
            LError.Visible = false;
        }

        private int IdParse(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = Int32.Parse(IdTextBox.Text);
            }
            catch (FormatException)
            {
                LError.Text = "Stock Number should be an integer";
                LError.Visible = true;
                return id;
            }
            return id;
        }
    }
}
