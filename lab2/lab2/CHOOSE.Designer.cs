namespace lab2
{
    partial class CHOOSE
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            SuspendLayout();
            // 
            // btnBicycle
            // 
            btnBicycle.ForeColor = Color.Red;
            btnBicycle.Location = new Point(118, 158);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(112, 34);
            btnBicycle.TabIndex = 0;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = true;
            // 
            // btnMushroom
            // 
            btnMushroom.ForeColor = Color.Red;
            btnMushroom.Location = new Point(407, 158);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(112, 34);
            btnMushroom.TabIndex = 1;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = true;
            // 
            // CHOOSE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Name = "CHOOSE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            Load += CHOOSE_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBicycle;
        private Button btnMushroom;
    }
}