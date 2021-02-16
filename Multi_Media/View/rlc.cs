using System;
using System.Windows.Forms;


namespace Multi_Media.View
{

    public partial class rlc : DevExpress.XtraEditors.XtraForm
    {


        // Events & Functions
        public rlc(string input)
        {
            InitializeComponent();
            inc.Text = input;
            rlc_inc();
        }
      
  

      
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inc_TextChanged(object sender, EventArgs e)
        {
            label2.Text = inc.Text.Length.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text.Length.ToString();
        }
        public void rlc_inc()
        {
            try
            {
                if (inc.Text == "")
                {
                    return;
                }
                String Solution = "";
                String code = inc.Text;
                char sesc = code[0];
                int count = 1;
                for (int i = 1; i < code.Length; i++)
                {
                    if (code[i] == sesc)
                    {
                        count++;
                        if (count > 9)
                        {
                            count = 9;
                        }
                    }
                    else
                    {
                        Solution += count.ToString() + sesc;
                        sesc = code[i];
                        count = 1;
                    }
                }
                Solution += count.ToString() + sesc;
                textBox2.Text = Solution;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message.ToString());
            }
        }



    }
}