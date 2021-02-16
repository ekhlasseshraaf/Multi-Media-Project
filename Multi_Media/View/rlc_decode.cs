using System;
using System.Windows.Forms;


namespace Multi_Media.View
{

    public partial class rlc_decode : DevExpress.XtraEditors.XtraForm
    {


        public rlc_decode(string input)
        {
            InitializeComponent();
            inc.Text = input;
            rlc_dec();
        }

        private void inc_TextChanged(object sender, EventArgs e)
        {
            label2.Text = inc.Text.Length.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text.Length.ToString();
        }
        private void rlc_dec()
        {
            try
            {

                String code = inc.Text;
                String Solution = "";
                for (int i = 0; i < code.Length; i += 2)
                {
                    int num = int.Parse(code[i].ToString());
                    char sympol = code[i + 1];
                    for (int j = 0; j < num; j++)
                    {
                        Solution += sympol;
                    }
                }
                textBox2.Text = Solution;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message.ToString());
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rlc_decode_Load(object sender, EventArgs e)
        {

        }

    }
}