namespace Multi_Media.View
{ 
    partial class arth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arth));
            this.mainGrp = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textBox1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Button1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrp)).BeginInit();
            this.mainGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrp
            // 
            this.mainGrp.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainGrp.AppearanceCaption.Options.UseFont = true;
            this.mainGrp.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainGrp.CaptionImageOptions.SvgImage")));
            this.mainGrp.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(40, 40);
            this.mainGrp.Controls.Add(this.dataGridView2);
            this.mainGrp.Controls.Add(this.dataGridView1);
            this.mainGrp.Controls.Add(this.panelControl1);
            this.mainGrp.Controls.Add(this.labelControl1);
            this.mainGrp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrp.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.mainGrp.Location = new System.Drawing.Point(0, 0);
            this.mainGrp.Name = "mainGrp";
            this.mainGrp.Size = new System.Drawing.Size(788, 473);
            this.mainGrp.TabIndex = 0;
            this.mainGrp.Text = "ARTH";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.Button1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(788, 74);
            this.panelControl1.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textBox1.Properties.AutoHeight = false;
            this.textBox1.Size = new System.Drawing.Size(340, 44);
            this.textBox1.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cairo", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 36);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Input";
            // 
            // Button1
            // 
            this.Button1.AllowFocus = false;
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button1.Appearance.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Appearance.Options.UseFont = true;
            this.Button1.AppearanceHovered.Font = new System.Drawing.Font("Cairo", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.AppearanceHovered.Options.UseFont = true;
            this.Button1.AppearancePressed.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.AppearancePressed.Options.UseFont = true;
            this.Button1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.Button1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button1.ImageOptions.SvgImage")));
            this.Button1.Location = new System.Drawing.Point(472, 14);
            this.Button1.Name = "Button1";
            this.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button1.Size = new System.Drawing.Size(124, 47);
            this.Button1.TabIndex = 31;
            this.Button1.Text = "Decode";
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Size = new System.Drawing.Size(333, 283);
            this.dataGridView1.TabIndex = 36;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(417, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.Size = new System.Drawing.Size(333, 283);
            this.dataGridView2.TabIndex = 37;
            // 
            // arth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(788, 473);
            this.Controls.Add(this.mainGrp);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "arth";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Click += new System.EventHandler(this.arth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrp)).EndInit();
            this.mainGrp.ResumeLayout(false);
            this.mainGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl mainGrp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textBox1;
        private DevExpress.XtraEditors.SimpleButton Button1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}