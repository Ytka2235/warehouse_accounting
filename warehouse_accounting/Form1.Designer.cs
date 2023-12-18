namespace warehouse_accounting
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
            this.label1 = new System.Windows.Forms.Label();
            this.but_find = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.but_ref = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.but_up = new System.Windows.Forms.Button();
            this.but_down = new System.Windows.Forms.Button();
            this.label_sum = new System.Windows.Forms.Label();
            this.label_unit = new System.Windows.Forms.Label();
            this.but_redact = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.but_save2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по коду тавара";
            // 
            // but_find
            // 
            this.but_find.Location = new System.Drawing.Point(632, 68);
            this.but_find.Name = "but_find";
            this.but_find.Size = new System.Drawing.Size(75, 23);
            this.but_find.TabIndex = 2;
            this.but_find.Text = "Найти";
            this.but_find.UseVisualStyleBackColor = true;
            this.but_find.Click += new System.EventHandler(this.but_find_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(531, 40);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(257, 22);
            this.textBoxFind.TabIndex = 3;
            // 
            // but_ref
            // 
            this.but_ref.Location = new System.Drawing.Point(395, 332);
            this.but_ref.Name = "but_ref";
            this.but_ref.Size = new System.Drawing.Size(129, 23);
            this.but_ref.TabIndex = 4;
            this.but_ref.Text = "Обновить";
            this.but_ref.UseVisualStyleBackColor = true;
            this.but_ref.Click += new System.EventHandler(this.but_ref_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(540, 332);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(248, 23);
            this.but_add.TabIndex = 5;
            this.but_add.Text = "Добавить";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_del
            // 
            this.but_del.Location = new System.Drawing.Point(540, 367);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(248, 23);
            this.but_del.TabIndex = 6;
            this.but_del.Text = "Удалить";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(540, 475);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(248, 23);
            this.but_cancel.TabIndex = 7;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(540, 437);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(248, 23);
            this.but_save.TabIndex = 8;
            this.but_save.Text = "Сохранить";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Изменение количества товара:";
            // 
            // but_up
            // 
            this.but_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_up.Location = new System.Drawing.Point(531, 192);
            this.but_up.Name = "but_up";
            this.but_up.Size = new System.Drawing.Size(125, 52);
            this.but_up.TabIndex = 10;
            this.but_up.Text = "+";
            this.but_up.UseVisualStyleBackColor = true;
            this.but_up.Click += new System.EventHandler(this.but_up_Click);
            // 
            // but_down
            // 
            this.but_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_down.Location = new System.Drawing.Point(662, 192);
            this.but_down.Name = "but_down";
            this.but_down.Size = new System.Drawing.Size(126, 52);
            this.but_down.TabIndex = 11;
            this.but_down.Text = "-";
            this.but_down.UseVisualStyleBackColor = true;
            this.but_down.Click += new System.EventHandler(this.but_down_Click);
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(537, 156);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(44, 16);
            this.label_sum.TabIndex = 12;
            this.label_sum.Text = "label3";
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(735, 156);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(44, 16);
            this.label_unit.TabIndex = 13;
            this.label_unit.Text = "label4";
            // 
            // but_redact
            // 
            this.but_redact.Location = new System.Drawing.Point(540, 402);
            this.but_redact.Name = "but_redact";
            this.but_redact.Size = new System.Drawing.Size(248, 23);
            this.but_redact.TabIndex = 14;
            this.but_redact.Text = "Изменить";
            this.but_redact.UseVisualStyleBackColor = true;
            this.but_redact.Click += new System.EventHandler(this.but_redact_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Название";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Код";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Еденицы измерения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Артикул";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 361);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(512, 22);
            this.textBoxName.TabIndex = 20;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 409);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(220, 22);
            this.textBoxId.TabIndex = 21;
            // 
            // textBoxArt
            // 
            this.textBoxArt.Location = new System.Drawing.Point(267, 409);
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(257, 22);
            this.textBoxArt.TabIndex = 22;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(267, 476);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(257, 22);
            this.textBoxSum.TabIndex = 23;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "шт",
            "литр",
            "кг"});
            this.comboBoxUnit.Location = new System.Drawing.Point(15, 476);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(217, 24);
            this.comboBoxUnit.TabIndex = 24;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(15, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(509, 308);
            this.listBox.TabIndex = 25;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // but_save2
            // 
            this.but_save2.Location = new System.Drawing.Point(531, 250);
            this.but_save2.Name = "but_save2";
            this.but_save2.Size = new System.Drawing.Size(257, 23);
            this.but_save2.TabIndex = 26;
            this.but_save2.Text = "Сохранить";
            this.but_save2.UseVisualStyleBackColor = true;
            this.but_save2.Click += new System.EventHandler(this.but_save2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.but_save2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxArt);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.but_redact);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.but_down);
            this.Controls.Add(this.but_up);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_ref);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.but_find);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Учет склада";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_find;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button but_ref;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_up;
        private System.Windows.Forms.Button but_down;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.Button but_redact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button but_save2;
    }
}

