using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace lab2
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username and Password cannot be empty.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CHOOSE choose = new CHOOSE();
            choose.Show();
            this.Hide();
        }

        public void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
    }
}