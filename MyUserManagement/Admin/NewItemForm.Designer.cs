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
            this.baseLabel7 = new MyUserManagement.Infrastructure.BaseLabel();
            this.resetButton = new MyUserManagement.Infrastructure.BaseButton();
            this.baseLabel10 = new MyUserManagement.Infrastructure.BaseLabel();
            this.baseLabel9 = new MyUserManagement.Infrastructure.BaseLabel();
            this.baseLabel8 = new MyUserManagement.Infrastructure.BaseLabel();
            this.addressTruncComboBox = new System.Windows.Forms.ComboBox();
            this.addressFloorComboBox = new System.Windows.Forms.ComboBox();
            this.addressRegalComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(205, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(297, 291);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // engNameTextBox
            // 
            this.engNameTextBox.Location = new System.Drawing.Point(102, 86);
            this.engNameTextBox.MaxLength = 30;
            this.engNameTextBox.Name = "engNameTextBox";
            this.engNameTextBox.Size = new System.Drawing.Size(270, 21);
            this.engNameTextBox.TabIndex = 5;
            this.engNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.engNameTextBox.WaterMarkText = "Maximum 30 Letters";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(14, 89);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(84, 13);
            this.fullNameLabel.TabIndex = 4;
            this.fullNameLabel.Text = "English Name";
            // 
            // persNameTextBox
            // 
            this.persNameTextBox.Location = new System.Drawing.Point(102, 49);
            this.persNameTextBox.MaxLength = 30;
            this.persNameTextBox.Name = "persNameTextBox";
            this.persNameTextBox.Size = new System.Drawing.Size(270, 21);
            this.persNameTextBox.TabIndex = 3;
            this.persNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.persNameTextBox.WaterMarkText = "Maximum 30 Letters";
            // 
            // baseLabel1
            // 
            this.baseLabel1.AutoSize = true;
            this.baseLabel1.Location = new System.Drawing.Point(12, 52);
            this.baseLabel1.Name = "baseLabel1";
            this.baseLabel1.Size = new System.Drawing.Size(86, 13);
            this.baseLabel1.TabIndex = 2;
            this.baseLabel1.Text = "Persian Name";
            // 
            // generalCodeTextBox
            // 
            this.generalCodeTextBox.Location = new System.Drawing.Point(102, 12);
            this.generalCodeTextBox.MaxLength = 13;
            this.generalCodeTextBox.Name = "generalCodeTextBox";
            this.generalCodeTextBox.Size = new System.Drawing.Size(270, 21);
            this.generalCodeTextBox.TabIndex = 1;
            this.generalCodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.generalCodeTextBox.WaterMarkText = "13 Dogits";
            // 
            // baseLabel2
            // 
            this.baseLabel2.AutoSize = true;
            this.baseLabel2.Location = new System.Drawing.Point(12, 15);
            this.baseLabel2.Name = "baseLabel2";
            this.baseLabel2.Size = new System.Drawing.Size(86, 13);
            this.baseLabel2.TabIndex = 0;
            this.baseLabel2.Text = "General Code";
            // 
            // orderCodeTextBox
            // 
            this.orderCodeTextBox.Location = new System.Drawing.Point(102, 123);
            this.orderCodeTextBox.MaxLength = 30;
            this.orderCodeTextBox.Name = "orderCodeTextBox";
            this.orderCodeTextBox.Size = new System.Drawing.Size(270, 21);
            this.orderCodeTextBox.TabIndex = 7;
            this.orderCodeTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.orderCodeTextBox.WaterMarkText = "Maximum 30 Letters";
            // 
            // baseLabel3
            // 
            this.baseLabel3.AutoSize = true;
            this.baseLabel3.Location = new System.Drawing.Point(24, 126);
            this.baseLabel3.Name = "baseLabel3";
            this.baseLabel3.Size = new System.Drawing.Size(74, 13);
            this.baseLabel3.TabIndex = 6;
            this.baseLabel3.Text = "Order Code";
            // 
            // currentQuantityTextBox
            // 
            this.currentQuantityTextBox.Location = new System.Drawing.Point(104, 234);
            this.currentQuantityTextBox.Name = "currentQuantityTextBox";
            this.currentQuantityTextBox.Size = new System.Drawing.Size(62, 21);
            this.currentQuantityTextBox.TabIndex = 13;
            this.currentQuantityTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.currentQuantityTextBox.WaterMarkText = "0-9999";
            // 
            // baseLabel4
            // 
            this.baseLabel4.AutoSize = true;
            this.baseLabel4.Location = new System.Drawing.Point(20, 237);
            this.baseLabel4.Name = "baseLabel4";
            this.baseLabel4.Size = new System.Drawing.Size(78, 13);
            this.baseLabel4.TabIndex = 12;
            this.baseLabel4.Text = "Current QTY";
            // 
            // usedQuantityTextBox
            // 
            this.usedQuantityTextBox.Location = new System.Drawing.Point(310, 234);
            this.usedQuantityTextBox.Name = "usedQuantityTextBox";
            this.usedQuantityTextBox.Size = new System.Drawing.Size(62, 21);
            this.usedQuantityTextBox.TabIndex = 15;
            this.usedQuantityTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.usedQuantityTextBox.WaterMarkText = "0-9999";
            // 
            // baseLabel5
            // 
            this.baseLabel5.AutoSize = true;
            this.baseLabel5.Location = new System.Drawing.Point(242, 237);
            this.baseLabel5.Name = "baseLabel5";
            this.baseLabel5.Size = new System.Drawing.Size(62, 13);
            this.baseLabel5.TabIndex = 14;
            this.baseLabel5.Text = "Used QTY";
            // 
            // baseLabel6
            // 
            this.baseLabel6.AutoSize = true;
            this.baseLabel6.Location = new System.Drawing.Point(63, 202);
            this.baseLabel6.Name = "baseLabel6";
            this.baseLabel6.Size = new System.Drawing.Size(35, 13);
            this.baseLabel6.TabIndex = 8;
            this.baseLabel6.Text = "Type";
            // 
            // baseLabel7
            // 
            this.baseLabel7.AutoSize = true;
            this.baseLabel7.Location = new System.Drawing.Point(45, 165);
            this.baseLabel7.Name = "baseLabel7";
            this.baseLabel7.Size = new System.Drawing.Size(53, 13);
            this.baseLabel7.TabIndex = 10;
            this.baseLabel7.Text = "Address";
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
            // baseLabel10
            // 
            this.baseLabel10.AutoSize = true;
            this.baseLabel10.Location = new System.Drawing.Point(280, 165);
            this.baseLabel10.Name = "baseLabel10";
            this.baseLabel10.Size = new System.Drawing.Size(14, 13);
            this.baseLabel10.TabIndex = 23;
            this.baseLabel10.Text = "T";
            // 
            // baseLabel9
            // 
            this.baseLabel9.AutoSize = true;
            this.baseLabel9.Location = new System.Drawing.Point(186, 165);
            this.baseLabel9.Name = "baseLabel9";
            this.baseLabel9.Size = new System.Drawing.Size(13, 13);
            this.baseLabel9.TabIndex = 21;
            this.baseLabel9.Text = "F";
            // 
            // baseLabel8
            // 
            this.baseLabel8.AutoSize = true;
            this.baseLabel8.Location = new System.Drawing.Point(102, 165);
            this.baseLabel8.Name = "baseLabel8";
            this.baseLabel8.Size = new System.Drawing.Size(15, 13);
            this.baseLabel8.TabIndex = 19;
            this.baseLabel8.Text = "R";
            // 
            // addressTruncComboBox
            // 
            this.addressTruncComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressTruncComboBox.FormattingEnabled = true;
            this.addressTruncComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.addressTruncComboBox.Location = new System.Drawing.Point(297, 162);
            this.addressTruncComboBox.Name = "addressTruncComboBox";
            this.addressTruncComboBox.Size = new System.Drawing.Size(46, 21);
            this.addressTruncComboBox.TabIndex = 24;
            // 
            // addressFloorComboBox
            // 
            this.addressFloorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressFloorComboBox.FormattingEnabled = true;
            this.addressFloorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.addressFloorComboBox.Location = new System.Drawing.Point(205, 162);
            this.addressFloorComboBox.Name = "addressFloorComboBox";
            this.addressFloorComboBox.Size = new System.Drawing.Size(46, 21);
            this.addressFloorComboBox.TabIndex = 22;
            // 
            // addressRegalComboBox
            // 
            this.addressRegalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressRegalComboBox.FormattingEnabled = true;
            this.addressRegalComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.addressRegalComboBox.Location = new System.Drawing.Point(120, 162);
            this.addressRegalComboBox.Name = "addressRegalComboBox";
            this.addressRegalComboBox.Size = new System.Drawing.Size(46, 21);
            this.addressRegalComboBox.TabIndex = 20;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Spare Part",
            "Tool",
            "Consumable"});
            this.typeComboBox.Location = new System.Drawing.Point(102, 199);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 25;
            // 
            // NewItemForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(387, 325);
            this.ControlBox = false;
            this.Controls.Add(this.baseLabel10);
            this.Controls.Add(this.baseLabel9);
            this.Controls.Add(this.baseLabel8);
            this.Controls.Add(this.addressTruncComboBox);
            this.Controls.Add(this.addressFloorComboBox);
            this.Controls.Add(this.addressRegalComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.usedQuantityTextBox);
            this.Controls.Add(this.baseLabel5);
            this.Controls.Add(this.currentQuantityTextBox);
            this.Controls.Add(this.baseLabel4);
            this.Controls.Add(this.orderCodeTextBox);
            this.Controls.Add(this.baseLabel7);
            this.Controls.Add(this.baseLabel3);
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
        private Infrastructure.BaseLabel baseLabel7;
        private Infrastructure.BaseButton resetButton;
        private Infrastructure.BaseLabel baseLabel10;
        private Infrastructure.BaseLabel baseLabel9;
        private Infrastructure.BaseLabel baseLabel8;
        private System.Windows.Forms.ComboBox addressTruncComboBox;
        private System.Windows.Forms.ComboBox addressFloorComboBox;
        private System.Windows.Forms.ComboBox addressRegalComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}
