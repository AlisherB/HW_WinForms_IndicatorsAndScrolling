using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(save.FileName);
                streamWriter.WriteLine(labelSurname.Text + ": " + textBoxSurname.Text);
                streamWriter.WriteLine(labelName.Text + ": " + textBoxName.Text);
                streamWriter.WriteLine(labelMiddleName.Text + ": " + textBoxMiddleName.Text);
                streamWriter.WriteLine("Пол: " + comboBoxSex.Text);
               // streamWriter.WriteLine(labelBirthday.Text + ": " + dateTimePicker.Text);
                streamWriter.WriteLine("Семейный статус: " + comboBoxStatus.Text);
                streamWriter.WriteLine(labelInfo.Text + ": "+ textBoxInfo.Text);
                streamWriter.Close();
            }
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxMiddleName.Clear();
            //dateTimePicker.ResetText();
            textBoxInfo.Clear();
        }

        private void comboBoxDay_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 32; i++)
            {
                if (comboBoxDay.Items.Count < 31)
                {
                    comboBoxDay.Items.Add(i);
                }
            }
        }

        private void comboBoxYear_Click(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i > 1940; i--)
            {
                if (comboBoxYear.Items.Count < DateTime.Now.Year - 1940)
                {
                    comboBoxYear.Items.Add(i);
                }
            }
        }
    }
}
