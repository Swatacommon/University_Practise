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
            this.DeletePhoneButton = new System.Windows.Forms.Button();
            this.AddPhoneButton = new System.Windows.Forms.Button();
            this.UpdatePhoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneList)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneList
            // 
            this.PhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhoneList.Location = new System.Drawing.Point(496, 12);
            this.PhoneList.Name = "PhoneList";
            this.PhoneList.RowHeadersWidth = 51;
            this.PhoneList.RowTemplate.Height = 24;
            this.PhoneList.Size = new System.Drawing.Size(825, 461);
            this.PhoneList.TabIndex = 0;
            // 
            // DeletePhoneButton
            // 
            this.DeletePhoneButton.Location = new System.Drawing.Point(93, 322);
            this.DeletePhoneButton.Name = "DeletePhoneButton";
            this.DeletePhoneButton.Size = new System.Drawing.Size(276, 92);
            this.DeletePhoneButton.TabIndex = 1;
            this.DeletePhoneButton.Text = "Удалить Телефон";
            this.DeletePhoneButton.UseVisualStyleBackColor = true;
            this.DeletePhoneButton.Click += new System.EventHandler(this.DeletePhoneButton_Click);
            // 
            // AddPhoneButton
            // 
            this.AddPhoneButton.Location = new System.Drawing.Point(93, 43);
            this.AddPhoneButton.Name = "AddPhoneButton";
            this.AddPhoneButton.Size = new System.Drawing.Size(276, 88);
            this.AddPhoneButton.TabIndex = 2;
            this.AddPhoneButton.Text = "Добавить Телефон";
            this.AddPhoneButton.UseVisualStyleBackColor = true;
            this.AddPhoneButton.Click += new System.EventHandler(this.AddPhoneButton_Click);
            // 
            // UpdatePhoneButton
            // 
            this.UpdatePhoneButton.Location = new System.Drawing.Point(93, 183);
            this.UpdatePhoneButton.Name = "UpdatePhoneButton";
            this.UpdatePhoneButton.Size = new System.Drawing.Size(276, 88);
            this.UpdatePhoneButton.TabIndex = 3;
            this.UpdatePhoneButton.Text = "Обновить Телефон";
            this.UpdatePhoneButton.UseVisualStyleBackColor = true;
            this.UpdatePhoneButton.Click += new System.EventHandler(this.UpdatePhoneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 485);
            this.Controls.Add(this.UpdatePhoneButton);
            this.Controls.Add(this.AddPhoneButton);
            this.Controls.Add(this.DeletePhoneButton);
            this.Controls.Add(this.PhoneList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PhoneList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PhoneList;
        private System.Windows.Forms.Button DeletePhoneButton;
        private System.Windows.Forms.Button AddPhoneButton;
        private System.Windows.Forms.Button UpdatePhoneButton;
    }
}

