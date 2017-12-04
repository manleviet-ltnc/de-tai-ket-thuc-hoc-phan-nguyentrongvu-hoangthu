namespace Ứng_dụng_LYNE
{
    partial class frmStage8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage8));
            this.btnMenu8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu8
            // 
            this.btnMenu8.Location = new System.Drawing.Point(77, 37);
            this.btnMenu8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu8.Name = "btnMenu8";
            this.btnMenu8.Size = new System.Drawing.Size(95, 54);
            this.btnMenu8.TabIndex = 0;
            this.btnMenu8.Text = "Menu";
            this.btnMenu8.UseVisualStyleBackColor = true;
            this.btnMenu8.Click += new System.EventHandler(this.btnMenu8_Click);
            // 
            // frmStage8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 709);
            this.Controls.Add(this.btnMenu8);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStage8";
            this.Text = "Stage8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu8;
    }
}