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
            this.pbxStage11 = new System.Windows.Forms.PictureBox();
            this.pbxStage12 = new System.Windows.Forms.PictureBox();
            this.pbxStage13 = new System.Windows.Forms.PictureBox();
            this.btnMenu1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStage11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStage12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStage13)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxStage11
            // 
            this.pbxStage11.Image = ((System.Drawing.Image)(resources.GetObject("pbxStage11.Image")));
            this.pbxStage11.Location = new System.Drawing.Point(149, 186);
            this.pbxStage11.Name = "pbxStage11";
            this.pbxStage11.Size = new System.Drawing.Size(96, 82);
            this.pbxStage11.TabIndex = 0;
            this.pbxStage11.TabStop = false;
            // 
            // pbxStage12
            // 
            this.pbxStage12.Image = ((System.Drawing.Image)(resources.GetObject("pbxStage12.Image")));
            this.pbxStage12.Location = new System.Drawing.Point(312, 186);
            this.pbxStage12.Name = "pbxStage12";
            this.pbxStage12.Size = new System.Drawing.Size(97, 82);
            this.pbxStage12.TabIndex = 0;
            this.pbxStage12.TabStop = false;
            // 
            // pbxStage13
            // 
            this.pbxStage13.Image = ((System.Drawing.Image)(resources.GetObject("pbxStage13.Image")));
            this.pbxStage13.Location = new System.Drawing.Point(463, 186);
            this.pbxStage13.Name = "pbxStage13";
            this.pbxStage13.Size = new System.Drawing.Size(96, 82);
            this.pbxStage13.TabIndex = 0;
            this.pbxStage13.TabStop = false;
            // 
            // btnMenu1
            // 
            this.btnMenu1.Location = new System.Drawing.Point(58, 24);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(91, 51);
            this.btnMenu1.TabIndex = 1;
            this.btnMenu1.Text = "Menu";
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // frmStage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 519);
            this.Controls.Add(this.btnMenu1);
            this.Controls.Add(this.pbxStage13);
            this.Controls.Add(this.pbxStage12);
            this.Controls.Add(this.pbxStage11);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStage1";
            this.Text = "stage 1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxStage11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStage12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStage13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxStage11;
        private System.Windows.Forms.PictureBox pbxStage12;
        private System.Windows.Forms.PictureBox pbxStage13;
        private System.Windows.Forms.Button btnMenu1;
    }
}