namespace ImgTools {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图片文件处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件夹处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件改名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(233, 459);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "选择路径";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(71, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(550, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择路径ToolStripMenuItem,
            this.图片文件处理ToolStripMenuItem,
            this.文件夹处理ToolStripMenuItem,
            this.文件改名ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // 图片文件处理ToolStripMenuItem
            // 
            this.图片文件处理ToolStripMenuItem.Name = "图片文件处理ToolStripMenuItem";
            this.图片文件处理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图片文件处理ToolStripMenuItem.Text = "图片文件处理";
            this.图片文件处理ToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // 文件夹处理ToolStripMenuItem
            // 
            this.文件夹处理ToolStripMenuItem.Name = "文件夹处理ToolStripMenuItem";
            this.文件夹处理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.文件夹处理ToolStripMenuItem.Text = "文件夹处理";
            this.文件夹处理ToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // 文件改名ToolStripMenuItem
            // 
            this.文件改名ToolStripMenuItem.Name = "文件改名ToolStripMenuItem";
            this.文件改名ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.文件改名ToolStripMenuItem.Text = "文件改名";
            this.文件改名ToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // 选择路径ToolStripMenuItem
            // 
            this.选择路径ToolStripMenuItem.Name = "选择路径ToolStripMenuItem";
            this.选择路径ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.选择路径ToolStripMenuItem.Text = "选择路径";
            this.选择路径ToolStripMenuItem.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(251, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 459);
            this.label1.TabIndex = 8;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.treeView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图片文件处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件夹处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件改名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择路径ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

