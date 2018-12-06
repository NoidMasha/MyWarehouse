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
            addressTextBox.Clear();
            typeTextBox.Clear();
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
                Models.Item newItem = new Models.Item();

                newItem.EnglishName = engNameTextBox.Text;
                newItem.PersianName = persNameTextBox.Text;
                newItem.GeneralCode = generalCodeTextBox.Text;
                newItem.OrderCode = orderCodeTextBox.Text;
                newItem.Address = addressTextBox.Text;
                newItem.Type = typeTextBox.Text;
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
