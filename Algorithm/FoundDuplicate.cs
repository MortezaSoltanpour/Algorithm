using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm
{
    public partial class FoundDuplicate : Form
    {
        public FoundDuplicate()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnFound_Click(object sender, EventArgs e)
        {
            int itemFound = 0;
            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                for (int j = i + 1; j < listBox1.Items.Count; j++)
                {
                    string firstItem = listBox1.Items[i].ToString();
                    string secondItem = listBox1.Items[j].ToString();
                    if (firstItem == ReverseString(secondItem))
                        itemFound++;
                }
            }

            lblResult.Text = $"{itemFound} item(s) found";
        }


        string ReverseString(string item)
        {
            string[] aa = new string[item.Length];

            string result = "";

            for (int i = 0; i < item.Length / 2; i++)
            {
                string temp = item[i].ToString();
                aa[i] = item[item.Length-1 - i].ToString();
                aa[item.Length - 1] = temp;
            }
            if (item.Length % 2 == 1)
            {
                aa[item.Length / 2 ] = item[item.Length / 2 ].ToString();
            }
            foreach (var z in aa)
                result += z;
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }
    }
}
