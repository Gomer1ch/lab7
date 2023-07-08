using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Семестр_2_Лаба_2_Market
{
    public partial class Form1 : Form
    {
        string Name;
        int index;
        double sum = 0.0;
        double price = 0.0;
        public Form1()
        {
            InitializeComponent();

            //treeView1.ImageList = imageList1;
            //listView1.SmallImageList = imageList1;
            //TreeNode gpuNode = new TreeNode { Text = "GPU", ImageIndex = 0, SelectedImageIndex = 0 };
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection breakfast = this.listView1.SelectedItems;
            foreach (ListViewItem item in breakfast)
            {
                label3.Text = "Выбранный товар: " + item.Text;
                Name = "" + item.Text;
            }
            if (listView1.SelectedItems.Count > 0)  //Получение индекса выбранного элемента
            {
                for (int lcount = 0; lcount <= listView1.Items.Count - 1; lcount++)
                {
                    if (listView1.Items[lcount].Selected == true)
                    {
                        label1.Text = "" + lcount;
                        index = lcount;
                        break;
                    }
                } 
            } 
            //Получение цены для каждого товара
            foreach (ListViewItem item in breakfast)
            {
                price = Double.Parse(item.SubItems[1].Text);
            }
            label2.Text = "Цена выбранного товара: " + price.ToString();
            pictureBox1.Image = imageList1.Images[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { Name + " - " + price, });
            lvi.SubItems.Add("" + price);
            listView2.Items.Add(lvi);
            sum += price;
            price = 0;
            label4.Text = "Сумма = " + sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView2.SelectedItems)
            {
                listView2.Items.Remove(eachItem);
            }
            sum -= price; 
            price = 0;
            label4.Text = "Сумма = " + sum;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection breakfast2 = this.listView2.SelectedItems;
            foreach (ListViewItem item in breakfast2)
            {
                price = Double.Parse(item.SubItems[1].Text);
            }
            label5.Text = price.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if(treeView1.SelectedNode.Checked == true) { label6.Text = "Profit"; }
            //foreach (TreeNode myNode in e.Node.Name)
            //{
            //    // Check whether the tree node is checked.
            //    if (myNode.Checked)
            //    {
            //        label6.Text = "Profit";
            //    }
            //}
            //TreeNode myNode in 
            //TreeNode myNode = ];
            //if (treeView1.Nodes[0].Checked)
            //{
            //    listView1.Groups[0].
            //    label6.Text = "Profit";
            //}

        }
    }
}
