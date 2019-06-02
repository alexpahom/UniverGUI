using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
// Подключение разработанной библиотеки
using Wrapper;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        // Для доступа к коллекции по имени класса
        public static WGoodContainer container = new WGoodContainer();
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
            // Процесс заполнения таблицы при запуске приложения
            dt = new DataTable();
            container.load();
            CreateHeaders();
            RefillTable();
            FilterInput.KeyPress += new KeyPressEventHandler(FilterInput_KeyPressed);
            FilterInput.GotFocus += new EventHandler(HidePlaceholder);
            FilterInput.LostFocus += new EventHandler(ShowPlaceholder);
        }

        // Шапка таблицы
        private void CreateHeaders()
        {
            dt.Columns.Add("Stock Number", typeof(int));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("Manufacturer", typeof(string));
        }

        // Выход из приложения
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Обработка нажатия Create
        private void AddGood_Click(object sender, EventArgs e)
        {
            GoodPartial partial = new GoodPartial(this);
            partial.Show();
        }

        // Обновление содержимого таблицы
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

        // Обработка нажатия Edit
        private void EditGood_Click(object sender, EventArgs e)
        {
            // Поиск ID выделенного товара
            int id = (int)dataGridView1.SelectedCells[0].Value;
            GoodPartial partial = new GoodPartial(this);
            partial.Show();
            partial.Edit(id);
        }

        // Обработка нажатия Delete
        private void DropGood_Click(object sender, EventArgs e)
        {
            // Поиск ID выделенного товара
            int id = (int)dataGridView1.SelectedCells[0].Value;
            container.drop_by_id(id);
            RefillTable();
        }

        // Обработка нажатия Save
        private void SaveButton_Click(object sender, EventArgs e)
        {
            container.save();
        }

        // Фильтр содержимого таблицы
        private void Search(object sender, EventArgs e, string attribute, string query)
        {
            // Конвертируем в строку, чтобы иметь возможность искать и числа, и строки одним способом
            dt.DefaultView.RowFilter = $"Convert([{attribute}], 'System.String') LIKE '%{query}%'";
        }

        // Вызов процедуры поиска, в случае изменения текста в поисковой строке
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

        // Блокирует ввод символов % и '
        private void FilterInput_KeyPressed(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex("%|'");
            if (regex.IsMatch(e.KeyChar.ToString()))
                e.Handled = true;
        }

        // Отображение заглушки в поисковой строке
        private void ShowPlaceholder(object sender, EventArgs e)
        {
            if(FilterInput.Text == "")
            {
                // На время отписываемся от события изменения текста, чтобы установить заглушку
                FilterInput.TextChanged -= new EventHandler(FilterInput_TextChanged);
                FilterInput.ForeColor = SystemColors.ScrollBar;
                FilterInput.Text = "Search...";
                FilterInput.TextChanged += new EventHandler(FilterInput_TextChanged);
            }
        }

        // Удаление заглушки в поисковой строке
        private void HidePlaceholder(object sender, EventArgs e)
        {
            if(FilterInput.Text == "Search...")
            {
                // На время отписываемся от события изменения текста, чтобы сбросить заглушку
                FilterInput.TextChanged -= new EventHandler(FilterInput_TextChanged);
                FilterInput.ForeColor = SystemColors.WindowText;
                FilterInput.Text = "";
                FilterInput.TextChanged += new EventHandler(FilterInput_TextChanged);
            }
        }
    }
}
