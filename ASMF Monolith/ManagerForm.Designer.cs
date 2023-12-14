namespace ASMF_Monolith
{
    partial class ManagerForm
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
            addPlacementButton = new Button();
            placementListBox = new ListBox();
            ListPlacementLabel = new Label();
            materialListBox = new ListBox();
            limitBox = new TextBox();
            label2 = new Label();
            limitLabel = new Label();
            updateButton = new Button();
            SuspendLayout();
            // 
            // addPlacementButton
            // 
            addPlacementButton.Location = new Point(12, 232);
            addPlacementButton.Name = "addPlacementButton";
            addPlacementButton.Size = new Size(92, 38);
            addPlacementButton.TabIndex = 0;
            addPlacementButton.Text = "Добавить";
            addPlacementButton.UseVisualStyleBackColor = true;
            addPlacementButton.Click += AddPlacementButton_Click;
            // 
            // placementListBox
            // 
            placementListBox.FormattingEnabled = true;
            placementListBox.ItemHeight = 15;
            placementListBox.Location = new Point(12, 27);
            placementListBox.Name = "placementListBox";
            placementListBox.Size = new Size(147, 199);
            placementListBox.TabIndex = 2;
            placementListBox.SelectedIndexChanged += placementList_SelectedIndexChanged;
            // 
            // ListPlacementLabel
            // 
            ListPlacementLabel.AutoSize = true;
            ListPlacementLabel.Location = new Point(12, 9);
            ListPlacementLabel.Name = "ListPlacementLabel";
            ListPlacementLabel.Size = new Size(118, 15);
            ListPlacementLabel.TabIndex = 3;
            ListPlacementLabel.Text = "Список помещений";
            // 
            // materialListBox
            // 
            materialListBox.FormattingEnabled = true;
            materialListBox.ItemHeight = 15;
            materialListBox.Location = new Point(165, 27);
            materialListBox.Name = "materialListBox";
            materialListBox.Size = new Size(174, 199);
            materialListBox.TabIndex = 4;
            // 
            // limitBox
            // 
            limitBox.Location = new Point(395, 45);
            limitBox.Name = "limitBox";
            limitBox.Size = new Size(100, 23);
            limitBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // limitLabel
            // 
            limitLabel.AutoSize = true;
            limitLabel.Location = new Point(345, 27);
            limitLabel.Name = "limitLabel";
            limitLabel.Size = new Size(191, 15);
            limitLabel.TabIndex = 8;
            limitLabel.Text = "Установить лимит для материала";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(110, 232);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(92, 38);
            updateButton.TabIndex = 9;
            updateButton.Text = "Обновить информацию";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 282);
            Controls.Add(updateButton);
            Controls.Add(limitLabel);
            Controls.Add(label2);
            Controls.Add(limitBox);
            Controls.Add(materialListBox);
            Controls.Add(ListPlacementLabel);
            Controls.Add(placementListBox);
            Controls.Add(addPlacementButton);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addPlacementButton;
        private ListBox placementListBox;
        private Label ListPlacementLabel;
        private ListBox materialListBox;
        private TextBox limitBox;
        private Label label2;
        private Label limitLabel;
        private Button updateButton;
    }
}