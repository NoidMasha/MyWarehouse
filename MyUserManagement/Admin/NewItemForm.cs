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
        

       
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            string errorMessages = string.Empty;

            if (engNameTextBox.Text.Length > 30)
            {
                errorMessages = "English name can be maximum 30 characters!";
            }

            if (persNameTextBox.Text.Length > 30)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages += "Persian name can be maximum 30 characters!";
            }

            if (generalCodeTextBox.Text.Length != 13)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages += "General code must be 13 digits!";
            }

            if (orderCodeTextBox.Text.Length > 30)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages += "Order code can be maximum 30 characters!";
            }

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
