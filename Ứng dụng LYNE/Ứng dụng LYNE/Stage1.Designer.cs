namespace Ứng_dụng_LYNE
{
    partial class frmStage1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage1));
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu1
            // 
            this.btnMenu1.Location = new System.Drawing.Point(13, 13);
            this.btnMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(121, 63);
            this.btnMenu1.TabIndex = 1;
            this.btnMenu1.Text = "Menu";
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // frmStage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 709);
            this.Controls.Add(this.btnMenu1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStage1";
            this.Text = "stage 1";
            this.Load += new System.EventHandler(this.frmStage1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmStage1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStage1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenu1;
    }
}