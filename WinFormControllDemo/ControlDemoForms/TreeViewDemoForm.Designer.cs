
namespace WinFormControllDemo.ControlDemoForms
{
    partial class TreeViewDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node6");
            this.TreeViewDemo = new System.Windows.Forms.TreeView();
            this.ShowCheckedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreeViewDemo
            // 
            this.TreeViewDemo.CheckBoxes = true;
            this.TreeViewDemo.Cursor = System.Windows.Forms.Cursors.Default;
            this.TreeViewDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewDemo.Location = new System.Drawing.Point(0, 0);
            this.TreeViewDemo.Name = "TreeViewDemo";
            treeNode1.Name = "Node7";
            treeNode1.Text = "Node7";
            treeNode2.Name = "Node8";
            treeNode2.Text = "Node8";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Node9";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            treeNode6.Name = "Node10";
            treeNode6.Text = "Node10";
            treeNode7.Name = "Node11";
            treeNode7.Text = "Node11";
            treeNode8.Name = "Node12";
            treeNode8.Text = "Node12";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Node2";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            treeNode11.Name = "Node13";
            treeNode11.Text = "Node13";
            treeNode12.Name = "Node14";
            treeNode12.Text = "Node14";
            treeNode13.Name = "Node4";
            treeNode13.Text = "Node4";
            treeNode14.Name = "Node5";
            treeNode14.Text = "Node5";
            treeNode15.Name = "Node6";
            treeNode15.Text = "Node6";
            this.TreeViewDemo.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode9,
            treeNode10,
            treeNode13,
            treeNode14,
            treeNode15});
            this.TreeViewDemo.Size = new System.Drawing.Size(357, 549);
            this.TreeViewDemo.TabIndex = 0;
            // 
            // ShowCheckedButton
            // 
            this.ShowCheckedButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowCheckedButton.Location = new System.Drawing.Point(0, 526);
            this.ShowCheckedButton.Name = "ShowCheckedButton";
            this.ShowCheckedButton.Size = new System.Drawing.Size(357, 23);
            this.ShowCheckedButton.TabIndex = 1;
            this.ShowCheckedButton.Text = "Get Checked";
            this.ShowCheckedButton.UseVisualStyleBackColor = true;
            this.ShowCheckedButton.Click += new System.EventHandler(this.ShowCheckedButton_Click);
            // 
            // TreeViewDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 549);
            this.Controls.Add(this.ShowCheckedButton);
            this.Controls.Add(this.TreeViewDemo);
            this.Name = "TreeViewDemoForm";
            this.Text = "TreeViewDemoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewDemo;
        private System.Windows.Forms.Button ShowCheckedButton;
    }
}