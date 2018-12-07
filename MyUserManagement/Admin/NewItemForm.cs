using System.Linq;


namespace MyUserManagement.Admin
{
    public partial class NewItemForm : Infrastructure.BaseForm
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            engNameTextBox.Clear();
            persNameTextBox.Clear();
            generalCodeTextBox.Clear();
            orderCodeTextBox.Clear();
            addressRegalComboBox.SelectedIndex = -1;
            addressFloorComboBox.SelectedIndex = -1;
            addressTruncComboBox.SelectedIndex = -1;
            typeComboBox.SelectedIndex = -1;
            currentQuantityTextBox.Clear();
            usedQuantityTextBox.Clear();
        }

        private string checkInputData()
        {
            string errorMessage = string.Empty;

            if (engNameTextBox.Text.Length > 30)
            {
                errorMessage = "English name can be maximum 30 characters!";
            }
            else if (string.IsNullOrWhiteSpace(engNameTextBox.Text))
            {
                errorMessage += "English name must be filled!";
            }

            if (persNameTextBox.Text.Length > 30)
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }

                errorMessage += "Persian name can be maximum 30 characters!";
            }
            else if (string.IsNullOrWhiteSpace(persNameTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage += "Persian name must be filled!";
            }

            if (!Infrastructure.Utility.validNumber(generalCodeTextBox.Text, 13, 13))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }

                errorMessage += "General code must be 13 Digits!";
            }

            if (orderCodeTextBox.Text.Length > 30)
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }

                errorMessage += "Order code can be maximum 30 characters!";
            }
            else if (string.IsNullOrWhiteSpace(orderCodeTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage += "Order code must be filled!";
            }

            if (addressRegalComboBox.SelectedIndex == -1 || addressFloorComboBox.SelectedIndex == -1 || addressTruncComboBox.SelectedIndex == -1) 
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage += "Select address completely!";
            }

            if (typeComboBox.SelectedIndex == -1)
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage += "Select type!";
            }

            if (string.IsNullOrWhiteSpace(currentQuantityTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage += "Current quantity must be filled!";
            }
            else if (!Infrastructure.Utility.validNumber(currentQuantityTextBox.Text, 1, 4))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage += "Current quantity must be a number between 0-9999!";
            }

            if (string.IsNullOrWhiteSpace(usedQuantityTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage += "Used quantity must be filled!";
            }
            else if (!Infrastructure.Utility.validNumber(usedQuantityTextBox.Text, 1, 4))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage += "used quantity must be a number between 0-9999!";
            }

            return errorMessage;
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {


            string errorMessages = checkInputData();

            if (errorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessages);
                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.Item newItem = databaseContext.Items
                    .Where(current => string.Compare(current.GeneralCode, generalCodeTextBox.Text, true)==0).FirstOrDefault();
                if (newItem != null)
                {
                    System.Windows.Forms.DialogResult result =  System.Windows.Forms.MessageBox
                        .Show("General code already exist!\nDo you want to check the existing item?","item Exists!",System.Windows.Forms.MessageBoxButtons.YesNo
                        ,System.Windows.Forms.MessageBoxIcon.Error,System.Windows.Forms.MessageBoxDefaultButton.Button2);

                    if(result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Location = new System.Drawing.Point(0, 0);

                        Infrastructure.Utility.ItemsListForm.MdiParent = this.MdiParent;
                        Infrastructure.Utility.ItemsListForm.Show();
                        Infrastructure.Utility.ItemsListForm.GeneralCodeText = generalCodeTextBox.Text;
                        Infrastructure.Utility.ItemsListForm.search();
                        Infrastructure.Utility.ItemsListForm.GeneralCodeText = string.Empty;

                    }

                    generalCodeTextBox.Focus();
                    return;
                }

                newItem = new Models.Item();

                newItem.EnglishName = engNameTextBox.Text;
                newItem.PersianName = persNameTextBox.Text;
                newItem.GeneralCode = generalCodeTextBox.Text;
                newItem.OrderCode = orderCodeTextBox.Text;
                newItem.Address = 
                    $"{addressRegalComboBox.SelectedItem.ToString()}-{addressFloorComboBox.SelectedItem.ToString()}-{addressTruncComboBox.SelectedItem.ToString()}";
                newItem.Type = typeComboBox.SelectedItem.ToString();
                newItem.CurrentQuantity = int.Parse(currentQuantityTextBox.Text);
                newItem.UsedQuantity = int.Parse(usedQuantityTextBox.Text);
                databaseContext.Items.Add(newItem);
                databaseContext.SaveChanges();
                System.Windows.Forms.MessageBox.Show("New item added succesfully!");

                resetButton_Click(null, null);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!\n" + ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
