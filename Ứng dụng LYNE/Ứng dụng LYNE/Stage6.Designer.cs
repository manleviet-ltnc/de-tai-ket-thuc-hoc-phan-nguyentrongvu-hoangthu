namespace Ứng_dụng_LYNE
{
    partial class frmStage6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage6));
            this.btnMenu6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu6
            // 
            this.btnMenu6.Location = new System.Drawing.Point(53, 35);
            this.btnMenu6.Name = "btnMenu6";
            this.btnMenu6.Size = new System.Drawing.Size(78, 44);
            this.btnMenu6.TabIndex = 0;
            this.btnMenu6.Text = "Menu";
            this.btnMenu6.UseVisualStyleBackColor = true;
            this.btnMenu6.Click += new System.EventHandler(this.btnMenu6_Click);
            // 
            // frmStage6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 519);
            this.Controls.Add(this.btnMenu6);
            this.Name = "frmStage6";
            this.Text = "Stage6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu6;
    }
}