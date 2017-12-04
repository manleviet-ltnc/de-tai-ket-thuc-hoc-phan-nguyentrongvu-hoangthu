namespace Ứng_dụng_LYNE
{
    partial class frmStage9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage9));
            this.btnMenu9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu9
            // 
            this.btnMenu9.Location = new System.Drawing.Point(75, 32);
            this.btnMenu9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu9.Name = "btnMenu9";
            this.btnMenu9.Size = new System.Drawing.Size(92, 53);
            this.btnMenu9.TabIndex = 0;
            this.btnMenu9.Text = "Menu";
            this.btnMenu9.UseVisualStyleBackColor = true;
            this.btnMenu9.Click += new System.EventHandler(this.btnMenu9_Click);
            // 
            // frmStage9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 709);
            this.Controls.Add(this.btnMenu9);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStage9";
            this.Text = "Stage9";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu9;
    }
}