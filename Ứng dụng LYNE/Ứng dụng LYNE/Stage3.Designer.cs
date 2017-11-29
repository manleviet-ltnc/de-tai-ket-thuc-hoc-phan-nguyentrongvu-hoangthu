namespace Ứng_dụng_LYNE
{
    partial class frmStage3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage3));
            this.btnMenu3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu3
            // 
            this.btnMenu3.Location = new System.Drawing.Point(41, 25);
            this.btnMenu3.Name = "btnMenu3";
            this.btnMenu3.Size = new System.Drawing.Size(83, 42);
            this.btnMenu3.TabIndex = 0;
            this.btnMenu3.Text = "Menu";
            this.btnMenu3.UseVisualStyleBackColor = true;
            this.btnMenu3.Click += new System.EventHandler(this.btnMenu3_Click);
            // 
            // frmStage3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 519);
            this.Controls.Add(this.btnMenu3);
            this.Name = "frmStage3";
            this.Text = "Stage3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu3;
    }
}