using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class CHOOSE : Form
    {
        public CHOOSE()
        {
            InitializeComponent();
            btnBicycle.Click += btnBicycle_Click;
            btnMushroom.Click += btnMushroom_Click;
        }

        private void CHOOSE_Load(object? sender, EventArgs e)
        {
        }

        private void btnBicycle_Click(object? sender, EventArgs e)
        {
            Bicycle bicycle = new Bicycle();
            bicycle.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object? sender, EventArgs e)
        {
            mushroom m = new mushroom();
            m.Show();
            this.Hide();
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