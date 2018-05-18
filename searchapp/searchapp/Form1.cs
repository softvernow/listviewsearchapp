using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace searchapp
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_List_View();
        }


        private void Load_List_View()
        {
            string[] strItemcoll3 = { "John", "Doe", "30" };
            var listViewItem = new ListViewItem(strItemcoll3);
            listView1.Items.Add(listViewItem);

            string[] strItemcoll4 = { "Eric", "Nay", "45" };
            var listViewIte4 = new ListViewItem(strItemcoll4);
            listView1.Items.Add(listViewIte4);

            string[] strItemcoll5 = { "Brandon", "goit", "15" };
            var listViewItem5 = new ListViewItem(strItemcoll5);
            listView1.Items.Add(listViewItem5);

            string[] strItemcoll6 = { "Ramon", "Askjh", "96" };
            var listViewItem6 = new ListViewItem(strItemcoll6);
            listView1.Items.Add(listViewItem6);

            string[] strItemcoll7 = { "Guilherme", "bras", "66" };
            var listViewItem7 = new ListViewItem(strItemcoll7);
            listView1.Items.Add(listViewItem7);

            string[] strItemcoll8 = { "Daimian", "smith", "12" };
            var listViewItem8 = new ListViewItem(strItemcoll8);
            listView1.Items.Add(listViewItem8);
        }


        //index of last search. 
        private int index_search = 0;

        private void btnFind_Click(object sender, EventArgs e)
        {
            //skips if there is no items on listview
            if (listView1.Items.Count == 0)
                return;

            //if indext of last seach equals last item on listview, there are no more items. 
            if (index_search == listView1.Items.Count)
            {
                MessageBox.Show("No More Items Found!");
                index_search = 0;
            }

            //search function that will search listview. 
            ListViewItem foundItem =
                listView1.FindItemWithText(txtNewSearch.Text, true, index_search, true);
            if (foundItem != null)
            {
                //used to scrow to found item. 
                listView1.TopItem = foundItem;
                foundItem.Selected = true;
                listView1.Select();
                index_search = foundItem.Index + 1;

            }
            else
            {
                //no items found messages. 
                if (index_search.Equals(0))
                    MessageBox.Show("Items Not Found");
                else
                    MessageBox.Show("No More Items Found!");

                //reset index search to start from top of the list. 
                index_search = 0;
            }
        }
    }
}
