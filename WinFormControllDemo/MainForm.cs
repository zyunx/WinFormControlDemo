using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormControllDemo.ControlDemoForms;

namespace WinFormControllDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowTreeViewDemoButton_Click(object sender, EventArgs e)
        {
            new TreeViewDemoForm().ShowDialog();
        }
    }
}
