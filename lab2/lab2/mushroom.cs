using System;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class mushroom : Form
    {
        private int step = 1;
        private bool hasRing = false;

        public mushroom()
        {
            InitializeComponent();
            btnYes.Click += btnYes_Click;
            btnNo.Click += btnNo_Click;
            btnBack.Click += btnBack_Click;
            btnLogout.Click += btnLogout_Click;
            StartOver();
        }

        private void mushroom_Load(object? sender, EventArgs e)
        {
        }

        private void StartOver()
        {
            step = 1;
            hasRing = false;

            lblInfo.Text = "Think of one of these mushrooms:" + Environment.NewLine +
                           " - Agaric jaunissant" + Environment.NewLine +
                           " - Amanite tue-mouche" + Environment.NewLine +
                           " - Cepe de bordeaux" + Environment.NewLine +
                           " - Coprin chevelu" + Environment.NewLine +
                           " - Girolle" + Environment.NewLine +
                           " - Pied bleu";

            lblQuestion.Text = "Does your mushroom have a ring?";
        }

        private void ShowResult(string name)
        {
            MessageBox.Show("Your mushroom is: " + name, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartOver();
        }

        private void Answer(bool yes)
        {
            if (step == 1)
            {
                hasRing = yes;
                if (yes)
                {
                    step = 2;
                    lblQuestion.Text = "Does your mushroom grow in a forest?";
                }
                else
                {
                    step = 3;
                    lblQuestion.Text = "Does your mushroom have gills?";
                }
            }
            else if (step == 2)
            {
                if (yes)
                {
                    ShowResult("Amanite tue-mouche");
                }
                else
                {
                    step = 4;
                    lblQuestion.Text = "Does your mushroom have a convex cup?";
                }
            }
            else if (step == 3)
            {
                if (!yes)
                {
                    ShowResult("Cepe de bordeaux");
                }
                else
                {
                    step = 4;
                    lblQuestion.Text = "Does your mushroom have a convex cup?";
                }
            }
            else if (step == 4)
            {
                if (hasRing)
                {
                    if (yes)
                        ShowResult("Agaric jaunissant");
                    else
                        ShowResult("Coprin chevelu");
                }
                else
                {
                    if (yes)
                        ShowResult("Pied bleu");
                    else
                        ShowResult("Girolle");
                }
            }
        }

        private void btnYes_Click(object? sender, EventArgs e)
        {
            Answer(true);
        }

        private void btnNo_Click(object? sender, EventArgs e)
        {
            Answer(false);
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