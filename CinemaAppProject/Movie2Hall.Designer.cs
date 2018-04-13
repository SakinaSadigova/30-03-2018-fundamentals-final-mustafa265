namespace CinemaAppProject
{
    partial class Movie2Hall
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
            this.SeatsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SeatsTextBox
            // 
            this.SeatsTextBox.Location = new System.Drawing.Point(384, 330);
            this.SeatsTextBox.Name = "SeatsTextBox";
            this.SeatsTextBox.Size = new System.Drawing.Size(100, 20);
            this.SeatsTextBox.TabIndex = 0;
            // 
            // Movie2Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeatsTextBox);
            this.Name = "Movie2Hall";
            this.Text = "Movie2Hall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeatsTextBox;
    }
}