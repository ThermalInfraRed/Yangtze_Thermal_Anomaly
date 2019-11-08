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

namespace TIR_Yangtze
{
    public partial class MainForm : Form
    {

        #region 字段
        private string _imgPath;  // 影像文件路径
        private string _baseName; // 影像文件名(GF5文件夹采用指定格式)
        #endregion

        #region 构造函数
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 控件控制
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbg = new FolderBrowserDialog();
            if (fbg.ShowDialog() == DialogResult.OK)
            {
                _imgPath = fbg.SelectedPath;
                _baseName = Path.GetFileNameWithoutExtension(_imgPath);
                
                Debug.WriteLine(fbg.SelectedPath);
            }

        }
        #endregion

        #region 函数
        private void OpenFile()
        {
            
        }

        #endregion
    }
}
