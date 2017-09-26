namespace Task
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(32, 80);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(237, 29);
            this.textBoxSurname.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(32, 155);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 29);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(32, 231);
            this.textBoxMiddleName.Multiline = true;
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(237, 29);
            this.textBoxMiddleName.TabIndex = 2;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.comboBoxSex.Location = new System.Drawing.Point(32, 300);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(237, 24);
            this.comboBoxSex.TabIndex = 4;
            this.comboBoxSex.Text = "Пол";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(35, 57);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(81, 20);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Фамилия";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "холосты",
            "женаты",
            "разведены",
            "в поиске"});
            this.comboBoxStatus.Location = new System.Drawing.Point(337, 169);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(338, 24);
            this.comboBoxStatus.TabIndex = 7;
            this.comboBoxStatus.Text = "Семейный статус";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo.Location = new System.Drawing.Point(337, 231);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(338, 93);
            this.textBoxInfo.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(300, 363);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 38);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(35, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 20);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(33, 206);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(83, 20);
            this.labelMiddleName.TabIndex = 11;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthday.Location = new System.Drawing.Point(110, 9);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(128, 20);
            this.labelBirthday.TabIndex = 12;
            this.labelBirthday.Text = "Дата рождения";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(333, 206);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(242, 20);
            this.labelInfo.TabIndex = 13;
            this.labelInfo.Text = "Дополнительная информация";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Location = new System.Drawing.Point(27, 62);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(50, 21);
            this.comboBoxDay.TabIndex = 14;
            this.comboBoxDay.Click += new System.EventHandler(this.comboBoxDay_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(89, 62);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonth.TabIndex = 15;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(222, 62);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(93, 21);
            this.comboBoxYear.TabIndex = 16;
            this.comboBoxYear.Click += new System.EventHandler(this.comboBoxYear_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDay.Location = new System.Drawing.Point(31, 39);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(42, 17);
            this.labelDay.TabIndex = 17;
            this.labelDay.Text = "День";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonth.Location = new System.Drawing.Point(125, 39);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(50, 17);
            this.labelMonth.TabIndex = 18;
            this.labelMonth.Text = "Месяц";
            this.labelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(250, 39);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 17);
            this.labelYear.TabIndex = 19;
            this.labelYear.Text = "Год";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBirthday);
            this.panel1.Controls.Add(this.labelYear);
            this.panel1.Controls.Add(this.comboBoxDay);
            this.panel1.Controls.Add(this.labelMonth);
            this.panel1.Controls.Add(this.comboBoxMonth);
            this.panel1.Controls.Add(this.labelDay);
            this.panel1.Controls.Add(this.comboBoxYear);
            this.panel1.Location = new System.Drawing.Point(337, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 93);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Ввод данных";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Panel panel1;
    }
}

