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
            this.btnMenu4.Location = new System.Drawing.Point(67, 39);
            this.btnMenu4.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(104, 52);
            this.btnMenu4.TabIndex = 0;
            this.btnMenu4.Text = "Menu";
            this.btnMenu4.UseVisualStyleBackColor = true;
            this.btnMenu4.Click += new System.EventHandler(this.btnMenu4_Click);
            // 
            // frmStage4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 709);
            this.Controls.Add(this.btnMenu4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStage4";
            this.Text = "Stage4";
            this.Load += new System.EventHandler(this.frmStage4_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmStage4_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStage4_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu4;
    }
}