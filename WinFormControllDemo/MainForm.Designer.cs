
namespace WinFormControllDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowTreeViewDemoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowTreeViewDemoButton
            // 
            this.ShowTreeViewDemoButton.Location = new System.Drawing.Point(12, 12);
            this.ShowTreeViewDemoButton.Name = "ShowTreeViewDemoButton";
            this.ShowTreeViewDemoButton.Size = new System.Drawing.Size(75, 23);
            this.ShowTreeViewDemoButton.TabIndex = 0;
            this.ShowTreeViewDemoButton.Text = "TreeView";
            this.ShowTreeViewDemoButton.UseVisualStyleBackColor = true;
            this.ShowTreeViewDemoButton.Click += new System.EventHandler(this.ShowTreeViewDemoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowTreeViewDemoButton);
            this.Name = "MainForm";
            this.Text = "Windows Form Control Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowTreeViewDemoButton;
    }
}

