namespace Ứng_dụng_LYNE
{
    partial class frmStage10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage10));
            this.btnMenu10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu10
            // 
            this.btnMenu10.Location = new System.Drawing.Point(34, 28);
            this.btnMenu10.Name = "btnMenu10";
            this.btnMenu10.Size = new System.Drawing.Size(76, 44);
            this.btnMenu10.TabIndex = 0;
            this.btnMenu10.Text = "Menu";
            this.btnMenu10.UseVisualStyleBackColor = true;
            this.btnMenu10.Click += new System.EventHandler(this.btnMenu10_Click);
            // 
            // frmStage10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 519);
            this.Controls.Add(this.btnMenu10);
            this.Name = "frmStage10";
            this.Text = "Stage10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu10;
    }
}