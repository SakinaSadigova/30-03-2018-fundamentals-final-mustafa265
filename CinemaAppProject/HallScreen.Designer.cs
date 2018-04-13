namespace CinemaAppProject
{
    partial class HallScreen
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
            this.MoviShower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoviShower
            // 
            this.MoviShower.Location = new System.Drawing.Point(164, 279);
            this.MoviShower.Name = "MoviShower";
            this.MoviShower.Size = new System.Drawing.Size(75, 23);
            this.MoviShower.TabIndex = 0;
            this.MoviShower.Text = "Next";
            this.MoviShower.UseVisualStyleBackColor = true;
            this.MoviShower.Click += new System.EventHandler(this.MoviShower_Click);
            // 
            // HallScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.MoviShower);
            this.Name = "HallScreen";
            this.Text = "HallScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoviShower;
    }
}