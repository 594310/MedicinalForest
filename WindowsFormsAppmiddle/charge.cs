using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppmiddle
{
    public partial class charge : Form
    {
        

        public charge()
        {
            InitializeComponent();

        }

        private void charge_Load(object sender, EventArgs e)
        {
           
           
            lbllast.Text = "餘額:" + GlobalVar.餘額[GlobalVar.Nom ] + "j";
          
        }

        private void btncharge_Click(object sender, EventArgs e)
        {
            if (txtmoney.TextLength > 0)
            {
                GlobalVar.餘額[GlobalVar.Nom] = GlobalVar.餘額[GlobalVar.Nom] + Convert.ToInt32(txtmoney.Text);

                if (GlobalVar.餘額[GlobalVar.Nom] < 100000000)
                {
                    

                    lbllast.Text = "餘額:" + GlobalVar.餘額[GlobalVar.Nom] + "j";
                    MessageBox.Show("已儲值完成");
                    txtmoney.Text = "";
                    Form1 form1 = (Form1)this.Owner;
                    form1.Controls["lbllast"].Text = "餘額:" + GlobalVar.餘額[GlobalVar.Nom] + "j";
                }
                else
                {
                    MessageBox.Show("請自重");
                    txtmoney.Text = "";
                }

            }
            else
            {
                MessageBox.Show("您未輸入金額");
            }
        }
    }
}
