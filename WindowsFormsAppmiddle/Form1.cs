using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppmiddle
{
    public partial class Form1 : Form
    {
        List<string> listItem = new List<string>();
        List<int> listprice = new List<int>();
        List<int> listnumber = new List<int>();
        List<string> listTempItem = new List<string>();
        List<int> listTempPrice = new List<int>();
        List<string> chooseitems=new List<string>();

        

        int total;
        int price;
        int choosenum;
        string ChooseItem;
        int a;
        int discount=0;
        string strItemAndPrice;
        string bag = "";


        public Form1()
        {
           InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            GlobalVar.餘額.Add(10000);
            GlobalVar.Nom=0;
            listItem.Add("生命藥水     ");
            listItem.Add("魔力藥水     ");
            listItem.Add("幸運藥水     ");
            listItem.Add("封魔藥水     ");
            listItem.Add("復活藥水     ");
            listItem.Add("經驗藥水     ");
            listItem.Add("體力藥劑     ");
            listItem.Add("智慧藥劑     ");
            listItem.Add("敏捷藥劑     ");
            listItem.Add("力量藥劑     ");
            listItem.Add("祝福藥劑     ");
            listItem.Add("火焰藥劑     ");
            listItem.Add("冰霜藥劑     ");
            listItem.Add("解毒藥劑     ");
            listItem.Add("煉金藥劑     ");
            listItem.Add("煉金術.基本篇");
            listItem.Add("煉金術.進階篇");
            listItem.Add("煉金術.終極篇");
            listItem.Add("藥水瓶       ");
            listItem.Add("煉金鍋       ");


            listprice.Add(200  );
            listprice.Add(350);
            listprice.Add(400);
            listprice.Add(400);
            listprice.Add(500);
            listprice.Add(1000);
            listprice.Add(2000);
            listprice.Add(2000);
            listprice.Add(2000);
            listprice.Add(2000);
            listprice.Add(3000);
            listprice.Add(1000);
            listprice.Add(1000);
            listprice.Add(1000);
            listprice.Add(500);
            listprice.Add(500);
            listprice.Add(2000);
            listprice.Add(10000);
            listprice.Add(100);
            listprice.Add(1000);

            listnumber.Add(0);
            listnumber.Add(1);
            listnumber.Add(2);
            listnumber.Add(3);
            listnumber.Add(4);
            listnumber.Add(5);
            listnumber.Add(6);
            listnumber.Add(7);
            listnumber.Add(8);
            listnumber.Add(9);
            listnumber.Add(10);
            listnumber.Add(11);
            listnumber.Add(12);
            listnumber.Add(13);
            listnumber.Add(14);
            listnumber.Add(15);

            for (int i = 0; i < listItem.Count; i++)
            {
                GlobalVar.choosenum.Add(0);
            }

            for (int i = 0; i < listItem.Count; i++)
            {
                GlobalVar.價錢.Add(0);
            }

            for (int i = 0; i < listItem.Count; i++)
            {
                GlobalVar.chooseitems.Add("");
            }




            lbllast.Text = ("餘額:" + GlobalVar.餘額[GlobalVar.Nom].ToString()+"j");

           
            for (int i = 0; i < listItem.Count; i++)
            {
                if (listprice[i] <999)
                {
                    strItemAndPrice = listItem[i] + "----   " + listprice[i] + "j    " + GlobalVar.choosenum[i];
                    LB1.Items.Add(strItemAndPrice);
                }
                else if(listprice[i] <9999)
                {
                    strItemAndPrice = listItem[i] + "----  " + listprice[i] + "j    " + GlobalVar.choosenum[i];
                    LB1.Items.Add(strItemAndPrice);
                }
                else
                {
                    strItemAndPrice = listItem[i] + "---- " + listprice[i] + "j    " + GlobalVar.choosenum[i];
                    LB1.Items.Add(strItemAndPrice);
                }

            }
            foreach (int item in listnumber)
            {
                CBnum.Items.Add(item);
            }
            MessageBox.Show("請選購商品，並留下6碼ID");
            RBNO.Checked = true;
            
            

        }


        void counttotal()
        {
            if (CBnum.SelectedIndex != -1&&LB1.SelectedIndex!=-1&& (RBYes.Checked == true || RBNO.Checked == true))
            {
             
                    total = GlobalVar.choosenum[0] * GlobalVar.價錢[0] + GlobalVar.choosenum[1] * GlobalVar.價錢[1] + GlobalVar.choosenum[2] * GlobalVar.價錢[2] + GlobalVar.choosenum[3] * GlobalVar.價錢[3] + GlobalVar.choosenum[4] * GlobalVar.價錢[4] + GlobalVar.choosenum[5] * GlobalVar.價錢[5] + GlobalVar.choosenum[6] * GlobalVar.價錢[6] + GlobalVar.choosenum[7] * GlobalVar.價錢[7] + GlobalVar.choosenum[8] * GlobalVar.價錢[8] + GlobalVar.choosenum[9] * GlobalVar.價錢[9] + GlobalVar.choosenum[10] * GlobalVar.價錢[10] + GlobalVar.choosenum[11] * GlobalVar.價錢[11] + GlobalVar.choosenum[12] * GlobalVar.價錢[12] + GlobalVar.choosenum[13] * GlobalVar.價錢[13] + GlobalVar.choosenum[14] * GlobalVar.價錢[14] + GlobalVar.choosenum[15] * GlobalVar.價錢[15] + GlobalVar.choosenum[16] * GlobalVar.價錢[16] + GlobalVar.choosenum[17] * GlobalVar.價錢[17] + GlobalVar.choosenum[18] * GlobalVar.價錢[18] + GlobalVar.choosenum[19] * GlobalVar.價錢[19];



             
                    if (RBYes.Checked == true)
                    {
                        if (discount == 1)
                        {
                            total /= 2;
                        }
                        total += 500;
                        lbltotal.Text = String.Format("$:{0}j", total);
                    }
                    else
                    {
                        if (discount == 1)
                        {
                            total /= 2;
                        }
                        lbltotal.Text = String.Format("$:{0}j", total);
                    }
                /*string name = txtname.Text;
                GlobalVar.name.Add(name);


                for (int i = 0; i < GlobalVar.NO.Count; i++)
                {
                    if (GlobalVar.name[i].Equals(name))
                    {
                        GlobalVar.Nom = GlobalVar.NO[i];
                    }


                }*/


            }
        }


        private void btnsearch_Click(object sender, EventArgs e)
        {


            if (txtsearch.Text.Length > 0)
            {
                int index;
               
                string strSearchName = txtsearch.Text;

                


                index = LB1.FindString(strSearchName,a);

                if (index != -1)
                {
                    
                    LB1.SelectedIndex = index;
                    a = index;
                  
                }
                else
                {
                    MessageBox.Show("無此商品");
                }

            }
        
        }

        private void btninto_Click(object sender, EventArgs e)
        {
            int totalprice=0;
            if (total>0)
            {

                if (GlobalVar.餘額[GlobalVar.Nom] >= total)
                {
                    if (txtname.Text.Length ==6)
                    {
                        counttotal();

                        ArrayList buy = new ArrayList(); 
                        string name = txtname.Text;
                       // GlobalVar.name.Add(name);
                        buy.Add(name);

                        if (RBYes.Checked == true)
                        {
                            string bag = "";
                            bag += "                           ----擴充背包";
                            buy.Add(bag);

                        }
                        else
                        {
                            buy.Add(bag);
                        }

                            for (int i = 0; i < listItem.Count; i++)
                            {

                                if (GlobalVar.chooseitems[i] != "")
                                {
                                    buy.Add(GlobalVar.chooseitems[i]);
                                    buy.Add(GlobalVar.choosenum[i]);
                                    buy.Add(GlobalVar.價錢[i]);
                                }

                            }

                        buy.Add(total);




                        GlobalVar.list背包.Add(buy);
                            MessageBox.Show("已成功購入");
                            buy = new ArrayList();
                            GlobalVar.餘額.Add(GlobalVar.餘額[GlobalVar.Nom] - total);
                            GlobalVar.Nom++;
                            GlobalVar.NO.Add(GlobalVar.Nom);
                            lbllast.Text = ("餘額:" + GlobalVar.餘額[GlobalVar.Nom].ToString() + "j");


                            lbltotal.Text = "";
                            txtname.Text = "";

                            GlobalVar.choosenum.Clear();
                            GlobalVar.價錢.Clear();
                            GlobalVar.chooseitems.Clear();
                            //GlobalVar.buy.Clear();

                            for (int i = 0; i < listItem.Count; i++)
                            {
                                GlobalVar.choosenum.Add(0);

                            }

                            for (int i = 0; i < listItem.Count; i++)
                            {
                                GlobalVar.價錢.Add(0);
                            }
                            for (int i = 0; i < listItem.Count; i++)
                            {
                                GlobalVar.chooseitems.Add("");
                            }






                            for (int i = 0; i < listItem.Count; i++)
                            {
                                if (listprice[i] < 999)
                                {
                                    strItemAndPrice = listItem[i] + "----   " + listprice[i] + "j    " + GlobalVar.choosenum[i];
                                    LB1.Items[i] = strItemAndPrice;
                                }
                                else if (listprice[i] < 9999)
                                {
                                    strItemAndPrice = listItem[i] + "----  " + listprice[i] + "j    " + GlobalVar.choosenum[i];
                                    LB1.Items[i] = strItemAndPrice;
                                }
                                else
                                {
                                    strItemAndPrice = listItem[i] + "---- " + listprice[i] + "j    " + GlobalVar.choosenum[i];
                                    LB1.Items[i] = strItemAndPrice;
                                }

                            }
                        
                     }
                    else
                    {
                        MessageBox.Show("請輸入6碼ID");
                    }

                }
                else
                {
                    MessageBox.Show("請先儲值");
                }

            }
            else
            {
                MessageBox.Show("請重新選購商品，並留下玩家ID");
            }
           
            


        }

        private void btnsearchbag_Click(object sender, EventArgs e)
        {
            bag item= new bag();
            item.ShowDialog();
        }

        private void CBnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBnum.SelectedIndex!=-1&& LB1.SelectedIndex!=-1)
              {
                
                GlobalVar.choosenum.Insert(LB1.SelectedIndex,listnumber[CBnum.SelectedIndex]);
                GlobalVar.choosenum.RemoveAt(LB1.SelectedIndex+1);


                if (price < 999)
                {
                    strItemAndPrice = ChooseItem + "----   " + price + "j    " + GlobalVar.choosenum[LB1.SelectedIndex];
                    LB1.Items[LB1.SelectedIndex] = strItemAndPrice;
                }
                else if (price < 9999)
                {
                    strItemAndPrice = ChooseItem + "----  " + price + "j    " + GlobalVar.choosenum[LB1.SelectedIndex];
                    LB1.Items[LB1.SelectedIndex] = strItemAndPrice;
                }
                else
                {
                    strItemAndPrice = ChooseItem + "---- " + price + "j    " + GlobalVar.choosenum[LB1.SelectedIndex];
                    LB1.Items[LB1.SelectedIndex] = strItemAndPrice;
                }
                if (CBnum.SelectedIndex > 0)
                {
                    GlobalVar.chooseitems.Add(listItem[LB1.SelectedIndex]);

                }
                counttotal();

            }

        }

        private void LB1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


             if (LB1.SelectedIndex!=-1)
             {
                
                price = listprice[LB1.SelectedIndex];
                ChooseItem = listItem[LB1.SelectedIndex];
                

            
                GlobalVar.價錢.Insert(LB1.SelectedIndex, listprice[LB1.SelectedIndex]);
                GlobalVar.價錢.RemoveAt(LB1.SelectedIndex + 1);
                counttotal();
                CBnum.SelectedIndex = GlobalVar.choosenum[LB1.SelectedIndex];        
                
               
                

                if (CBnum.SelectedIndex >0)
                {
                    GlobalVar.chooseitems.Insert(LB1.SelectedIndex,listItem[LB1.SelectedIndex]);
                    GlobalVar.chooseitems.RemoveAt(LB1.SelectedIndex + 1); 
                     
                    counttotal();
                }
             
            }
        }

        private void btncharge_Click(object sender, EventArgs e)
        {
            charge money = new charge();
            money.ShowDialog(this);
        }

        private void RBYes_CheckedChanged(object sender, EventArgs e)
        {
            if (RBYes.Checked == true)
            {
                MessageBox.Show("擴充背包為500j");
                counttotal();
            }
        }

        private void RBNO_CheckedChanged(object sender, EventArgs e)
        {
            counttotal();
        }

        private void lbldiscount_Click(object sender, EventArgs e)
        {
            if (discount ==0)
            {
                discount += 1;
                MessageBox.Show("恭喜您獲得隱藏折扣--全品項5折一次");
                counttotal();
            }
        }


    }
}
