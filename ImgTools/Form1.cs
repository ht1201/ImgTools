using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgTools {
    public partial class Form1 : Form {
        public string mSelectPath;//当前选择路径
        public Form1() {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = "准备就绪";
        }
        
        private void button1_Click(object sender, EventArgs e) {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "图片|*.png";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Tools.Export(new List<string>(open.FileNames), "D://output");
            }
            this.toolStripStatusLabel1.Text = "图片压缩完成";
        }

        private void button2_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(this.mSelectPath)) {
                this.toolStripStatusLabel1.Text = "路径不合法";
            } else {
                Tools.ExportFolder(this.mSelectPath, "D://output");
                this.RefershTreeView();
                this.toolStripStatusLabel1.Text = "导出完成";
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(this.mSelectPath)) {
                this.toolStripStatusLabel1.Text = "路径不合法";
            } else {
                Tools.ChangeImgName(new DirectoryInfo(this.mSelectPath));
                this.RefershTreeView();
                this.toolStripStatusLabel1.Text = "重命名操作完成";
            }
        }
        
        private void linkLabel1_Click(object sender, EventArgs e) {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if(fb.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.mSelectPath = fb.SelectedPath;
                this.textBox1.Text = fb.SelectedPath;
                this.RefershTreeView();
                this.toolStripStatusLabel1.Text = "选择路径：" + this.mSelectPath;
            }
        }


        private TreeNode[] GetTree(DirectoryInfo path) {
            List<TreeNode> list = new List<TreeNode>();
            foreach (var item in path.GetDirectories("*", SearchOption.TopDirectoryOnly)) {
                TreeNode node = new TreeNode(item.Name, this.GetTree(item));
                node.ToolTipText = item.FullName;
                node.Tag = null;
                list.Add(node);
            }

            foreach (var item in path.GetFiles("*", SearchOption.TopDirectoryOnly)) {
                TreeNode node = new TreeNode(item.Name);
                node.ToolTipText = item.FullName;
                node.Tag = item.FullName;
                list.Add(node);
            }
            return list.ToArray();
        }

        private void RefershTreeView() {
            this.treeView1.Nodes.Clear();
            this.treeView1.Nodes.AddRange(this.GetTree(new DirectoryInfo(this.mSelectPath)));
            //this.treeView1.ExpandAll();
        }

        private Image mImg;
        private void label1_Paint(object sender, PaintEventArgs e) {
            e.Graphics.Clear(Color.Transparent);
            Pen pen = new Pen(new SolidBrush(Color.Gray));
            e.Graphics.DrawLine(pen, new Point(this.label1.Width >> 1, 0), new Point(this.label1.Width >> 1, this.label1.Height));
            e.Graphics.DrawLine(pen, new Point(0, this.label1.Height >> 1), new Point(this.label1.Width, this.label1.Height >> 1));
            if(this.mImg != null) {
                e.Graphics.DrawImage(this.mImg, (this.label1.Width - this.mImg.Width) >> 1, (this.label1.Height - this.mImg.Height) >> 1);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeNode node = e.Node;
            this.toolStripStatusLabel1.Text = node.ToolTipText;

            if(this.mImg != null) {
                this.mImg.Dispose();
                this.mImg = null;
            }

            if(e.Node.Tag != null && e.Node.ToolTipText.EndsWith(".png")) {
                this.mImg = Bitmap.FromFile(e.Node.ToolTipText);
            }
            this.label1.Refresh();
        }
    }
}
