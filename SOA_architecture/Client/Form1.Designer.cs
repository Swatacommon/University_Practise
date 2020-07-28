namespace Client
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
            this.PhoneList = new System.Windows.Forms.DataGridView();
            this.AddPhoneButton = new System.Windows.Forms.Button();
            this.UpdatePhoneButton = new System.Windows.Forms.Button();
            this.DeletePhoneButton = new System.Windows.Forms.Button();
            this.CatList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatList)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneList
            // 
            this.PhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhoneList.Location = new System.Drawing.Point(388, 51);
            this.PhoneList.Name = "PhoneList";
            this.PhoneList.RowHeadersWidth = 51;
            this.PhoneList.RowTemplate.Height = 24;
            this.PhoneList.Size = new System.Drawing.Size(659, 194);
            this.PhoneList.TabIndex = 0;
            // 
            // AddPhoneButton
            // 
            this.AddPhoneButton.Location = new System.Drawing.Point(55, 23);
            this.AddPhoneButton.Name = "AddPhoneButton";
            this.AddPhoneButton.Size = new System.Drawing.Size(244, 96);
            this.AddPhoneButton.TabIndex = 1;
            this.AddPhoneButton.Text = "Добавить";
            this.AddPhoneButton.UseVisualStyleBackColor = true;
            this.AddPhoneButton.Click += new System.EventHandler(this.AddPhoneButton_Click);
            // 
            // UpdatePhoneButton
            // 
            this.UpdatePhoneButton.Location = new System.Drawing.Point(55, 198);
            this.UpdatePhoneButton.Name = "UpdatePhoneButton";
            this.UpdatePhoneButton.Size = new System.Drawing.Size(244, 96);
            this.UpdatePhoneButton.TabIndex = 2;
            this.UpdatePhoneButton.Text = "Обновить";
            this.UpdatePhoneButton.UseVisualStyleBackColor = true;
            this.UpdatePhoneButton.Click += new System.EventHandler(this.UpdatePhoneButton_Click);
            // 
            // DeletePhoneButton
            // 
            this.DeletePhoneButton.Location = new System.Drawing.Point(55, 390);
            this.DeletePhoneButton.Name = "DeletePhoneButton";
            this.DeletePhoneButton.Size = new System.Drawing.Size(244, 96);
            this.DeletePhoneButton.TabIndex = 3;
            this.DeletePhoneButton.Text = "Удалить";
            this.DeletePhoneButton.UseVisualStyleBackColor = true;
            this.DeletePhoneButton.Click += new System.EventHandler(this.DeletePhoneButton_Click);
            // 
            // CatList
            // 
            this.CatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatList.Location = new System.Drawing.Point(388, 304);
            this.CatList.Name = "CatList";
            this.CatList.RowHeadersWidth = 51;
            this.CatList.RowTemplate.Height = 24;
            this.CatList.Size = new System.Drawing.Size(659, 194);
            this.CatList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(388, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список телефонов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(388, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список котов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CatList);
            this.Controls.Add(this.DeletePhoneButton);
            this.Controls.Add(this.UpdatePhoneButton);
            this.Controls.Add(this.AddPhoneButton);
            this.Controls.Add(this.PhoneList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PhoneList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PhoneList;
        private System.Windows.Forms.Button AddPhoneButton;
        private System.Windows.Forms.Button UpdatePhoneButton;
        private System.Windows.Forms.Button DeletePhoneButton;
        private System.Windows.Forms.DataGridView CatList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

