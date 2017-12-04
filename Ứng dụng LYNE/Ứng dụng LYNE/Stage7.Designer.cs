namespace Ứng_dụng_LYNE
{
    partial class frmStage7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage7));
            this.btnMenu7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu7
            // 
            this.btnMenu7.Location = new System.Drawing.Point(63, 33);
            this.btnMenu7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu7.Name = "btnMenu7";
            this.btnMenu7.Size = new System.Drawing.Size(104, 50);
            this.btnMenu7.TabIndex = 0;
            this.btnMenu7.Text = "Menu";
            this.btnMenu7.UseVisualStyleBackColor = true;
            this.btnMenu7.Click += new System.EventHandler(this.btnMenu7_Click);
            // 
            // frmStage7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 709);
            this.Controls.Add(this.btnMenu7);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStage7";
            this.Text = "Stage7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu7;
    }
}