using System;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;

using System.Collections;
using System.Collections.Generic;


namespace Multi_Media.View
{
    public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static Frm_Main instance = null;

        public Frm_Main()
        {
            if (instance != null)
                return;
            //BonusSkins.Register();

            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Black");


            InitializeComponent();

        }
        //permion omn view for user

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Frm_Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRlcEncoding_Click(object sender, EventArgs e)
        {
            if (input.Text == "" || input.EditValue == null)
                MessageBox.Show("Please enter input ");
            else
            {
                rlc rlc = new rlc(input.Text);
                rlc.ShowDialog();
            }
        }

        private void BtnRlcDecoding_Click(object sender, EventArgs e)
        {
            if (input.Text == "" || input.EditValue == null)
                MessageBox.Show("Please enter input ");
            else
            {
                rlc_decode rlc = new rlc_decode(input.Text);
                rlc.ShowDialog();
            }
        }

        private void BtnShanon_Click(object sender, EventArgs e)
        {
            if (input.Text == "" || input.EditValue == null)
                MessageBox.Show("Please enter input ");
            else
            {
                Shanon rlc = new Shanon(input.Text);
                rlc.ShowDialog();
            }
        }

        private void BtnHuffman_Click(object sender, EventArgs e)
        {
            if (input.Text == "" || input.EditValue == null)
                MessageBox.Show("Please enter input ");
            else
            {
                huffman rlcd = new huffman(input.Text);
                rlcd.ShowDialog();

            }
        }

        private void BtnAdpativeHufMAn_Click(object sender, EventArgs e)
        {

            adabtive_hufman rlcd = new adabtive_hufman();
            rlcd.ShowDialog();

        }

        private void BtnArthiMatic_Click(object sender, EventArgs e)
        {
            if (input.Text == "" || input.EditValue == null)
                MessageBox.Show("Please enter input ");
            else
            {
                arth rlcd = new arth(input.Text);
                rlcd.ShowDialog();
            }
        }
    }
}