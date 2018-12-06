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
                    addressTextBox.Text = foundedItem.Address;
                    typeTextBox.Text = foundedItem.Type;
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
                errorMessage = "English name must be filled!";
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
                errorMessage = "Persian name must be filled!";
            }

            if (generalCodeTextBox.Text.Length != 13)
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }

                errorMessage += "General code must be 13 digits!";
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
                errorMessage = "Order code must be filled!";
            }

            if (string.IsNullOrWhiteSpace(typeTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage = "type must be filled!";
            }

            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage = "Address must be filled!";
            }

            if (string.IsNullOrWhiteSpace(currentQuantityTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage = "Current quantity must be filled!";
            }

            if (string.IsNullOrWhiteSpace(currentQuantityTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }
                errorMessage = "Used quantity must be filled!";
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
                    foundedItem.Address = addressTextBox.Text;
                    foundedItem.Type = typeTextBox.Text;
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
