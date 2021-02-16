namespace Multi_Media.View
{
    partial class data_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_show));
            this.mainGrp = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrp)).BeginInit();
            this.mainGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrp
            // 
            this.mainGrp.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainGrp.AppearanceCaption.Options.UseFont = true;
            this.mainGrp.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainGrp.CaptionImageOptions.SvgImage")));
            this.mainGrp.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(40, 40);
            this.mainGrp.Controls.Add(this.dataGridView1);
            this.mainGrp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrp.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.mainGrp.Location = new System.Drawing.Point(0, 0);
            this.mainGrp.Name = "mainGrp";
            this.mainGrp.Size = new System.Drawing.Size(626, 461);
            this.mainGrp.TabIndex = 0;
            this.mainGrp.Text = "Data Show";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(23, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Size = new System.Drawing.Size(557, 283);
            this.dataGridView1.TabIndex = 7;
            // 
            // data_show
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(626, 461);
            this.Controls.Add(this.mainGrp);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "data_show";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.data_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrp)).EndInit();
            this.mainGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl mainGrp;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}