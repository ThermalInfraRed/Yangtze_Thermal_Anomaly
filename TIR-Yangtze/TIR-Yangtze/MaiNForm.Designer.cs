namespace TIR_Yangtze
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openfile = new System.Windows.Forms.ToolStripMenuItem();
            this.运行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.treeView_file = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_B = new System.Windows.Forms.ComboBox();
            this.comboBox_G = new System.Windows.Forms.ComboBox();
            this.comboBox_R = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_showimg = new System.Windows.Forms.Button();
            this.radioButton_visible = new System.Windows.Forms.RadioButton();
            this.radioButton_MIR = new System.Windows.Forms.RadioButton();
            this.pictureBox_showimg = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showimg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.运行ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openfile});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // openfile
            // 
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(100, 22);
            this.openfile.Text = "打开";
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // 运行ToolStripMenuItem
            // 
            this.运行ToolStripMenuItem.Name = "运行ToolStripMenuItem";
            this.运行ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.运行ToolStripMenuItem.Text = "运行";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pictureBox_showimg);
            this.splitContainer.Size = new System.Drawing.Size(1064, 557);
            this.splitContainer.SplitterDistance = 234;
            this.splitContainer.TabIndex = 1;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.treeView_file);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.radioButton_MIR);
            this.splitContainerLeft.Panel2.Controls.Add(this.radioButton_visible);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_showimg);
            this.splitContainerLeft.Panel2.Controls.Add(this.comboBox_B);
            this.splitContainerLeft.Panel2.Controls.Add(this.comboBox_G);
            this.splitContainerLeft.Panel2.Controls.Add(this.comboBox_R);
            this.splitContainerLeft.Panel2.Controls.Add(this.label3);
            this.splitContainerLeft.Panel2.Controls.Add(this.label2);
            this.splitContainerLeft.Panel2.Controls.Add(this.label1);
            this.splitContainerLeft.Size = new System.Drawing.Size(234, 557);
            this.splitContainerLeft.SplitterDistance = 364;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // treeView_file
            // 
            this.treeView_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_file.Location = new System.Drawing.Point(0, 0);
            this.treeView_file.Name = "treeView_file";
            this.treeView_file.Size = new System.Drawing.Size(232, 362);
            this.treeView_file.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer);
            this.panel1.Location = new System.Drawing.Point(13, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 557);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 24);
            this.panel2.TabIndex = 4;
            // 
            // comboBox_B
            // 
            this.comboBox_B.FormattingEnabled = true;
            this.comboBox_B.Location = new System.Drawing.Point(54, 105);
            this.comboBox_B.Name = "comboBox_B";
            this.comboBox_B.Size = new System.Drawing.Size(120, 20);
            this.comboBox_B.TabIndex = 14;
            // 
            // comboBox_G
            // 
            this.comboBox_G.FormattingEnabled = true;
            this.comboBox_G.Location = new System.Drawing.Point(54, 77);
            this.comboBox_G.Name = "comboBox_G";
            this.comboBox_G.Size = new System.Drawing.Size(120, 20);
            this.comboBox_G.TabIndex = 13;
            // 
            // comboBox_R
            // 
            this.comboBox_R.FormattingEnabled = true;
            this.comboBox_R.Location = new System.Drawing.Point(54, 49);
            this.comboBox_R.Name = "comboBox_R";
            this.comboBox_R.Size = new System.Drawing.Size(120, 20);
            this.comboBox_R.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "G:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "R:";
            // 
            // btn_showimg
            // 
            this.btn_showimg.Location = new System.Drawing.Point(31, 143);
            this.btn_showimg.Name = "btn_showimg";
            this.btn_showimg.Size = new System.Drawing.Size(144, 23);
            this.btn_showimg.TabIndex = 15;
            this.btn_showimg.Text = "显示图像";
            this.btn_showimg.UseVisualStyleBackColor = true;
            this.btn_showimg.Click += new System.EventHandler(this.Btn_showimg_Click);
            // 
            // radioButton_visible
            // 
            this.radioButton_visible.AutoSize = true;
            this.radioButton_visible.Location = new System.Drawing.Point(31, 18);
            this.radioButton_visible.Name = "radioButton_visible";
            this.radioButton_visible.Size = new System.Drawing.Size(59, 16);
            this.radioButton_visible.TabIndex = 16;
            this.radioButton_visible.Text = "可见光";
            this.radioButton_visible.UseVisualStyleBackColor = true;
            this.radioButton_visible.CheckedChanged += new System.EventHandler(this.RadioButton_visible_CheckedChanged);
            // 
            // radioButton_MIR
            // 
            this.radioButton_MIR.AutoSize = true;
            this.radioButton_MIR.Location = new System.Drawing.Point(116, 18);
            this.radioButton_MIR.Name = "radioButton_MIR";
            this.radioButton_MIR.Size = new System.Drawing.Size(59, 16);
            this.radioButton_MIR.TabIndex = 17;
            this.radioButton_MIR.Text = "热红外";
            this.radioButton_MIR.UseVisualStyleBackColor = true;
            this.radioButton_MIR.CheckedChanged += new System.EventHandler(this.RadioButton_MIR_CheckedChanged);
            // 
            // pictureBox_showimg
            // 
            this.pictureBox_showimg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_showimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_showimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_showimg.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_showimg.Name = "pictureBox_showimg";
            this.pictureBox_showimg.Size = new System.Drawing.Size(824, 555);
            this.pictureBox_showimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_showimg.TabIndex = 0;
            this.pictureBox_showimg.TabStop = false;
            this.pictureBox_showimg.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_showimg_Paint);
            this.pictureBox_showimg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_showimg_MouseDown);
            this.pictureBox_showimg.MouseEnter += new System.EventHandler(this.PictureBox_showimg_MouseEnter);
            this.pictureBox_showimg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_showimg_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 624);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            this.splitContainerLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
   //     private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem openfile;
        private System.Windows.Forms.TreeView treeView_file;
        private System.Windows.Forms.RadioButton radioButton_MIR;
        private System.Windows.Forms.RadioButton radioButton_visible;
        private System.Windows.Forms.Button btn_showimg;
        private System.Windows.Forms.ComboBox comboBox_B;
        private System.Windows.Forms.ComboBox comboBox_G;
        private System.Windows.Forms.ComboBox comboBox_R;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_showimg;
    }
}