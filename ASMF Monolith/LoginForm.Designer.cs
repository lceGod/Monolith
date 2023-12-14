namespace ASMF_Monolith
{
    partial class LoginForm
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
            PasswordLabel = new Label();
            LoginLabel = new Label();
            passField = new TextBox();
            loginField = new TextBox();
            SignButton = new Button();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(15, 73);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(79, 21);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Password:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel.Location = new Point(42, 28);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(52, 21);
            LoginLabel.TabIndex = 8;
            LoginLabel.Text = "Login:";
            // 
            // passField
            // 
            passField.Location = new Point(100, 73);
            passField.Name = "passField";
            passField.Size = new Size(151, 23);
            passField.TabIndex = 7;
            passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            loginField.Location = new Point(100, 28);
            loginField.Name = "loginField";
            loginField.Size = new Size(151, 23);
            loginField.TabIndex = 6;
            // 
            // SignButton
            // 
            SignButton.FlatStyle = FlatStyle.Flat;
            SignButton.Location = new Point(100, 130);
            SignButton.Name = "SignButton";
            SignButton.Size = new Size(75, 23);
            SignButton.TabIndex = 5;
            SignButton.Text = "Sign In";
            SignButton.UseVisualStyleBackColor = true;
            SignButton.Click += SignButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 165);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(passField);
            Controls.Add(loginField);
            Controls.Add(SignButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLabel;
        private Label LoginLabel;
        private TextBox passField;
        private TextBox loginField;
        private Button SignButton;
    }
}