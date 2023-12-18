using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace warehouse_accounting
{
    public partial class Form1 : Form
    {
        Product[] products;
        public bool add_flag;
        public bool red_flag;

        public Form1()
        {
            InitializeComponent();
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnit.SelectedIndex = 0;
            full_list();
        }

        public void full_list()
        {
            but_add.Enabled = true;
            but_del.Enabled = true;
            but_redact.Enabled = true;
            but_cancel.Enabled = false;
            but_save.Enabled = false;
            comboBoxUnit.Enabled = false;
            but_ref.Enabled = true;
            string[] file = Directory.GetFiles("product");
            products = new Product[file.Length];
            comboBoxUnit.SelectedIndex = 0;
            if (file.Length > 0)
            {
                int i = 0;
                foreach (string path in file)
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        products[i] = new Product(reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), int.Parse(reader.ReadLine()), reader.ReadLine(), path);
                    }

                    i++;
                }
                listBox.Items.Clear();
                foreach (Product prod in products) listBox.Items.Add(prod.name);
                listBox.SelectedIndex = 0;
            }
            else
            {
                textBoxName.Text = "";
                textBoxId.Text = "";
                textBoxArt.Text = "";
                comboBoxUnit.Enabled = false;
                textBoxSum.Text = "";
                label_sum.Text = "";
                label_unit.Text = "";
                listBox.SelectedItem = null;
                but_del.Enabled = false;
                but_redact.Enabled = false;
                but_find.Enabled = false;
                but_save2.Enabled = false;
                but_up.Enabled = false;
                but_down.Enabled = false;
            }

        }

        void textBoxReadOnly(bool x)
        {
            textBoxName.ReadOnly = x;
            textBoxId.ReadOnly = x;
            textBoxArt.ReadOnly = x;
            comboBoxUnit.Enabled = !x;
            textBoxSum.ReadOnly = x;
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            textBoxReadOnly(false);
            textBoxName.Text = "";
            textBoxId.Text = "";
            textBoxArt.Text = "";
            textBoxSum.Text = "";
            but_save2.Enabled = false;
            but_add.Enabled = false;
            but_del.Enabled = false;
            but_redact.Enabled = false;
            but_cancel.Enabled = true;
            but_save.Enabled = true;
            but_find.Enabled = false;
            but_up.Enabled = false;
            but_down.Enabled = false;
            but_ref.Enabled = false;
            add_flag = true;
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            textBoxReadOnly(true);
            but_save2.Enabled = true;
            but_add.Enabled = true;
            but_del.Enabled = true;
            but_redact.Enabled = true;
            but_cancel.Enabled = false;
            but_save.Enabled = false;
            but_find.Enabled = true;
            but_up.Enabled = false;
            but_down.Enabled = false;
            but_ref.Enabled = true;
            if (add_flag)
            {
                full_list();
                add_flag = false;
            }
            if (red_flag)
            {
                int id = listBox.SelectedIndex;
                textBoxName.Text = "" + products[id].name;
                textBoxId.Text = "" + products[id].id;
                textBoxArt.Text = "" + products[id].art;
                textBoxSum.Text = "" + products[id].sum;
                comboBoxUnit.SelectedIndex = products[id].units;
                red_flag = false;
            }
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            int id = listBox.SelectedIndex;
            File.Delete(products[id].path);
            full_list();
        }

        public static void AddText(FileStream fs, string value)
        {
            try
            {
                byte[] info = new UTF8Encoding(true).GetBytes(value);
                fs.Write(info, 0, info.Length);
            }
            catch
            {
                MessageBox.Show("Error", "Ошибка");
            }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].id == textBoxId.Text & !(i == listBox.SelectedIndex)) { flag = false; break; }
            }
            if(!flag)
            {
                MessageBox.Show("Код должен быть уникальным!", "Ошибка");
            }
            if (add_flag & flag)
            {
                if (textBoxName.Text != "" & textBoxId.Text != "" & textBoxArt.Text != "" & textBoxSum.Text != "")
                {
                    try
                    {
                        double d = Convert.ToDouble(textBoxSum.Text);
                        Random random = new Random();
                        using (FileStream fs = File.Create("product/" + random.Next(1000, 9999) + ".txt"))
                        {
                            AddText(fs, textBoxName.Text);
                            AddText(fs, "\n" + textBoxId.Text);
                            AddText(fs, "\n" + textBoxArt.Text);
                            AddText(fs, "\n" + comboBoxUnit.SelectedIndex);
                            AddText(fs, "\n" + textBoxSum.Text);
                        }
                        add_flag = false;
                        textBoxReadOnly(true);
                        but_add.Enabled = true;
                        but_del.Enabled = true;
                        but_redact.Enabled = true;
                        but_cancel.Enabled = false;
                        but_save.Enabled = false;
                        but_ref.Enabled = true;
                        but_find.Enabled = true;
                        full_list();
                    }
                    catch
                    {
                        MessageBox.Show("Количество должно быть числом", "Ошибка");
                    }

                }
                else
                {
                    MessageBox.Show("Заполнкны не все данные", "Ошибка");
                }
            }

            if (red_flag & flag)
            {
                if (textBoxName.Text != "" & textBoxId.Text != "" & textBoxArt.Text != "" & textBoxSum.Text != "")
                {
                    try
                    {
                        int id = listBox.SelectedIndex;
                        File.Delete(products[id].path);
                        using (FileStream fs = File.Create(products[id].path))
                        {
                            AddText(fs, textBoxName.Text);
                            AddText(fs, "\n" + textBoxId.Text);
                            AddText(fs, "\n" + textBoxArt.Text);
                            AddText(fs, "\n" + comboBoxUnit.SelectedIndex);
                            AddText(fs, "\n" + textBoxSum.Text);
                        }
                        add_flag = false;
                        textBoxReadOnly(true);
                        but_add.Enabled = true;
                        but_del.Enabled = true;
                        but_redact.Enabled = true;
                        but_cancel.Enabled = false;
                        but_save.Enabled = false;
                        but_ref.Enabled = true;
                        but_find.Enabled = true;
                        full_list();
                        listBox.SelectedIndex = id;
                    }
                    catch
                    {
                        MessageBox.Show("Неверный формат данных", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Заполнкны не все данные", "Ошибка");
                }
            }
        }

        private void but_redact_Click(object sender, EventArgs e)
        {
            textBoxReadOnly(false);
            but_add.Enabled = false;
            but_save2.Enabled = false;
            but_del.Enabled = false;
            but_redact.Enabled = false;
            but_cancel.Enabled = true;
            but_save.Enabled = true;
            but_find.Enabled = false;
            but_up.Enabled = false;
            but_down.Enabled = false;
            but_ref.Enabled = false;
            red_flag = true;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = listBox.SelectedIndex;
                but_add.Enabled = true;
                but_del.Enabled = true;
                but_redact.Enabled = true;
                but_save.Enabled = false;
                but_cancel.Enabled = false;
                but_save2.Enabled = true;
                textBoxName.Text = products[id].name;
                textBoxArt.Text = products[id].art;
                textBoxId.Text = products[id].id;
                textBoxSum.Text = products[id].sum;
                comboBoxUnit.SelectedIndex = products[id].units;
                label_sum.Text = products[id].sum;
                label_unit.Text = comboBoxUnit.Text;
            }
            catch 
            {

            }
        }

        private void but_save2_Click(object sender, EventArgs e)
        {
            int id = listBox.SelectedIndex;
            textBoxSum.Text = label_sum.Text;
            products[id].sum = textBoxSum.Text;
            File.Delete(products[id].path);
            using (FileStream fs = File.Create(products[id].path))
            {
                AddText(fs, textBoxName.Text);
                AddText(fs, "\n" + textBoxId.Text);
                AddText(fs, "\n" + textBoxArt.Text);
                AddText(fs, "\n" + comboBoxUnit.SelectedIndex);
                AddText(fs, "\n" + textBoxSum.Text);
            }
        }

        private void but_ref_Click(object sender, EventArgs e)
        {
            full_list();
        }

        private void but_find_Click(object sender, EventArgs e)
        {
            string txt = textBoxFind.Text;
            for (int i = 0; i < products.Length; i++) 
            {
                if (products[i].id == txt) { listBox.SelectedIndex = i; ; return; }
            }
        }

        private void but_up_Click(object sender, EventArgs e)
        {
            double num = double.Parse(label_sum.Text);
            num = num + 1;
            label_sum.Text = num.ToString();
        }

        private void but_down_Click(object sender, EventArgs e)
        {
            double num = double.Parse(label_sum.Text);
            num = num - 1;
            if (num < 0) num = 0;
            label_sum.Text = num.ToString();
        }

        
    }

}

