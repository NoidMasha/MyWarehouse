using System.Linq;

namespace MyUserManagement
{
    public partial class ItemsListForm : Infrastructure.BaseForm
    {
        public ItemsListForm()
        {
            InitializeComponent();
        }
        private void searchButton_Click(object sender, System.EventArgs e)
        {
            search();
        }

        public string GeneralCodeText
        {
            set
            {
                generalCodeTextBox.Text = value;
            }
        }

        public void search()
        {
            System.Collections.Generic.List<Models.Item> items = null;

            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();

                nameTextBox.Text = nameTextBox.Text.Trim();

                while (nameTextBox.Text.Contains("  "))
                {
                    nameTextBox.Text = nameTextBox.Text.Replace("  ", " ");
                }

                #region different search types
                if (nameTextBox.Text == string.Empty && generalCodeTextBox.Text == string.Empty && orderCodeTextBox.Text == string.Empty)
                {
                    items = databaseContext.Items.OrderBy(current => current.EnglishName).ToList();
                }

                else if (generalCodeTextBox.Text == string.Empty && orderCodeTextBox.Text == string.Empty)
                {
                    items = databaseContext.Items
                            .Where(current => (current.EnglishName.Contains(nameTextBox.Text)
                            || current.PersianName.Contains(nameTextBox.Text))).ToList();
                    items = items.OrderBy(current => current.EnglishName).ToList();
                }

                else if (nameTextBox.Text == string.Empty && orderCodeTextBox.Text == string.Empty)
                {
                    items = databaseContext.Items
                            .Where(current => (current.GeneralCode.Contains(generalCodeTextBox.Text))).ToList();
                    items = items.OrderBy(current => current.EnglishName).ToList();
                }

                else if (nameTextBox.Text == string.Empty && generalCodeTextBox.Text == string.Empty)
                {
                    items = databaseContext.Items
                            .Where(current => (current.OrderCode.Contains(orderCodeTextBox.Text))).ToList();
                    items = items.OrderBy(current => current.EnglishName).ToList();
                }

                else if (nameTextBox.Text == string.Empty)
                {
                    items = databaseContext.Items
                            .Where(current => (current.GeneralCode.Contains(generalCodeTextBox.Text)
                            && current.OrderCode.Contains(orderCodeTextBox.Text))).ToList();
                    items = items.OrderBy(current => current.EnglishName).ToList();
                }

                else if (generalCodeTextBox.Text == string.Empty)
                {
                    items = databaseContext.Items
                            .Where(current => ((current.EnglishName.Contains(nameTextBox.Text)
                            || current.PersianName.Contains(nameTextBox.Text))
                            && current.OrderCode.Contains(orderCodeTextBox.Text))).ToList();
                    items = items.OrderBy(current => current.EnglishName).ToList();
                }

                else if (orderCodeTextBox.Text == string.Empty)
                {
                    items = databaseContext.Items
                            .Where(current => ((current.EnglishName.Contains(nameTextBox.Text)
                            || current.PersianName.Contains(nameTextBox.Text))
                            && current.GeneralCode.Contains(generalCodeTextBox.Text))).ToList();
                    items = items.OrderBy(current => current.EnglishName).ToList();
                }

                else
                {
                    items = databaseContext.Items
                            .Where(current => ((current.EnglishName.Contains(nameTextBox.Text)
                            || current.PersianName.Contains(nameTextBox.Text))
                            && current.OrderCode.Contains(orderCodeTextBox.Text)
                            && current.GeneralCode.Contains(generalCodeTextBox.Text))).ToList();
                    items = items.OrderBy(current => current.EnglishName).ToList();
                }

                #endregion \different search types
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

            ItemsDataGridView.DataSource = items;
            ItemsDataGridView.Columns["Id"].Visible = false;
            //ItemsDataGridView.Columns[0].HeaderText = "Persian Name";
        }


        private void ItemsDataGridView_DoubleClick(object sender, System.EventArgs e)
        {
            if (ItemsDataGridView.RowCount == 0)
            {
                return;
            }

            if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
            {
                Models.Item selectedItem = ItemsDataGridView.CurrentRow.DataBoundItem as Models.Item;


                //*******************************************************************************************
                System.Drawing.Point selectedCell = ItemsDataGridView.CurrentCellAddress;
                //*******************************************************************************************

                if (selectedItem != null)
                {
                    Admin.UpdateItemForm updateItemForm = new Admin.UpdateItemForm()
                    {
                        SelectedItem = selectedItem,

                        //*************************************
                        SelectedCellColumn = selectedCell.X
                        //*************************************
                    };

                    updateItemForm.ShowDialog();

                    search();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You are not an Admin, and not allowed to modify any item!");
            }
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {

            if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
            {
                if (ItemsDataGridView.SelectedRows.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("No item is selected!");

                    return;
                }

                Models.DatabaseContext databaseContext = null;

                try
                {
                    databaseContext = new Models.DatabaseContext();

                    for (int selectedRowIndex=0; selectedRowIndex < ItemsDataGridView.SelectedRows.Count; selectedRowIndex++)
                    {
                        Models.Item selectedItem = ItemsDataGridView.SelectedRows[selectedRowIndex].DataBoundItem as Models.Item;
                            
                        if (selectedItem != null)
                        {
                            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show($"Are you sure to delete [{selectedItem.EnglishName}] ?"
                                , "Delete item", System.Windows.Forms.MessageBoxButtons.YesNo
                                , System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                databaseContext.Entry(selectedItem).State = System.Data.Entity.EntityState.Deleted;
                                databaseContext.SaveChanges();
                                System.Windows.Forms.MessageBox.Show($"[{selectedItem.EnglishName}] deleted!");
                            }
                        }
                    }

                    search();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
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
            else
            {
                System.Windows.Forms.MessageBox.Show("You are not an Admin!\nOnly an admin can delete items.");
            }
        }
    }
}
