namespace InternetShop.OtherForm
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(36, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Имя";
            this.textBoxName.Size = new System.Drawing.Size(144, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(36, 100);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PlaceholderText = "Логин";
            this.textBoxLogin.Size = new System.Drawing.Size(144, 23);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(36, 63);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PlaceholderText = "Телефон";
            this.textBoxPhone.Size = new System.Drawing.Size(144, 23);
            this.textBoxPhone.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(36, 137);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PlaceholderText = "Пароль";
            this.textBoxPass.Size = new System.Drawing.Size(144, 23);
            this.textBoxPass.TabIndex = 3;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(39, 192);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(137, 31);
            this.buttonReg.TabIndex = 4;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 251);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxName);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonReg;
    }
}