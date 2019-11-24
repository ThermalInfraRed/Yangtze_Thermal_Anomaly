using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Gdal = OSGeo.GDAL.Gdal;
using Ogr = OSGeo.OGR.Ogr;

namespace TIR_Yangtze
{
    public partial class MainForm : Form
    {

        #region 字段
        private string _imgPath;  // 影像文件路径
        private string _baseName; // 影像文件名(GF5文件夹采用指定格式)
        private Bitmap ds_bitmap;                      //由影像生成的位图
        private OSGeo.GDAL.Dataset[] ds_class;   //放置波段数据
        private Point ds_m_ptCanvas;           //画布原点在设备上的坐标
        private float m_nScale = 1.0F;      //缩放比例
        private Point ds_Bmp;              //图像位于画布坐标系中的坐标
        private Point ds_m_ptMouseDown;        //鼠标点下时在设备坐标上的坐标
        private Point ds_m_ptCanvasBuf;        //重置画布坐标计算时用的临时变量
        #endregion

        #region 构造函数
        public MainForm()
        {
            InitializeComponent();
            this.pictureBox_showimg.MouseWheel += new MouseEventHandler(pictureBox_showimg_MouseWheel);
        }
        #endregion

        #region 控件控制
        private void openfile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbg = new FolderBrowserDialog();
            if (fbg.ShowDialog() == DialogResult.OK)
            {
                _imgPath = fbg.SelectedPath;
                _baseName = Path.GetFileNameWithoutExtension(_imgPath);
                PaintTreeView(treeView_file,_imgPath);
            }

        }
        #endregion
        #region 生成程序所在根目录的TreeView
        private void PaintTreeView(TreeView treeView, string fullPath)
        {
            try
            {
                treeView.Nodes.Clear(); //清空TreeView

                DirectoryInfo dirs = new DirectoryInfo(fullPath); //获得程序所在路径的目录对象
                DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象
                FileInfo[] file = dirs.GetFiles();//获得目录下文件对象
                int dircount = dir.Count();//获得文件夹对象数量
                int filecount = file.Count();//获得文件对象数量
                //循环文件夹
                for (int i = 0; i < dircount; i++)
                {
                    treeView.Nodes.Add(dir[i].Name);
                    string pathNode = fullPath + "\\" + dir[i].Name;
                    GetMultiNode(treeView.Nodes[i], pathNode);
                }

                //循环文件
                for (int j = 0; j < filecount; j++)
                {
                    if (file[j].Extension == ".tiff")
                    {
                        treeView.Nodes.Add(file[j].Name);
                        Readimg(file[j].Name,file[j].FullName);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n出错的位置为：Form1.PaintTreeView()","出错啦！",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 遍历TreeView根节点下文件和文件夹
        private bool GetMultiNode(TreeNode treeNode, string path)
        {
            if (Directory.Exists(path) == false)
            {
                return false;
            }

            DirectoryInfo dirs = new DirectoryInfo(path); //获得程序所在路径的目录对象
            DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象
            FileInfo[] file = dirs.GetFiles();//获得目录下文件对象
            int dircount = dir.Count();//获得文件夹对象数量
            int filecount = file.Count();//获得文件对象数量
            int sumcount = dircount + filecount;

            if (sumcount == 0)
            {
                return false;
            }

            //循环文件夹
            for (int j = 0; j < dircount; j++)
            {
                treeNode.Nodes.Add(dir[j].Name);
                string pathNodeB = path + "\\" + dir[j].Name;
                GetMultiNode(treeNode.Nodes[j], pathNodeB);
            }

            //循环文件
            for (int j = 0; j < filecount; j++)
            {
                treeNode.Nodes.Add(file[j].Name);
            }
            return true;
        }
        #endregion

        #region 读取波段数据
        private void Readimg(string filename,string path)
        {

            string file_name = Path.GetFileNameWithoutExtension(filename);
            string []temp = file_name.Split('_');
            string bandname = temp[temp.Length - 1];
            switch (bandname)
            {
                case "B1":
                    ds_class[0] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B2":
                    ds_class[1] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B3":
                    ds_class[2] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B4":
                    ds_class[3] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B5":
                    ds_class[4] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B6":
                    ds_class[5] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B7":
                    ds_class[6] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B8":
                    ds_class[7] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B9":
                    ds_class[8] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B10":
                    ds_class[9] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B11":
                    ds_class[10] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                case "B12":
                    ds_class[11] = Gdal.Open(path, OSGeo.GDAL.Access.GA_ReadOnly);
                    break;
                default:
                    break;
            }


        }
        #endregion

        #region 转化位图
        public Bitmap GetImage(OSGeo.GDAL.Dataset []ds, Rectangle showRect, int band_R, int band_G, int band_B)
        {
            if (ds[band_R - 1].RasterXSize != ds[band_G - 1].RasterXSize || ds[band_R - 1].RasterXSize != ds[band_B - 1].RasterXSize || ds[band_B - 1].RasterXSize != ds[band_G - 1].RasterXSize)
            {
                MessageBox.Show("所选波段影像宽度应相同！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else if (ds[band_R - 1].RasterYSize != ds[band_G - 1].RasterYSize || ds[band_R - 1].RasterYSize != ds[band_B - 1].RasterYSize || ds[band_B - 1].RasterYSize != ds[band_G - 1].RasterYSize)
            {
                MessageBox.Show("所选波段影像高度应相同！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                int imgWidth = ds[band_R - 1].RasterXSize;   //影像宽
                int imgHeight = ds[band_R - 1].RasterYSize;  //影像高
                float ImgRatio = imgWidth / (float)imgHeight;  //影像宽高比
                int BoxWidth = showRect.Width;
                int BoxHeight = showRect.Height;
                float BoxRatio = imgWidth / (float)imgHeight;  //显示控件宽高比
                int BufferWidth, BufferHeight;
                if (BoxRatio >= ImgRatio)
                {
                    BufferHeight = BoxHeight;
                    BufferWidth = (int)(BoxHeight * ImgRatio);
                }
                else
                {
                    BufferWidth = BoxWidth;
                    BufferHeight = (int)(BoxWidth / ImgRatio);
                }
                //构建位图
                Bitmap bitmap = new Bitmap(BufferWidth, BufferHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                double[] r = new double[BufferWidth * BufferHeight];
                OSGeo.GDAL.Band band1 = ds[band_R - 1].GetRasterBand(1);
                band1.ReadRaster(0, 0, imgWidth, imgHeight, r, BufferWidth, BufferHeight, 0, 0);  //读取图像到内存
                double[] maxandmin1 = { 0, 0 };
                band1.ComputeRasterMinMax(maxandmin1, 0);
                double[] g = new double[BufferWidth * BufferHeight];
                OSGeo.GDAL.Band band2 = ds[band_G].GetRasterBand(1);
                band2.ReadRaster(0, 0, imgWidth, imgHeight, g, BufferWidth, BufferHeight, 0, 0);
                double[] maxandmin2 = { 0, 0 };
                band2.ComputeRasterMinMax(maxandmin2, 0);
                double[] b = new double[BufferWidth * BufferHeight];
                OSGeo.GDAL.Band band3 = ds[band_B].GetRasterBand(1);
                band3.ReadRaster(0, 0, imgWidth, imgHeight, b, BufferWidth, BufferHeight, 0, 0);
                double[] maxandmin3 = { 0, 0 };
                band3.ComputeRasterMinMax(maxandmin3, 0);
                int i, j;
                for (i = 0; i < BufferWidth; i++)
                {
                    for (j = 0; j < BufferHeight; j++)
                    {
                        double rVal = Convert.ToDouble(r[i + j * BufferWidth]);
                        rVal = (rVal - maxandmin1[0]) / (maxandmin1[1] - maxandmin1[0]) * 255;
                        double gVal = Convert.ToDouble(g[i + j * BufferWidth]);
                        gVal = (gVal - maxandmin2[0]) / (maxandmin2[1] - maxandmin2[0]) * 255;
                        double bVal = Convert.ToDouble(b[i + j * BufferWidth]);
                        bVal = (bVal - maxandmin3[0]) / (maxandmin3[1] - maxandmin3[0]) * 255;
                        Color newColor = Color.FromArgb(Convert.ToInt32(rVal), Convert.ToInt32(gVal), Convert.ToInt32(bVal));
                        bitmap.SetPixel(i, j, newColor);
                    }
                }
                return bitmap;
            }
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            GdalConfiguration.ConfigureGdal();
            GdalConfiguration.ConfigureOgr();
            ds_class = new OSGeo.GDAL.Dataset[12];
            //          Gdal.AllRegister();
        }

        private void RadioButton_visible_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_visible.Checked == true)
            {
                int[] bandcount = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
                comboBox_R.DataSource = bandcount.Clone();
                comboBox_B.DataSource = bandcount.Clone();
                comboBox_G.DataSource = bandcount.Clone();
            }
            else
            {
                int[] bandcount = new int[4] { 9, 10, 11, 12};
                comboBox_R.DataSource = bandcount.Clone();
                comboBox_B.DataSource = bandcount.Clone();
                comboBox_G.DataSource = bandcount.Clone() ;
            }
        }

        private void RadioButton_MIR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_visible.Checked == true)
            {
                int[] bandcount = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
                comboBox_R.DataSource = bandcount.Clone();
                comboBox_B.DataSource = bandcount.Clone();
                comboBox_G.DataSource = bandcount.Clone();
            }
            else
            {
                int[] bandcount = new int[4] { 9, 10, 11, 12 };
                comboBox_R.DataSource = bandcount.Clone();
                comboBox_B.DataSource = bandcount.Clone();
                comboBox_G.DataSource = bandcount.Clone();
            }
        }

        private void Btn_showimg_Click(object sender, EventArgs e)
        {
            int band_R = Convert.ToInt32(comboBox_R.Text);
            int band_G = Convert.ToInt32(comboBox_G.Text);
            int band_B = Convert.ToInt32(comboBox_B.Text);
            if(ds_class[band_R-1] == null || ds_class[band_G - 1] == null || ds_class[band_B - 1] == null)
            {
                MessageBox.Show("未成功打开相应影像，请重试", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Rectangle pictureRect = new Rectangle();
                pictureRect.X = 0;
                pictureRect.Y = 0;
                pictureRect.Width = this.pictureBox_showimg.Width;
                pictureRect.Height = this.pictureBox_showimg.Height;
                Bitmap bitmap = GetImage(ds_class, pictureRect, band_R, band_G, band_B);   //遥感影像生成bitmap
                pictureBox_showimg.Image = bitmap;
                ds_bitmap = bitmap;
                ds_Bmp = new Point(-(ds_bitmap.Width / 2), -(ds_bitmap.Height / 2));
                ds_m_ptCanvas = new Point(pictureBox_showimg.Width / 2, pictureBox_showimg.Height / 2);
            }
        }
        #region 影像缩放，拖动
        private void PictureBox_showimg_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_showimg.Focus();
        }
        private void pictureBox_showimg_MouseWheel(object sender, MouseEventArgs e)
        {
            pictureBox_showimg.Image = null;
            if (m_nScale <= 0.3 && e.Delta <= 0) return;        //缩小下线
            if (m_nScale >= 4.9 && e.Delta >= 0) return;        //放大上线
            //获取 当前点到画布坐标原点的距离
            SizeF szSub = (Size)ds_m_ptCanvas - (Size)e.Location;
            //当前的距离差除以缩放比还原到未缩放长度
            float tempX = szSub.Width / m_nScale;           //这里
            float tempY = szSub.Height / m_nScale;          //将画布比例
            //还原上一次的偏移                               //按照当前缩放比还原到
            ds_m_ptCanvas.X -= (int)(szSub.Width - tempX);     //没有缩放
            ds_m_ptCanvas.Y -= (int)(szSub.Height - tempY);    //的状态
            //重置距离差为  未缩放状态                       
            szSub.Width = tempX;
            szSub.Height = tempY;
            m_nScale += e.Delta > 0 ? 0.2F : -0.2F;
            //重新计算 缩放并 重置画布原点坐标
            ds_m_ptCanvas.X += (int)(szSub.Width * m_nScale - szSub.Width);
            ds_m_ptCanvas.Y += (int)(szSub.Height * m_nScale - szSub.Height);
            pictureBox_showimg.Invalidate();
        }
        private void PictureBox_showimg_Paint(object sender, PaintEventArgs e)
        {
            if (ds_bitmap == null)
                return;
            if (pictureBox_showimg.Image == null)
            {
                Graphics g = e.Graphics;
                g.TranslateTransform(ds_m_ptCanvas.X, ds_m_ptCanvas.Y);       //设置坐标偏移
                g.ScaleTransform(m_nScale, m_nScale);                   //设置缩放比
                g.DrawImage(ds_bitmap, ds_Bmp);                            //绘制图像
                                                                              //  g.DrawImage(T1_bitmap, 0, 0);
                g.ResetTransform();                                     //重置坐标系
            }
            else
                return;
        }
        private void PictureBox_showimg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {      //如果左键点下    初始化计算要用的临时数据
                ds_m_ptMouseDown = e.Location;
                ds_m_ptCanvasBuf = ds_m_ptCanvas;
            }
            pictureBox_showimg.Focus();
        }
        private void PictureBox_showimg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {      //移动过程中 左键点下 重置画布坐标系
                ds_m_ptCanvas = (Point)((Size)ds_m_ptCanvasBuf + ((Size)e.Location - (Size)ds_m_ptMouseDown));
                pictureBox_showimg.Invalidate();
            }
        }
        #endregion
    }


}
