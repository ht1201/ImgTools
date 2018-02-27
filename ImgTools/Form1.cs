using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgTools {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "图片|*.png";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Tools.Export(new List<string>(open.FileNames), "D://output");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Tools.ExportFolder(fb.SelectedPath, "D://output");
                MessageBox.Show("完成");
            }
        }
    }
}
