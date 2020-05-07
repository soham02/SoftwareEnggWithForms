namespace ChocoAn
{
    partial class FormDeleteMember
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
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.Location = new System.Drawing.Point(333, 53);
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.Size = new System.Drawing.Size(216, 23);
            this.metroTextBox8.TabIndex = 33;
            this.metroTextBox8.Click += new System.EventHandler(this.metroTextBox8_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(167, 53);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(113, 19);
            this.metroLabel8.TabIndex = 32;
            this.metroLabel8.Text = "Member Number";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(333, 135);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(111, 27);
            this.metroButton1.TabIndex = 34;
            this.metroButton1.Text = "Delete";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FormDeleteMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox8);
            this.Controls.Add(this.metroLabel8);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDeleteMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}