using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Task
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(save.FileName, true);
                streamWriter.WriteLine(labelSurname.Text + ": " + textBoxSurname.Text);
                streamWriter.WriteLine(labelName.Text + ": " + textBoxName.Text);
                streamWriter.WriteLine(labelMiddleName.Text + ": " + textBoxMiddleName.Text);

                if (radioButtonMale.Checked)
                {
                    streamWriter.WriteLine(groupBoxSex.Text + ": " + radioButtonMale.Text);
                }
                else if (radioButtonFemale.Checked)
                {
                    streamWriter.WriteLine(groupBoxSex.Text + ": " + radioButtonFemale.Text);
                } 

                streamWriter.WriteLine(groupBoxBirthday.Text + ": " + comboBoxDay.Text + " " + 
                                        comboBoxMonth.Text.ToLower() + " " + comboBoxYear.Text + " год");
                streamWriter.WriteLine("Семейный статус: " + comboBoxStatus.Text);
                streamWriter.WriteLine(labelInfo.Text + ": "+ textBoxInfo.Text);
                streamWriter.WriteLine("\n");
                streamWriter.Close();
            }
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxMiddleName.Clear();
            textBoxInfo.Clear();
        }

        private void ComboBoxDay_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 32; i++)
            {
                if (comboBoxDay.Items.Count < 31)
                {
                    comboBoxDay.Items.Add(i);
                }
            }
        }

        private void ComboBoxYear_Click(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i > 1940; i--)
            {
                if (comboBoxYear.Items.Count < DateTime.Now.Year - 1940)
                {
                    comboBoxYear.Items.Add(i);
                }
            }
        }

        private void ComboBoxMonth_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (comboBoxMonth.Items.Count < 12)
                {
                    comboBoxMonth.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i).ToString());
                }
            }
        }
    }
}
