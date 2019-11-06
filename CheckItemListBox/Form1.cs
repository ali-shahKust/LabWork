using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckItemListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            myList.Items.Add("BS-CS" , CheckState.Checked);
            myList.Items.Add("BS-SE", CheckState.Indeterminate);
            myList.Items.Add("MCS", CheckState.Unchecked);
            myList.Items.Add("MS", CheckState.Unchecked);
            myList.Items.Add("PHD", CheckState.Unchecked);
        }

        private void ProsPecBtn_Click(object sender, EventArgs e)
        {
            int price=0;
            int i , p1 = 0, p2 = 0 , p3 = 0, p4 = 0 , p5 = 0;
            String s = "Checked Programs \n";
            for (i = 0; i <= (myList.Items.Count - 1); i++)
            {

                if (myList.GetItemChecked(i))
                {
                    if (i == 0)
                    {
                        p1 = 10;
                        price = price + p1 + p2 + p3 + p4;
                    } 
                    if(i== 1)
                    {
                        p2 = 20;
                        price = price + p1 + p2 + p3 + p4;
                    }

                    if (i == 2)
                    {
                        p2 = 30;
                        price = price + p1 + p2+p3+p4;
                    }
                    if (i == 3)
                    {
                        p2 = 50;
                        price = price + p1 + p2 + p3 + p4;
                    }
                    if (i == 4)
                    {
                        p2 = 100;
                        price = price + p1 + p2 + p3 + p4;
                    }



                }
            }
            MessageBox.Show("Total Price For Prospectus is " + price);
        }
    }
}
