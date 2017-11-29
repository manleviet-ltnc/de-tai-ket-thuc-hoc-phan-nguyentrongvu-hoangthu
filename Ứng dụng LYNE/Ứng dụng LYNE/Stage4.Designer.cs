namespace Ứng_dụng_LYNE
{
    partial class frmStage4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage4));
            this.btnMenu4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu4
            // 
            this.btnMenu4.Location = new System.Drawing.Point(50, 32);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(78, 42);
            this.btnMenu4.TabIndex = 0;
            this.btnMenu4.Text = "Menu";
            this.btnMenu4.UseVisualStyleBackColor = true;
            this.btnMenu4.Click += new System.EventHandler(this.btnMenu4_Click);
            // 
            // frmStage4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 519);
            this.Controls.Add(this.btnMenu4);
            this.Name = "frmStage4";
            this.Text = "Stage4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu4;
    }
}