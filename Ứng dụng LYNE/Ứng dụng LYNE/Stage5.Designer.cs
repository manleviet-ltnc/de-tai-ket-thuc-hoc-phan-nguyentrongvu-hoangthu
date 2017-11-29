namespace Ứng_dụng_LYNE
{
    partial class frmStage5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage5));
            this.btnMenu5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu5
            // 
            this.btnMenu5.Location = new System.Drawing.Point(54, 31);
            this.btnMenu5.Name = "btnMenu5";
            this.btnMenu5.Size = new System.Drawing.Size(76, 41);
            this.btnMenu5.TabIndex = 0;
            this.btnMenu5.Text = "Menu";
            this.btnMenu5.UseVisualStyleBackColor = true;
            this.btnMenu5.Click += new System.EventHandler(this.btnMenu5_Click);
            // 
            // frmStage5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 519);
            this.Controls.Add(this.btnMenu5);
            this.Name = "frmStage5";
            this.Text = "Stage5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu5;
    }
}