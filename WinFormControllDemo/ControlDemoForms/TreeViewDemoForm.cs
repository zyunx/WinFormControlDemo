using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControllDemo.ControlDemoForms
{
    public partial class TreeViewDemoForm : Form
    {
        public TreeViewDemoForm()
        {
            InitializeComponent();
        }

        private void ShowCheckedButton_Click(object sender, EventArgs e)
        {
            List<TreeNode> checkedNodes = GetCheckedNodes(TreeViewDemo);

            StringBuilder sb = new StringBuilder();
            foreach (TreeNode n in checkedNodes)
            {
                sb.Append(n.Text + ",");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            MessageBox.Show(sb.ToString());
        }

        private void CollectCheckedNodesRecursive(TreeNode treeNode, List<TreeNode> checkedNodes)
        {
            if (treeNode.Checked)
            {
                checkedNodes.Add(treeNode);
            }

            foreach (TreeNode tn in treeNode.Nodes)
            {
                if (tn.Checked)
                {
                    checkedNodes.Add(tn);
                }
            }
        }

        private List<TreeNode> GetCheckedNodes(TreeView treeView)
        {
            var checkedNodes = new List<TreeNode>();

            foreach (TreeNode n in treeView.Nodes)
            {
                CollectCheckedNodesRecursive(n, checkedNodes);
            }

            return checkedNodes;
        }
    }
}
