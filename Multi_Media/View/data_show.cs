using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Multi_Media.View
{

    public partial class data_show : DevExpress.XtraEditors.XtraForm
    {
        List<List<String>> mylist = new List<List<string>>();


        // Events & Functions
        public data_show(List<List<String>> mylist)
        {
            this.mylist = mylist;
            InitializeComponent();
        }



        private void data_show_Load(object sender, EventArgs e)
        {
            try
            {


                dataGridView1.RowCount = mylist.Count;
                dataGridView1.ColumnCount = mylist[0].Count;

                for (int i = 0; i < mylist[0].Count; i++)
                {
                    dataGridView1.Columns[i].HeaderText = mylist[0][i];
                }

                for (int i = 0; i < mylist.Count; i++)
                {

                    for (int j = 0; j < mylist[0].Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = mylist[i][j];
                    }
                }
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



    }
}