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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
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
                node.Tag = item.FullName;
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
            this.treeView1.ExpandAll();
        }
    }
}
