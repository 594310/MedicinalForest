using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;

namespace WindowsFormsAppmiddle
{
    public partial class bag : Form
    {
        int a,c;
        int b=0;
        int d=1;
        string list;
        int selIndex;

        public bag()
        {
            InitializeComponent();
        }
        


        private void bag_Load(object sender, EventArgs e)
        {
           
                foreach (ArrayList buy in GlobalVar.list背包)
                {

                    string name = (string)buy[0];
                    string bag = (string)buy[1];

                    list = "擁有者:" + name + "                    持有物" + bag;
                    LBbag.Items.Add(list); 
                if (LBbag.Items.Count>0)
                {

                    for (int i = 2; i < buy.Count - 1; i += 3)
                    {

                        string item = (string)buy[i];
                        int num = (int)buy[i + 1];
                        int price = (int)buy[i + 2];
                        if (buy[i] != "" && (int)buy[i + 1] >= 0)
                        {

                            list = "                                  " + item + "     " + num + "個";
                            LBbag.Items.Add(list);
                        }

                    }



                    int a = buy.Count;
                    int money = (int)buy[a-1];
                    list = "                                                                                            $:"+money.ToString()+"j";
                    LBbag.Items.Add(list);   
                    

                }
                

                countlast();
                
            }

            

        } 
        private void LBbag_SelectedIndexChanged(object sender, EventArgs e)
        {

            countlast();
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            
            if(LBbag.SelectedIndex>-1)
            {
                int selIndex = LBbag.SelectedIndex;

                

                foreach (ArrayList buy in GlobalVar.list背包)
                {

                        c=buy.Count;
                      
                        string name = (string)buy[0];
                        string bag = (string)buy[1];

                        
                    if (b-selIndex/d!=1|| b !=selIndex/d)
                    {
                        int money = 0;
                        
                        for (int i = 2; i < buy.Count - 1; i += 3)
                        {

                            string item = (string)buy[i].ToString();
                            int num = (int)buy[i + 1];
                            int price= (int)buy[i + 2];

                            if (selIndex*3-1==i||selIndex*3==i||selIndex*3+1==i)
                            {

                                money = (int)buy[i + 1] * (int)buy[i + 2];

                                buy.RemoveAt(selIndex * 3 - 1);
                                buy.RemoveAt(selIndex * 3 - 1);
                                buy.RemoveAt(selIndex * 3 - 1);
                           
                            }

                        }
                        money =(int)buy[buy.Count - 1]- money;
                        list = "                                                                                             $:" + money.ToString() + "j";
                        LBbag.Items.Add(list);
                        LBbag.Items.RemoveAt((buy.Count - 3)/2+2);
                        LBbag.Items.RemoveAt(selIndex);
                        
                    }
                      
                  
                    else if(b - selIndex / d == 1 || b == selIndex / d)
                    {
                        MessageBox.Show("請選擇丟棄道具");
                    }   

                    /*else if(b < 2)
                    {
                        
                    }*/


                    for (int i = 0; i < d; i++)
                    {
                     b += (c - 3) / 3 + 2;
                    }
                
                     d++;
                    
                    Console.WriteLine(d);

                }

                
                countlast();

            }

            else
            {
                MessageBox.Show("請選擇丟棄道具");
            }
        
        
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            LBbag.Items.Clear();
            GlobalVar.list背包.Clear();
            countlast();

        }

        void countlast()
        {


           /* if (LBbag.SelectedIndex > -1)
            {
                int selIndex = LBbag.SelectedIndex;



                LBbag.Items.RemoveAt(selIndex);
                foreach (ArrayList buy in GlobalVar.list背包)
                {



                    for (int i = selIndex ; i < buy.Count - 1; i += 3)
                    {

                        buy.RemoveAt(selIndex );
                        buy.RemoveAt(selIndex + 1);
                        buy.RemoveAt(selIndex + 2);
                        if (buy[selIndex+1]=="")
                        {
                            MessageBox.Show(buy[LBbag.SelectedIndex].ToString());
                        }
                        break;
                    }
                    MessageBox.Show(buy[LBbag.SelectedIndex].ToString());


                }
                
            }*/
            


            int Last = GlobalVar.餘額[GlobalVar.Nom]; 
            lbl餘額.Text = String.Format("餘額:{0}",Last);


        }



        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
