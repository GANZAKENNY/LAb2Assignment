namespace lab2
{
    partial class mushroom
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
            lblInfo = new Label();
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = SystemColors.ControlLight;
            lblInfo.Location = new Point(456, 71);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(59, 25);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "label1";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = SystemColors.ControlDarkDark;
            lblQuestion.Location = new Point(456, 284);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(59, 25);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "label2";
            // 
            // btnYes
            // 
            btnYes.Location = new Point(274, 360);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(112, 34);
            btnYes.TabIndex = 2;
            btnYes.Text = "YES";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(629, 360);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(112, 34);
            btnNo.TabIndex = 3;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(128, 255, 128);
            btnBack.Location = new Point(274, 509);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Location = new Point(629, 509);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // mushroom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1131, 643);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblQuestion);
            Controls.Add(lblInfo);
            Name = "mushroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom Identifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Label lblQuestion;
        private Button btnYes;
        private Button btnNo;
        private Button btnBack;
        private Button btnLogout;
    }
}