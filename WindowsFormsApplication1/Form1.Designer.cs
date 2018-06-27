namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.draw = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.projrct_setting = new System.Windows.Forms.Button();
            this.player_edit = new System.Windows.Forms.Button();
            this.project_draw = new System.Windows.Forms.Button();
            this.project_print = new System.Windows.Forms.Button();
            this.city_draw = new System.Windows.Forms.Button();
            this.city_edit = new System.Windows.Forms.Button();
            this.city_print = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_city_edit = new System.Windows.Forms.Panel();
            this.city_add = new System.Windows.Forms.Button();
            this.city_return = new System.Windows.Forms.Button();
            this.city_delet = new System.Windows.Forms.Button();
            this.city_watch = new System.Windows.Forms.Button();
            this.city_textbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_project = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.project_textbox = new System.Windows.Forms.TextBox();
            this.project_import = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_player = new System.Windows.Forms.Panel();
            this.player_add = new System.Windows.Forms.Button();
            this.player_return = new System.Windows.Forms.Button();
            this.player_delet = new System.Windows.Forms.Button();
            this.player_watch = new System.Windows.Forms.Button();
            this.player_textbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_city_edit.SuspendLayout();
            this.panel_project.SuspendLayout();
            this.panel_player.SuspendLayout();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.SeaGreen;
            this.draw.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.draw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.draw.Location = new System.Drawing.Point(137, 182);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(165, 61);
            this.draw.TabIndex = 0;
            this.draw.Text = "抽签";
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.draw_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(453, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "成绩录入";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(69, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 94);
            this.label1.TabIndex = 2;
            this.label1.Text = "辽宁省电脑制作活动信息管理与抽签系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.draw);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(200, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 406);
            this.panel1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(127, 286);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(504, 96);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "功能介绍：1.对城市顺序抽签。2.对参赛选手进行随机编号。3.支持设置同单位是否相碰。4.参赛选手名单导入、导出Excel文档。5.按组别、项目、城市等设置进行自" +
    "动分组。6.分组表打印、导出excel文档。";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(869, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "组别";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "项目名称";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "项目总组数";
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "项目分组数";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.projrct_setting);
            this.panel2.Controls.Add(this.player_edit);
            this.panel2.Controls.Add(this.project_draw);
            this.panel2.Controls.Add(this.project_print);
            this.panel2.Controls.Add(this.city_draw);
            this.panel2.Controls.Add(this.city_edit);
            this.panel2.Controls.Add(this.city_print);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(196, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 560);
            this.panel2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(188, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(496, 27);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "辽宁省电脑制作活动信息管理与抽签系统";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.MintCream;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar1.Location = new System.Drawing.Point(265, 281);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 24);
            this.progressBar1.TabIndex = 20;
            // 
            // projrct_setting
            // 
            this.projrct_setting.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.projrct_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.projrct_setting.Location = new System.Drawing.Point(312, 331);
            this.projrct_setting.Name = "projrct_setting";
            this.projrct_setting.Size = new System.Drawing.Size(127, 37);
            this.projrct_setting.TabIndex = 19;
            this.projrct_setting.Text = "项目设置";
            this.projrct_setting.UseVisualStyleBackColor = false;
            this.projrct_setting.Click += new System.EventHandler(this.projrct_setting_Click);
            // 
            // player_edit
            // 
            this.player_edit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.player_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player_edit.Location = new System.Drawing.Point(524, 331);
            this.player_edit.Name = "player_edit";
            this.player_edit.Size = new System.Drawing.Size(127, 37);
            this.player_edit.TabIndex = 18;
            this.player_edit.Text = "选手编辑";
            this.player_edit.UseVisualStyleBackColor = false;
            this.player_edit.Click += new System.EventHandler(this.player_edit_Click);
            // 
            // project_draw
            // 
            this.project_draw.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.project_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project_draw.Location = new System.Drawing.Point(312, 427);
            this.project_draw.Name = "project_draw";
            this.project_draw.Size = new System.Drawing.Size(127, 37);
            this.project_draw.TabIndex = 17;
            this.project_draw.Text = "抽签";
            this.project_draw.UseVisualStyleBackColor = false;
            this.project_draw.Click += new System.EventHandler(this.project_draw_Click);
            // 
            // project_print
            // 
            this.project_print.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.project_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project_print.Location = new System.Drawing.Point(524, 427);
            this.project_print.Name = "project_print";
            this.project_print.Size = new System.Drawing.Size(127, 37);
            this.project_print.TabIndex = 16;
            this.project_print.Text = "打印";
            this.project_print.UseVisualStyleBackColor = false;
            this.project_print.Click += new System.EventHandler(this.project_print_Click);
            // 
            // city_draw
            // 
            this.city_draw.BackColor = System.Drawing.Color.SeaGreen;
            this.city_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.city_draw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.city_draw.Location = new System.Drawing.Point(524, 140);
            this.city_draw.Name = "city_draw";
            this.city_draw.Size = new System.Drawing.Size(127, 37);
            this.city_draw.TabIndex = 15;
            this.city_draw.Text = "抽签";
            this.city_draw.UseVisualStyleBackColor = false;
            this.city_draw.Click += new System.EventHandler(this.city_draw_Click);
            // 
            // city_edit
            // 
            this.city_edit.BackColor = System.Drawing.Color.SeaGreen;
            this.city_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.city_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.city_edit.Location = new System.Drawing.Point(312, 194);
            this.city_edit.Name = "city_edit";
            this.city_edit.Size = new System.Drawing.Size(127, 37);
            this.city_edit.TabIndex = 14;
            this.city_edit.Text = "城市编辑";
            this.city_edit.UseVisualStyleBackColor = false;
            this.city_edit.Click += new System.EventHandler(this.city_edit_Click);
            // 
            // city_print
            // 
            this.city_print.BackColor = System.Drawing.Color.SeaGreen;
            this.city_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.city_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.city_print.Location = new System.Drawing.Point(524, 233);
            this.city_print.Name = "city_print";
            this.city_print.Size = new System.Drawing.Size(127, 37);
            this.city_print.TabIndex = 13;
            this.city_print.Text = "打印";
            this.city_print.UseVisualStyleBackColor = false;
            this.city_print.Click += new System.EventHandler(this.city_print_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(99, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "比赛抽签";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(99, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "城市抽签";
            // 
            // panel_city_edit
            // 
            this.panel_city_edit.BackColor = System.Drawing.Color.LightBlue;
            this.panel_city_edit.Controls.Add(this.city_add);
            this.panel_city_edit.Controls.Add(this.city_return);
            this.panel_city_edit.Controls.Add(this.city_delet);
            this.panel_city_edit.Controls.Add(this.city_watch);
            this.panel_city_edit.Controls.Add(this.city_textbox);
            this.panel_city_edit.Location = new System.Drawing.Point(242, 136);
            this.panel_city_edit.Name = "panel_city_edit";
            this.panel_city_edit.Size = new System.Drawing.Size(720, 211);
            this.panel_city_edit.TabIndex = 5;
            // 
            // city_add
            // 
            this.city_add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.city_add.Location = new System.Drawing.Point(458, 35);
            this.city_add.Name = "city_add";
            this.city_add.Size = new System.Drawing.Size(111, 45);
            this.city_add.TabIndex = 10;
            this.city_add.Text = "EXCEL导入";
            this.city_add.UseVisualStyleBackColor = false;
            this.city_add.Click += new System.EventHandler(this.city_add_Click);
            // 
            // city_return
            // 
            this.city_return.BackColor = System.Drawing.Color.White;
            this.city_return.Location = new System.Drawing.Point(501, 111);
            this.city_return.Name = "city_return";
            this.city_return.Size = new System.Drawing.Size(164, 51);
            this.city_return.TabIndex = 9;
            this.city_return.Text = "返回主界面";
            this.city_return.UseVisualStyleBackColor = false;
            this.city_return.Click += new System.EventHandler(this.city_return_Click);
            // 
            // city_delet
            // 
            this.city_delet.BackColor = System.Drawing.Color.Crimson;
            this.city_delet.Location = new System.Drawing.Point(593, 35);
            this.city_delet.Name = "city_delet";
            this.city_delet.Size = new System.Drawing.Size(86, 45);
            this.city_delet.TabIndex = 8;
            this.city_delet.Text = "删除";
            this.city_delet.UseVisualStyleBackColor = false;
            this.city_delet.Click += new System.EventHandler(this.city_delet_Click);
            // 
            // city_watch
            // 
            this.city_watch.BackColor = System.Drawing.Color.White;
            this.city_watch.Location = new System.Drawing.Point(356, 34);
            this.city_watch.Name = "city_watch";
            this.city_watch.Size = new System.Drawing.Size(81, 46);
            this.city_watch.TabIndex = 7;
            this.city_watch.Text = "浏览...";
            this.city_watch.UseVisualStyleBackColor = false;
            this.city_watch.Click += new System.EventHandler(this.city_watch_Click);
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(20, 37);
            this.city_textbox.Multiline = true;
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.Size = new System.Drawing.Size(295, 38);
            this.city_textbox.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel_project
            // 
            this.panel_project.BackColor = System.Drawing.Color.LightBlue;
            this.panel_project.Controls.Add(this.progressBar2);
            this.panel_project.Controls.Add(this.dataGridView1);
            this.panel_project.Controls.Add(this.button4);
            this.panel_project.Controls.Add(this.project_textbox);
            this.panel_project.Controls.Add(this.project_import);
            this.panel_project.Controls.Add(this.button3);
            this.panel_project.Controls.Add(this.button1);
            this.panel_project.Location = new System.Drawing.Point(178, 21);
            this.panel_project.Name = "panel_project";
            this.panel_project.Size = new System.Drawing.Size(897, 611);
            this.panel_project.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(741, 516);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "导入";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // project_textbox
            // 
            this.project_textbox.Location = new System.Drawing.Point(433, 472);
            this.project_textbox.Multiline = true;
            this.project_textbox.Name = "project_textbox";
            this.project_textbox.Size = new System.Drawing.Size(300, 30);
            this.project_textbox.TabIndex = 4;
            // 
            // project_import
            // 
            this.project_import.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.project_import.Location = new System.Drawing.Point(741, 469);
            this.project_import.Name = "project_import";
            this.project_import.Size = new System.Drawing.Size(146, 37);
            this.project_import.TabIndex = 3;
            this.project_import.Text = "选择EXCEL表";
            this.project_import.UseVisualStyleBackColor = false;
            this.project_import.Click += new System.EventHandler(this.project_import_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(741, 561);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "返回主界面";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(587, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "生成excel报表";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_player
            // 
            this.panel_player.BackColor = System.Drawing.Color.LightBlue;
            this.panel_player.Controls.Add(this.player_add);
            this.panel_player.Controls.Add(this.player_return);
            this.panel_player.Controls.Add(this.player_delet);
            this.panel_player.Controls.Add(this.player_watch);
            this.panel_player.Controls.Add(this.player_textbox);
            this.panel_player.Location = new System.Drawing.Point(200, 150);
            this.panel_player.Name = "panel_player";
            this.panel_player.Size = new System.Drawing.Size(713, 201);
            this.panel_player.TabIndex = 22;
            // 
            // player_add
            // 
            this.player_add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.player_add.Location = new System.Drawing.Point(465, 29);
            this.player_add.Name = "player_add";
            this.player_add.Size = new System.Drawing.Size(111, 45);
            this.player_add.TabIndex = 15;
            this.player_add.Text = "EXCEL导入";
            this.player_add.UseVisualStyleBackColor = false;
            this.player_add.Click += new System.EventHandler(this.player_add_Click);
            // 
            // player_return
            // 
            this.player_return.BackColor = System.Drawing.Color.White;
            this.player_return.Location = new System.Drawing.Point(508, 105);
            this.player_return.Name = "player_return";
            this.player_return.Size = new System.Drawing.Size(164, 51);
            this.player_return.TabIndex = 14;
            this.player_return.Text = "返回主界面";
            this.player_return.UseVisualStyleBackColor = false;
            this.player_return.Click += new System.EventHandler(this.player_return_Click);
            // 
            // player_delet
            // 
            this.player_delet.BackColor = System.Drawing.Color.Crimson;
            this.player_delet.Location = new System.Drawing.Point(600, 29);
            this.player_delet.Name = "player_delet";
            this.player_delet.Size = new System.Drawing.Size(86, 45);
            this.player_delet.TabIndex = 13;
            this.player_delet.Text = "删除";
            this.player_delet.UseVisualStyleBackColor = false;
            this.player_delet.Click += new System.EventHandler(this.player_delet_Click);
            // 
            // player_watch
            // 
            this.player_watch.BackColor = System.Drawing.Color.White;
            this.player_watch.Location = new System.Drawing.Point(363, 28);
            this.player_watch.Name = "player_watch";
            this.player_watch.Size = new System.Drawing.Size(81, 46);
            this.player_watch.TabIndex = 12;
            this.player_watch.Text = "浏览...";
            this.player_watch.UseVisualStyleBackColor = false;
            this.player_watch.Click += new System.EventHandler(this.player_watch_Click);
            // 
            // player_textbox
            // 
            this.player_textbox.Location = new System.Drawing.Point(27, 31);
            this.player_textbox.Multiline = true;
            this.player_textbox.Name = "player_textbox";
            this.player_textbox.Size = new System.Drawing.Size(295, 38);
            this.player_textbox.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(8, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 160);
            this.panel3.TabIndex = 24;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.MintCream;
            this.progressBar2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.progressBar2.Location = new System.Drawing.Point(316, 256);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(289, 23);
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Value = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1087, 644);
            this.Controls.Add(this.panel_project);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_player);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_city_edit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_city_edit.ResumeLayout(false);
            this.panel_city_edit.PerformLayout();
            this.panel_project.ResumeLayout(false);
            this.panel_project.PerformLayout();
            this.panel_player.ResumeLayout(false);
            this.panel_player.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button projrct_setting;
        private System.Windows.Forms.Button player_edit;
        private System.Windows.Forms.Button project_draw;
        private System.Windows.Forms.Button project_print;
        private System.Windows.Forms.Button city_draw;
        private System.Windows.Forms.Button city_edit;
        private System.Windows.Forms.Button city_print;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_city_edit;
        private System.Windows.Forms.Button city_add;
        private System.Windows.Forms.Button city_return;
        private System.Windows.Forms.Button city_delet;
        private System.Windows.Forms.Button city_watch;
        private System.Windows.Forms.TextBox city_textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel_project;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_player;
        private System.Windows.Forms.Button player_add;
        private System.Windows.Forms.Button player_return;
        private System.Windows.Forms.Button player_delet;
        private System.Windows.Forms.Button player_watch;
        private System.Windows.Forms.TextBox player_textbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button project_import;
        private System.Windows.Forms.TextBox project_textbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

