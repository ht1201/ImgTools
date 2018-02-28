using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImgTools {
    public class Tools {
        public static void Export(List<string> path_list, string output) {
            if (path_list.Count == 0) {
                return;
            }
            path_list.Sort();
            List<Image> list = new List<Image>();
            foreach (var item in path_list) {
                list.Add(Bitmap.FromFile(item));
            }

            int width = 0;
            int height = 0;
            foreach (var item in list){
                width = Math.Max(width,item.Width);
                height = Math.Max(height,item.Height);
            }
            int x_min = width;
            int y_min = height;
            int x_max = 0;
            int y_max = 0;
            using (Bitmap bmp = new Bitmap(width, height)) {
                using (Graphics graphics = Graphics.FromImage(bmp)) {
                    graphics.Clear(Color.Transparent);
                    foreach (var img in list) {
                        graphics.DrawImage(img, (width - img.Width) >> 1, (height - img.Height) >> 1);
                    }
                    graphics.Flush();

                    var bits = bmp.LockBits(new Rectangle(0,0,width,height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);
                    int len = bits.Stride*bits.Height;
                    byte[] bytes = new byte[len];
                    Marshal.Copy(bits.Scan0,bytes,0,len);
                    for (int i = 0; i < len; i += 4) {
                        if (bytes[i] != 0 || bytes[i + 1] != 0 || bytes[i + 2] != 0 || bytes[i + 3] != 0) {
                            int x = (i % bits.Stride) / 4;
                            int y = i / bits.Stride;

                            x_min = Math.Min(x_min, x);
                            y_min = Math.Min(y_min, y);
                            x_max = Math.Max(x_max, x);
                            y_max = Math.Max(y_max, y);
                        }
                    }
                }
            }

            if ((x_max - x_min) % 2 == 1) {
                x_max++;
            }
            if ((y_max - y_min) % 2 == 1) {
                y_max++;
            }
            DirectoryInfo di = new DirectoryInfo(output);
            if(di.Parent.Exists == false) {
                di.Parent.Create();
            }
            using (Bitmap img = new Bitmap(x_max - x_min, y_max - y_min)) {
                using (Graphics g = Graphics.FromImage(img)) {
                    for (int i = 0; i < list.Count; i++){
                        g.Clear(Color.Transparent);
                        g.DrawImage(list[i], (width - list[i].Width) / 2 - x_min, (height - list[i].Height) / 2 - y_min);
                        g.Flush();
                        img.Save(System.IO.Path.Combine(di.Parent.FullName, string.Format("{0}_{1}.png", di.Name, i + 1)), ImageFormat.Png);
                    }
                }
            }
        }

        public static void ExportFolder(string path, string output) {
            Tools.Export(new List<string>(Directory.GetFiles(path, "*.png",SearchOption.TopDirectoryOnly)), output);

            foreach (var item in new DirectoryInfo(path).GetDirectories("*", SearchOption.TopDirectoryOnly)) {
                ExportFolder(item.FullName, Path.Combine(output, item.Name));
            }
        }

        public static void ChangeImgName(DirectoryInfo path) {
            FileInfo[] files = path.GetFiles("*.png", SearchOption.TopDirectoryOnly);
            List<string> path_list = new List<string>();
            foreach (var item in files) {
                path_list.Add(item.FullName);
            }
            path_list.Sort();
            for (int i = 0; i < path_list.Count; i++) {
                FileInfo file = new FileInfo(path_list[i]);
                string file_name = string.Format("{0}_{1}.png", file.Directory.Name, i + 1);
                file.MoveTo(Path.Combine(file.DirectoryName, file_name));
            }

            foreach (var item in path.GetDirectories("*", SearchOption.TopDirectoryOnly)) {
                ChangeImgName(item);
            }
        }
    }
}
