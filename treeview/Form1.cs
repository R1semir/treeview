using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode not = new TreeNode("Linux");
            treeView1.Nodes.Add(not);

            not = new TreeNode("Windows");
            treeView1.Nodes.Add(not);

            TreeNode cocuk1 = new TreeNode("C#");
            TreeNode cocuk2 = new TreeNode("C visual basic");
            TreeNode cocuk3 = new TreeNode("Asp.Net");

            TreeNode[] array = new TreeNode[] { cocuk1, cocuk2, cocuk3 };
            not = new TreeNode("Programlara dilleri", array);
            treeView1.Nodes.Add(not);
        }
    }
}
