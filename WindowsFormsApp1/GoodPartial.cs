using System;
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

        // Обработка нажатия кнопки отмена
        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Обработка нажатия кнопки сохранения
        private void BUpdate_Click(object sender, EventArgs e)
        {
            int id;
            string type, model, manufacturer;

            // Проверка, является ли ID числом
            id = IdParse(sender, e);

            // Проверка на положительность
            if (id <= 0)
            {
                LError.Text = "Stock Number should be positive";
                LError.Visible = true;
                return;
            }

            // Сбор строковых данных
            type = TypeTextBox.Text;
            model = ModelTextBox.Text;
            manufacturer = ManTextBox.Text;

            // Проверка на уникальность ID, в случае создания новой записи
            if (!IsIdValid(id) && !editMode)
            {
                LError.Text = "Given Stock Number already exists";
                LError.Visible = true;
            }
            // Проверка есть ли пустые строки
            else if (!IsStringValid(type) || !IsStringValid(model) || !IsStringValid(manufacturer))
            {
                LError.Text = "Type / Model / Manufacturer cannot be empty";
                LError.Visible = true;
            }
            else
            {
                // Сохранение или редактирование
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

        // Создание новой записи
        private void CreateGood(WGood good)
        {
            Form1.container.add(good);
        }

        // Редактирование существующей записи
        private void UpdateGood(WGood good)
        {
            Form1.container.drop_by_id(good.getId());
            Form1.container.add(good);
        }

        // Автозаполение полей ввода в случае редактирования
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

        // Вызов метода проверки на уникальность ID
        private bool IsIdValid(int id) => Form1.container.is_id_unique(id);


        // Проверка пустая ли строка
        private bool IsStringValid(string s)  => s != "";

        // Сброс сообщения с ошибкой в случае изменения содержимого любого текстового поля
        private void Good_Partial_TextChanged(object sender, EventArgs e)
        {
            LError.Visible = false;
        }

        // Проверка, является ли введенное ID числом
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
