using System.Linq;
namespace MyUserManagement
{
    public partial class MainForm : Infrastructure.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void InitializeMainForm()
        {
            adminToolStripMenuItem.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;
            newItemToolStripMenuItem.Enabled = Infrastructure.Utility.AuthenticatedUser.IsAdmin;

            if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName))
            {
                toolStripStatusLabel1.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }";
            }
            else
            {
                toolStripStatusLabel1.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.FullName }";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure to exit?"
                , "Exit Warning"
                , System.Windows.Forms.MessageBoxButtons.YesNo
                , System.Windows.Forms.MessageBoxIcon.Warning
                , System.Windows.Forms.MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private UpdateProfileForm updateForm;
        private void updateProfileToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (updateForm == null || updateForm.IsDisposed)
            {
                updateForm = new UpdateProfileForm();
                updateForm.MdiParent = this;
            }
            updateForm.Show();
        }

        private ChangePasswordForm changePassForm;
        private void changePasswordToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (changePassForm == null || changePassForm.IsDisposed)
            {
                changePassForm = new ChangePasswordForm();
                changePassForm.MdiParent = this;
            }
            changePassForm.Show();
        }

        private Admin.UsersListForm userListForm;
        private void userListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (userListForm == null || userListForm.IsDisposed)
            {
                userListForm = new Admin.UsersListForm();
                userListForm.MdiParent = this;
            }
            userListForm.Show();
        }

        private void newUserRegToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.AdminRegisterForm.MdiParent = this;
            Infrastructure.Utility.AdminRegisterForm.Show();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
            {
                Models.DatabaseContext databaseContext = null;

                try
                {
                    databaseContext = new Models.DatabaseContext();

                    int notActiveUsers = 0;
                    notActiveUsers = databaseContext.Users.Where(current => !current.IsActive).Count();
                        
                    if (notActiveUsers != 0)
                    {
                        if (notActiveUsers == 1)
                        {
                            System.Windows.Forms.MessageBox.Show($"{notActiveUsers} user is waiting for activation!");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show($"{notActiveUsers} users are waiting for activation!");
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
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

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure to logout?"
                                , "Logout Warning"
                                , System.Windows.Forms.MessageBoxButtons.YesNo
                                , System.Windows.Forms.MessageBoxIcon.Warning
                                , System.Windows.Forms.MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Infrastructure.Utility.AuthenticatedUser = null;
                    Infrastructure.Utility.LoginForm.Show();
                }
                else
                {
                    e.Cancel=true;
                }
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void wareHouseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.ItemsListForm.MdiParent = this;
            Infrastructure.Utility.ItemsListForm.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.Calculator.MdiParent = this;
            
            Infrastructure.Utility.Calculator.Show();
            Infrastructure.Utility.Calculator.Location = new System.Drawing.Point
                (this.Size.Width - Infrastructure.Utility.Calculator.Size.Width - 22, 0);
            Infrastructure.Utility.Calculator.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
        }

        private void newItemToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.NewItemForm.Show();
        }
    }
}
