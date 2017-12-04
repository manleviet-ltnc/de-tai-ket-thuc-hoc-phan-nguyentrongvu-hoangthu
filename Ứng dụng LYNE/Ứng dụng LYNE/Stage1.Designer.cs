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
            this.pbxImage1 = new System.Windows.Forms.PictureBox();
            this.pbxImage12 = new System.Windows.Forms.PictureBox();
            this.pbxImage13 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage13)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu1
            // 
            this.btnMenu1.Location = new System.Drawing.Point(77, 30);
            this.btnMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(121, 63);
            this.btnMenu1.TabIndex = 1;
            this.btnMenu1.Text = "Menu";
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // pbxImage1
            // 
            this.pbxImage1.BackColor = System.Drawing.Color.Transparent;
            this.pbxImage1.Image = ((System.Drawing.Image)(resources.GetObject("pbxImage1.Image")));
            this.pbxImage1.Location = new System.Drawing.Point(122, 219);
            this.pbxImage1.Name = "pbxImage1";
            this.pbxImage1.Size = new System.Drawing.Size(105, 101);
            this.pbxImage1.TabIndex = 3;
            this.pbxImage1.TabStop = false;
            this.pbxImage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxImage1_MouseDown);
            // 
            // pbxImage12
            // 
            this.pbxImage12.BackColor = System.Drawing.Color.Transparent;
            this.pbxImage12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxImage12.BackgroundImage")));
            this.pbxImage12.Location = new System.Drawing.Point(336, 219);
            this.pbxImage12.Name = "pbxImage12";
            this.pbxImage12.Size = new System.Drawing.Size(105, 101);
            this.pbxImage12.TabIndex = 4;
            this.pbxImage12.TabStop = false;
            this.pbxImage12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxImage12_MouseUp);
            // 
            // pbxImage13
            // 
            this.pbxImage13.BackColor = System.Drawing.Color.Transparent;
            this.pbxImage13.Image = ((System.Drawing.Image)(resources.GetObject("pbxImage13.Image")));
            this.pbxImage13.Location = new System.Drawing.Point(554, 219);
            this.pbxImage13.Name = "pbxImage13";
            this.pbxImage13.Size = new System.Drawing.Size(105, 101);
            this.pbxImage13.TabIndex = 4;
            this.pbxImage13.TabStop = false;
            // 
            // frmStage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 709);
            this.Controls.Add(this.pbxImage13);
            this.Controls.Add(this.pbxImage12);
            this.Controls.Add(this.pbxImage1);
            this.Controls.Add(this.btnMenu1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStage1";
            this.Text = "stage 1";
            this.Load += new System.EventHandler(this.frmStage1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenu1;
        private System.Windows.Forms.PictureBox pbxImage1;
        private System.Windows.Forms.PictureBox pbxImage12;
        private System.Windows.Forms.PictureBox pbxImage13;
    }
}