namespace oledbconnectcheck
{
    partial class Form1
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
            this.chechconnection = new System.Windows.Forms.Label();
            this.checkconnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chechconnection
            // 
            this.chechconnection.AutoSize = true;
            this.chechconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chechconnection.Location = new System.Drawing.Point(369, 103);
            this.chechconnection.Name = "chechconnection";
            this.chechconnection.Size = new System.Drawing.Size(0, 29);
            this.chechconnection.TabIndex = 0;
            // 
            // checkconnection
            // 
            this.checkconnection.AutoSize = true;
            this.checkconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkconnection.Location = new System.Drawing.Point(315, 103);
            this.checkconnection.Name = "checkconnection";
            this.checkconnection.Size = new System.Drawing.Size(0, 29);
            this.checkconnection.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 261);
            this.Controls.Add(this.checkconnection);
            this.Controls.Add(this.chechconnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chechconnection;
        private System.Windows.Forms.Label checkconnection;
    }
}

