namespace MyUserManagement.Admin
{
    partial class NewItemForm
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
            this.cancelButton = new MyUserManagement.Infrastructure.BaseButton();
            this.saveButton = new MyUserManagement.Infrastructure.BaseButton();
            this.engNameTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.fullNameLabel = new MyUserManagement.Infrastructure.BaseLabel();
            this.persNameTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.baseLabel1 = new MyUserManagement.Infrastructure.BaseLabel();
            this.generalCodeTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.baseLabel2 = new MyUserManagement.Infrastructure.BaseLabel();
            this.orderCodeTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.baseLabel3 = new MyUserManagement.Infrastructure.BaseLabel();
            this.currentQuantityTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.baseLabel4 = new MyUserManagement.Infrastructure.BaseLabel();
            this.usedQuantityTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.baseLabel5 = new MyUserManagement.Infrastructure.BaseLabel();
            this.baseLabel6 = new MyUserManagement.Infrastructure.BaseLabel();
            this.typeTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.baseLabel7 = new MyUserManagement.Infrastructure.BaseLabel();
            this.addressTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.resetButton = new MyUserManagement.Infrastructure.BaseButton();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(205, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(297, 291);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // engNameTextBox
            // 
            this.engNameTextBox.Location = new System.Drawing.Point(102, 12);
            this.engNameTextBox.MaxLength = 30;
            this.engNameTextBox.Name = "engNameTextBox";
            this.engNameTextBox.Size = new System.Drawing.Size(270, 21);
            this.engNameTextBox.TabIndex = 2;
            this.engNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.engNameTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(14, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(84, 13);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "English Name";
            // 
            // persNameTextBox
            // 
            this.persNameTextBox.Location = new System.Drawing.Point(102, 49);
            this.persNameTextBox.MaxLength = 30;
            this.persNameTextBox.Name = "persNameTextBox";
            this.persNameTextBox.Size = new System.Drawing.Size(270, 21);
            this.persNameTextBox.TabIndex = 9;
            this.persNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.persNameTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // baseLabel1
            // 
            this.baseLabel1.AutoSize = true;
            this.baseLabel1.Location = new System.Drawing.Point(12, 52);
            this.baseLabel1.Name = "baseLabel1";
            this.baseLabel1.Size = new System.Drawing.Size(86, 13);
            this.baseLabel1.TabIndex = 8;
            this.baseLabel1.Text = "Persian Name";
            // 
            // generalCodeTextBox
            // 
            this.generalCodeTextBox.Location = new System.Drawing.Point(102, 86);
            this.generalCodeTextBox.MaxLength = 13;
            this.generalCodeTextBox.Name = "generalCodeTextBox";
            this.generalCodeTextBox.Size = new System.Drawing.Size(270, 21);
            this.generalCodeTextBox.TabIndex = 11;
            this.generalCodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.generalCodeTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // baseLabel2
            // 
            this.baseLabel2.AutoSize = true;
            this.baseLabel2.Location = new System.Drawing.Point(12, 89);
            this.baseLabel2.Name = "baseLabel2";
            this.baseLabel2.Size = new System.Drawing.Size(86, 13);
            this.baseLabel2.TabIndex = 10;
            this.baseLabel2.Text = "General Code";
            // 
            // orderCodeTextBox
            // 
            this.orderCodeTextBox.Location = new System.Drawing.Point(102, 123);
            this.orderCodeTextBox.MaxLength = 30;
            this.orderCodeTextBox.Name = "orderCodeTextBox";
            this.orderCodeTextBox.Size = new System.Drawing.Size(270, 21);
            this.orderCodeTextBox.TabIndex = 13;
            this.orderCodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.orderCodeTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // baseLabel3
            // 
            this.baseLabel3.AutoSize = true;
            this.baseLabel3.Location = new System.Drawing.Point(24, 126);
            this.baseLabel3.Name = "baseLabel3";
            this.baseLabel3.Size = new System.Drawing.Size(74, 13);
            this.baseLabel3.TabIndex = 12;
            this.baseLabel3.Text = "Order Code";
            // 
            // currentQuantityTextBox
            // 
            this.currentQuantityTextBox.Location = new System.Drawing.Point(104, 234);
            this.currentQuantityTextBox.Name = "currentQuantityTextBox";
            this.currentQuantityTextBox.Size = new System.Drawing.Size(62, 21);
            this.currentQuantityTextBox.TabIndex = 15;
            this.currentQuantityTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.currentQuantityTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // baseLabel4
            // 
            this.baseLabel4.AutoSize = true;
            this.baseLabel4.Location = new System.Drawing.Point(20, 237);
            this.baseLabel4.Name = "baseLabel4";
            this.baseLabel4.Size = new System.Drawing.Size(78, 13);
            this.baseLabel4.TabIndex = 14;
            this.baseLabel4.Text = "Current QTY";
            // 
            // usedQuantityTextBox
            // 
            this.usedQuantityTextBox.Location = new System.Drawing.Point(310, 234);
            this.usedQuantityTextBox.Name = "usedQuantityTextBox";
            this.usedQuantityTextBox.Size = new System.Drawing.Size(62, 21);
            this.usedQuantityTextBox.TabIndex = 17;
            this.usedQuantityTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.usedQuantityTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // baseLabel5
            // 
            this.baseLabel5.AutoSize = true;
            this.baseLabel5.Location = new System.Drawing.Point(242, 237);
            this.baseLabel5.Name = "baseLabel5";
            this.baseLabel5.Size = new System.Drawing.Size(62, 13);
            this.baseLabel5.TabIndex = 16;
            this.baseLabel5.Text = "Used QTY";
            // 
            // baseLabel6
            // 
            this.baseLabel6.AutoSize = true;
            this.baseLabel6.Location = new System.Drawing.Point(61, 163);
            this.baseLabel6.Name = "baseLabel6";
            this.baseLabel6.Size = new System.Drawing.Size(35, 13);
            this.baseLabel6.TabIndex = 10;
            this.baseLabel6.Text = "Type";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(102, 160);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(270, 21);
            this.typeTextBox.TabIndex = 11;
            this.typeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.typeTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // baseLabel7
            // 
            this.baseLabel7.AutoSize = true;
            this.baseLabel7.Location = new System.Drawing.Point(43, 200);
            this.baseLabel7.Name = "baseLabel7";
            this.baseLabel7.Size = new System.Drawing.Size(53, 13);
            this.baseLabel7.TabIndex = 12;
            this.baseLabel7.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(102, 197);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(270, 21);
            this.addressTextBox.TabIndex = 13;
            this.addressTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.addressTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(12, 291);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // NewItemForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(387, 325);
            this.ControlBox = false;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.usedQuantityTextBox);
            this.Controls.Add(this.baseLabel5);
            this.Controls.Add(this.currentQuantityTextBox);
            this.Controls.Add(this.baseLabel4);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.orderCodeTextBox);
            this.Controls.Add(this.baseLabel7);
            this.Controls.Add(this.baseLabel3);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.baseLabel6);
            this.Controls.Add(this.generalCodeTextBox);
            this.Controls.Add(this.baseLabel2);
            this.Controls.Add(this.persNameTextBox);
            this.Controls.Add(this.baseLabel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.engNameTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.MaximumSize = new System.Drawing.Size(403, 364);
            this.MinimumSize = new System.Drawing.Size(403, 364);
            this.Name = "NewItemForm";
            this.Text = "Add New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infrastructure.BaseLabel fullNameLabel;
        private Infrastructure.BaseTextBox engNameTextBox;
        private Infrastructure.BaseButton saveButton;
        private Infrastructure.BaseButton cancelButton;
        private Infrastructure.BaseTextBox persNameTextBox;
        private Infrastructure.BaseLabel baseLabel1;
        private Infrastructure.BaseTextBox generalCodeTextBox;
        private Infrastructure.BaseLabel baseLabel2;
        private Infrastructure.BaseTextBox orderCodeTextBox;
        private Infrastructure.BaseLabel baseLabel3;
        private Infrastructure.BaseTextBox currentQuantityTextBox;
        private Infrastructure.BaseLabel baseLabel4;
        private Infrastructure.BaseTextBox usedQuantityTextBox;
        private Infrastructure.BaseLabel baseLabel5;
        private Infrastructure.BaseLabel baseLabel6;
        private Infrastructure.BaseTextBox typeTextBox;
        private Infrastructure.BaseLabel baseLabel7;
        private Infrastructure.BaseTextBox addressTextBox;
        private Infrastructure.BaseButton resetButton;
    }
}
