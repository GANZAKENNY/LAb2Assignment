using System;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bicycle : Form
    {
        public Bicycle()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click;
            btnBack.Click += btnBack_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void Bicycle_Load(object? sender, EventArgs e)
        {
        }

        private int GetRate(int hour)
        {
            if (hour >= 0 && hour < 7)
                return 500;
            else if (hour >= 7 && hour < 14)
                return 1000;
            else if (hour >= 14 && hour < 19)
                return 1500;
            else if (hour >= 19 && hour < 21)
                return 1000;
            else
                return 500;
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            int start;
            int end;
            txtTotal.Text = "";

            if (!int.TryParse(txtStart.Text.Trim(), out start))
            {
                MessageBox.Show("Starting hour must be a whole number (no decimals, no letters).", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStart.Focus();
                return;
            }

            if (!int.TryParse(txtEnd.Text.Trim(), out end))
            {
                MessageBox.Show("Ending hour must be a whole number (no decimals, no letters).", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd.Focus();
                return;
            }

            if (start < 0 || start > 23)
            {
                MessageBox.Show("Starting hour must be between 0 and 23.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStart.Focus();
                return;
            }

            if (end < 1 || end > 24)
            {
                MessageBox.Show("Ending hour must be between 1 and 24.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd.Focus();
                return;
            }

            if (end <= start)
            {
                MessageBox.Show("Ending hour must be greater than the starting hour.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd.Focus();
                return;
            }

            int total = 0;
            for (int hour = start; hour < end; hour++)
            {
                total = total + GetRate(hour);
            }

            txtTotal.Text = total.ToString() + " RWF";

            MessageBox.Show("Total hours: " + (end - start) + Environment.NewLine + "Total to pay: " + total + " RWF", "Rental result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is CHOOSE)
                {
                    f.Show();
                    break;
                }
            }
            this.Close();
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
            {
                if (f is LOGIN)
                {
                    ((LOGIN)f).ClearFields();
                    f.Show();
                }
                else if (f != this)
                {
                    f.Close();
                }
            }
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            bool otherFormVisible = Application.OpenForms.Cast<Form>().Any(f => f != this && f.Visible);
            if (!otherFormVisible)
            {
                Application.Exit();
            }
        }
    }
}