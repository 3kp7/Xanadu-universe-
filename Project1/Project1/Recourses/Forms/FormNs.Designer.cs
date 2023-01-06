
namespace Project1.Recourses.Forms
{
    partial class FormNs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNs));
            this.Media1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Media1)).BeginInit();
            this.SuspendLayout();
            // 
            // Media1
            // 
            this.Media1.Enabled = true;
            this.Media1.Location = new System.Drawing.Point(12, 12);
            this.Media1.Name = "Media1";
            this.Media1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media1.OcxState")));
            this.Media1.Size = new System.Drawing.Size(344, 256);
            this.Media1.TabIndex = 0;
            // 
            // FormNs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(608, 329);
            this.Controls.Add(this.Media1);
            this.Name = "FormNs";
            this.Text = "FormNs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Media1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Media1;
    }
}