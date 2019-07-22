using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formBir
{
    public partial class Form1 : Form
    {
        List<string> grupList;
        public Form1()
        {
            grupList = new List<string>();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string grupname = listBox.Text;
            if (grupname.Length != 0)
            {
                grupList.Add(grupname);
                grupBox.Items.Clear();
                foreach (var grp in grupList) 
                {
                    grupBox.Items.Add(grp);
                }
            }
            else
            {
                label5.Visible = true;
            }


        }
    }
}
