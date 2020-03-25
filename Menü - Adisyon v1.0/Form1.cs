using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menü___Adisyon_v1._0
{
    public partial class Form1 : Form
    {
        int d = 0;
        int c = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d++;

            if (d == 1)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++) // seçilen itemlerin indexsini sayiyor.
                {
                    listBox1.Items.Add(checkedListBox1.CheckedItems[i]); // seçilen kadar ekliyor.
                }
            }


            else
            {
                {
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++) // seçilen itemlerin indexsini sayiyor.
                    {
                        c = 0;
                        for (int j = 0; j < listBox1.Items.Count; j++)
                        {
                            if (checkedListBox1.CheckedItems[i].ToString() == listBox1.Items[j].ToString())
                            {
                                c++;
                                break;
                            }
                        }

                        if (c == 0)
                        {
                            listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
        }
    }
}
