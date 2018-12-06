namespace MyUserManagement
{
    partial class ItemsListForm
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
            this.nameLabel = new MyUserManagement.Infrastructure.BaseLabel();
            this.nameTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.searchButton = new MyUserManagement.Infrastructure.BaseButton();
            this.deleteButton = new MyUserManagement.Infrastructure.BaseButton();
            this.ItemsDataGridView = new MyUserManagement.Infrastructure.BaseDataGridView();
            this.generalCodeTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.generalCodeLabel = new MyUserManagement.Infrastructure.BaseLabel();
            this.orderCodeTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.orderCodeLabel = new MyUserManagement.Infrastructure.BaseLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "&Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(102, 12);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 21);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nameTextBox.WaterMarkText = "Part of English or Persian Name";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(797, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(797, 526);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "&Delete Users";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(12, 82);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.Size = new System.Drawing.Size(860, 438);
            this.ItemsDataGridView.TabIndex = 9;
            this.ItemsDataGridView.DoubleClick += new System.EventHandler(this.ItemsDataGridView_DoubleClick);
            // 
            // generalCodeTextBox
            // 
            this.generalCodeTextBox.Location = new System.Drawing.Point(102, 50);
            this.generalCodeTextBox.MaxLength = 30;
            this.generalCodeTextBox.Name = "generalCodeTextBox";
            this.generalCodeTextBox.Size = new System.Drawing.Size(240, 21);
            this.generalCodeTextBox.TabIndex = 11;
            this.generalCodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.generalCodeTextBox.WaterMarkText = "13 Digit general code";
            // 
            // generalCodeLabel
            // 
            this.generalCodeLabel.AutoSize = true;
            this.generalCodeLabel.Location = new System.Drawing.Point(10, 53);
            this.generalCodeLabel.Name = "generalCodeLabel";
            this.generalCodeLabel.Size = new System.Drawing.Size(86, 13);
            this.generalCodeLabel.TabIndex = 10;
            this.generalCodeLabel.Text = "&General Code";
            // 
            // orderCodeTextBox
            // 
            this.orderCodeTextBox.Location = new System.Drawing.Point(452, 12);
            this.orderCodeTextBox.MaxLength = 30;
            this.orderCodeTextBox.Name = "orderCodeTextBox";
            this.orderCodeTextBox.Size = new System.Drawing.Size(240, 21);
            this.orderCodeTextBox.TabIndex = 13;
            this.orderCodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.orderCodeTextBox.WaterMarkText = "Item order code";
            // 
            // orderCodeLabel
            // 
            this.orderCodeLabel.AutoSize = true;
            this.orderCodeLabel.Location = new System.Drawing.Point(372, 15);
            this.orderCodeLabel.Name = "orderCodeLabel";
            this.orderCodeLabel.Size = new System.Drawing.Size(74, 13);
            this.orderCodeLabel.TabIndex = 12;
            this.orderCodeLabel.Text = "&Order Code";
            // 
            // ItemsListForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.orderCodeTextBox);
            this.Controls.Add(this.orderCodeLabel);
            this.Controls.Add(this.generalCodeTextBox);
            this.Controls.Add(this.generalCodeLabel);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ItemsListForm";
            this.ShowIcon = false;
            this.Text = "Warehouse Items";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infrastructure.BaseLabel nameLabel;
        private Infrastructure.BaseTextBox nameTextBox;
        private Infrastructure.BaseButton searchButton;
        private Infrastructure.BaseButton deleteButton;
        private Infrastructure.BaseDataGridView ItemsDataGridView;
        private Infrastructure.BaseTextBox generalCodeTextBox;
        private Infrastructure.BaseLabel generalCodeLabel;
        private Infrastructure.BaseTextBox orderCodeTextBox;
        private Infrastructure.BaseLabel orderCodeLabel;
    }
}
