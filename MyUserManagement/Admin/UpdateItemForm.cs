using System.Linq;


namespace MyUserManagement.Admin
{
    public partial class UpdateItemForm : Infrastructure.BaseForm
    {
        public UpdateItemForm()
        {
            InitializeComponent();
        }


        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        public Models.Item SelectedItem { get; set; }
        public int SelectedCellColumn { get; set; }

        private void UpdateItemForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.Item foundedItem = databaseContext.Items.Where(current => current.Id == SelectedItem.Id).FirstOrDefault();

                if (foundedItem == null)
                {
                    System.Windows.Forms.MessageBox.Show("There isn't such item anymore!");
                    Close();
                }
                else
                {
                    engNameTextBox.Text = foundedItem.EnglishName;
                    persNameTextBox.Text = foundedItem.PersianName;
                    generalCodeTextBox.Text = foundedItem.GeneralCode;
                    orderCodeTextBox.Text = foundedItem.OrderCode;

                    addressRegalComboBox.SelectedIndex =
                        addressRegalComboBox.FindStringExact(foundedItem.Address.Substring(0, 1));
                    addressFloorComboBox.SelectedIndex =
                        addressFloorComboBox.FindStringExact(foundedItem.Address.Substring(2, 1));
                    addressTruncComboBox.SelectedIndex =
                        addressTruncComboBox.FindStringExact(foundedItem.Address.Substring(4, 1));

                    typeComboBox.SelectedIndex = typeComboBox.FindStringExact(foundedItem.Type);

                    currentQuantityTextBox.Text = foundedItem.CurrentQuantity.ToString();
                    usedQuantityTextBox.Text = foundedItem.UsedQuantity.ToString();
                }
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

                //*******************************************************************************
                switch (SelectedCellColumn)
                {
                    case 0:
                        ActiveControl = engNameTextBox;
                        break;
                    case 1:
                        ActiveControl = persNameTextBox;
                        break;
                    case 2:
                        ActiveControl = generalCodeTextBox;
                        break;
                    case 3:
                        ActiveControl = orderCodeTextBox;
                        break;
                    case 4:
                        ActiveControl = currentQuantityTextBox;
                        break;
                    case 5:
                        ActiveControl = usedQuantityTextBox;
                        break;
                    case 6:
                        ActiveControl = typeComboBox;
                        break;
                    case 7:
                        ActiveControl = addressRegalComboBox;
                        break;
                }

                //*******************************************************************************
            }
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
                Models.Item foundedItem = databaseContext.Items.Where(current => current.Id == SelectedItem.Id).FirstOrDefault();

                if (foundedItem == null)
                {
                    System.Windows.Forms.MessageBox.Show("There isn't such user anymore!");
                    Close();
                }
                else
                {
                    foundedItem.EnglishName = engNameTextBox.Text;
                    foundedItem.PersianName = persNameTextBox.Text;
                    foundedItem.GeneralCode = generalCodeTextBox.Text;
                    foundedItem.OrderCode = orderCodeTextBox.Text;
                    foundedItem.Address =
                        $"{addressRegalComboBox.SelectedItem.ToString()}-{addressFloorComboBox.SelectedItem.ToString()}-{addressTruncComboBox.SelectedItem.ToString()}";
                    foundedItem.Type = typeComboBox.SelectedItem.ToString();
                    foundedItem.CurrentQuantity = int.Parse(currentQuantityTextBox.Text);
                    foundedItem.UsedQuantity = int.Parse(usedQuantityTextBox.Text);

                    databaseContext.SaveChanges();
                    System.Windows.Forms.MessageBox.Show("Update succesful!");
                    Close();
                }
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
