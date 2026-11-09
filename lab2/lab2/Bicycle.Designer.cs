namespace lab2
{
    partial class Bicycle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtStart = new TextBox();
            label2 = new Label();
            txtEnd = new TextBox();
            label3 = new Label();
            btnCalculate = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 88);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Starting hour (0 - 23):";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(325, 88);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(150, 31);
            txtStart.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 170);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 2;
            label2.Text = "Ending hour (1 - 24):";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(325, 170);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(150, 31);
            txtEnd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 316);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 4;
            label3.Text = "Total:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Green;
            btnCalculate.Location = new Point(341, 251);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 192, 192);
            btnBack.Location = new Point(234, 373);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Location = new Point(458, 373);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(325, 310);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 8;
            // 
            // Bicycle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(txtEnd);
            Controls.Add(label2);
            Controls.Add(txtStart);
            Controls.Add(label1);
            Name = "Bicycle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle Rental";
            Load += Bicycle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStart;
        private Label label2;
        private TextBox txtEnd;
        private Label label3;
        private Button btnCalculate;
        private Button btnBack;
        private Button btnLogout;
        private TextBox txtTotal;
    }
}