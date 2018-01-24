namespace Ứng_dụng_LYNE
{
    partial class frmStage2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage2));
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu2
            // 
            this.btnMenu2.Location = new System.Drawing.Point(33, 15);
            this.btnMenu2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(113, 57);
            this.btnMenu2.TabIndex = 0;
            this.btnMenu2.Text = "Menu";
            this.btnMenu2.UseVisualStyleBackColor = true;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // frmStage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 709);
            this.Controls.Add(this.btnMenu2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStage2";
            this.Text = "Stage2";
            this.Load += new System.EventHandler(this.frmStage2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmStage2_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStage2_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu2;
    }
}