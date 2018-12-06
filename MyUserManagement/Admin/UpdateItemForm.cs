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
