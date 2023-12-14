namespace ASMF_Monolith
{
    partial class PlacementForm
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
            label1 = new Label();
            materialListBox = new ListBox();
            countBox = new TextBox();
            label2 = new Label();
            deleteButton = new Button();
            createButton = new Button();
            nameBox = new TextBox();
            unitBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Список материалов";
            // 
            // materialListBox
            // 
            materialListBox.FormattingEnabled = true;
            materialListBox.ItemHeight = 15;
            materialListBox.Location = new Point(12, 27);
            materialListBox.Name = "materialListBox";
            materialListBox.Size = new Size(191, 154);
            materialListBox.TabIndex = 1;
            // 
            // countBox
            // 
            countBox.Location = new Point(226, 45);
            countBox.Name = "countBox";
            countBox.Size = new Size(100, 23);
            countBox.TabIndex = 2;
            countBox.KeyDown += countBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 27);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 3;
            label2.Text = "изменить количетсво";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(209, 146);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(126, 35);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Удалить материал";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(82, 75);
            createButton.Name = "createButton";
            createButton.Size = new Size(138, 47);
            createButton.TabIndex = 5;
            createButton.Text = "Добавить новый материал";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(22, 28);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 6;
            // 
            // unitBox
            // 
            unitBox.Location = new Point(153, 28);
            unitBox.Name = "unitBox";
            unitBox.Size = new Size(100, 23);
            unitBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 10);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 8;
            label3.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 10);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 9;
            label4.Text = "Единицы измерения";
            // 
            // panel1
            // 
            panel1.Controls.Add(createButton);
            panel1.Controls.Add(unitBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 131);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(229, 19);
            label5.TabIndex = 11;
            label5.Text = "Добавление нового материала";
            // 
            // PlacementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 353);
            Controls.Add(label5);
            Controls.Add(deleteButton);
            Controls.Add(label2);
            Controls.Add(countBox);
            Controls.Add(materialListBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "PlacementForm";
            Text = "PlacementForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox materialListBox;
        private TextBox countBox;
        private Label label2;
        private Button deleteButton;
        private Button createButton;
        private TextBox nameBox;
        private TextBox unitBox;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
    }
}