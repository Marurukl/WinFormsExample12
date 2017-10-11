using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public int i=0;
        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(topLevelMenu.Text))
            {
                ToolStripMenuItem _toolStrip = new ToolStripMenuItem(topLevelMenu.Text);
            }
        }

        private void AddSubitem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(subItem.Text))
            {
                ToolStripMenuItem _toolStrip2=new ToolStripMenuItem(topLevelMenu.Text);
                _toolStrip2.DropDownItems.Add(new ToolStripMenuItem(subItem.Text));
            }
        }
    }
}
