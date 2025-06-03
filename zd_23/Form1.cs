using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd_23
{
    public partial class Form1 : Form
    {
        Shop shop;

        public Form1()
        {
            InitializeComponent();
        }

        // загрузка магазина
        private void магазинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zd_3.Visible = false;
            zd_2.Visible = true;
            shop = new Shop();
        }

        // загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            zd_2.Visible = false;
            zd_3.Visible = false;
        }

        // метод защищенного ввода данных о товаре
        private void addBut_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            numericUpDown1.BackColor = Color.White;
            numericUpDown2.BackColor = Color.White;

            // защита имени
            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.Tomato;
                return;
            }

            // защита цены
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.BackColor = Color.Tomato;
                return;
            }

            // защита количества
            if (numericUpDown2.Value == 0)
            {
                numericUpDown2.BackColor = Color.Tomato;
                return;
            }

            if (shop.FindByName(textBox1.Text) != null)
            {
                MessageBox.Show("Такой товар уже есть");
                return;
            }

            dataGridView1.Rows.Add(new string[] { textBox1.Text, numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString() });
            shop.CreateProduct(textBox1.Text, numericUpDown1.Value, (int)numericUpDown2.Value);

            textBox1.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }

        // метод покупки товара с обновлением таблицы
        private void SellProd(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].RowIndex == -1 || dataGridView1.Rows.Count == 1) return;

            if (shop.Sell(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()))
            {
                dataGridView1.Rows.Clear();

                // загрузка буфера удаления
                List<Product> delet = new List<Product>();

                // обход словаря товаров для обновления
                foreach (var pr in shop.DictProd())
                {
                    if (pr.Value > 0) dataGridView1.Rows.Add(new string[] { pr.Key.Name, pr.Key.Price.ToString(), pr.Value.ToString() });
                    else delet.Add(pr.Key);
                }

                // удаление по буферу
                foreach (var pr in delet)
                {
                    shop.DictProd().Remove(pr);
                }

                price.Text = $"Прибыль: {shop.Budget()}";
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        // переход на плейлист
        private void плейлистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zd_2.Visible = false;
            zd_3.Visible = true;
        }

    }
}
