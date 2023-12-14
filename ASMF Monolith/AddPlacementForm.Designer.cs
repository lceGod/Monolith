namespace ASMF_Monolith
{
    partial class AddPlacementForm
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
            addButton = new Button();
            pwBox = new TextBox();
            label3 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(187, 114);
            addButton.Name = "addButton";
            addButton.Size = new Size(138, 47);
            addButton.TabIndex = 10;
            addButton.Text = "Создать";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // pwBox
            // 
            pwBox.Location = new Point(212, 61);
            pwBox.Name = "pwBox";
            pwBox.Size = new Size(100, 23);
            pwBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(198, 19);
            label3.TabIndex = 13;
            label3.Text = "Название помещения (Логин)";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(212, 18);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 61);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 14;
            label1.Text = "Пароль";
            // 
            // AddPlacementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 211);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(pwBox);
            Controls.Add(label3);
            Controls.Add(nameBox);
            Name = "AddPlacementForm";
            Text = "AddPlacementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private TextBox pwBox;
        private Label label3;
        private TextBox nameBox;
        private Label label1;
    }
}