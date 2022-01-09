
namespace LTGD_DOMIN
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelHome = new System.Windows.Forms.Panel();
            this.picBbtLeaderB = new System.Windows.Forms.PictureBox();
            this.picBbtPlay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtLeaderB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackgroundImage = global::LTGD_DOMIN.Properties.Resources.bg_domin2;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelHome.Controls.Add(this.picBbtLeaderB);
            this.panelHome.Controls.Add(this.picBbtPlay);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(977, 548);
            this.panelHome.TabIndex = 0;
            // 
            // picBbtLeaderB
            // 
            this.picBbtLeaderB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBbtLeaderB.Image = ((System.Drawing.Image)(resources.GetObject("picBbtLeaderB.Image")));
            this.picBbtLeaderB.Location = new System.Drawing.Point(195, 384);
            this.picBbtLeaderB.Name = "picBbtLeaderB";
            this.picBbtLeaderB.Size = new System.Drawing.Size(190, 73);
            this.picBbtLeaderB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBbtLeaderB.TabIndex = 4;
            this.picBbtLeaderB.TabStop = false;
            this.picBbtLeaderB.Click += new System.EventHandler(this.picBbtLeaderB_Click);
            // 
            // picBbtPlay
            // 
            this.picBbtPlay.BackgroundImage = global::LTGD_DOMIN.Properties.Resources.buttonPlay;
            this.picBbtPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBbtPlay.Location = new System.Drawing.Point(158, 266);
            this.picBbtPlay.Name = "picBbtPlay";
            this.picBbtPlay.Size = new System.Drawing.Size(263, 101);
            this.picBbtPlay.TabIndex = 3;
            this.picBbtPlay.TabStop = false;
            this.picBbtPlay.Click += new System.EventHandler(this.picBbtPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 149);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dò Mìn";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(977, 548);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtLeaderB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBbtPlay;
        private System.Windows.Forms.PictureBox picBbtLeaderB;
    }
}