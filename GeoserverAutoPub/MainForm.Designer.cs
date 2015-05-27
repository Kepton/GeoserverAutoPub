namespace GeoserverAutoPub
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Com_workspaceList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_workspaceName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_URI = new System.Windows.Forms.TextBox();
            this.rb_yes = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CreateWorkSpace = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 18);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择工作区";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Com_workspaceList
            // 
            this.Com_workspaceList.FormattingEnabled = true;
            this.Com_workspaceList.Location = new System.Drawing.Point(139, 27);
            this.Com_workspaceList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Com_workspaceList.Name = "Com_workspaceList";
            this.Com_workspaceList.Size = new System.Drawing.Size(130, 20);
            this.Com_workspaceList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "工作区列表：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 577);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Com_workspaceList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(945, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "工作区设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_workspaceName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(945, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "存储空间设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "当前工作区：";
            // 
            // lbl_workspaceName
            // 
            this.lbl_workspaceName.AutoSize = true;
            this.lbl_workspaceName.Location = new System.Drawing.Point(98, 24);
            this.lbl_workspaceName.Name = "lbl_workspaceName";
            this.lbl_workspaceName.Size = new System.Drawing.Size(41, 12);
            this.lbl_workspaceName.TabIndex = 1;
            this.lbl_workspaceName.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CreateWorkSpace);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_URI);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_Msg);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(40, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 342);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "工作区名称（NAME）：";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(165, 52);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(150, 21);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Leave += new System.EventHandler(this.txt_Name_Leave);
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Location = new System.Drawing.Point(330, 55);
            this.lbl_Msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(53, 12);
            this.lbl_Msg.TabIndex = 2;
            this.lbl_Msg.Text = "名称检测";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "命名空间（URI）：";
            // 
            // txt_URI
            // 
            this.txt_URI.Location = new System.Drawing.Point(165, 104);
            this.txt_URI.Name = "txt_URI";
            this.txt_URI.Size = new System.Drawing.Size(282, 21);
            this.txt_URI.TabIndex = 4;
            // 
            // rb_yes
            // 
            this.rb_yes.AutoSize = true;
            this.rb_yes.Checked = true;
            this.rb_yes.Location = new System.Drawing.Point(15, 20);
            this.rb_yes.Name = "rb_yes";
            this.rb_yes.Size = new System.Drawing.Size(35, 16);
            this.rb_yes.TabIndex = 5;
            this.rb_yes.TabStop = true;
            this.rb_yes.Text = "是";
            this.rb_yes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "是否设置成默认：";
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(76, 20);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(35, 16);
            this.rb_no.TabIndex = 7;
            this.rb_no.Text = "否";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_yes);
            this.groupBox1.Controls.Add(this.rb_no);
            this.groupBox1.Location = new System.Drawing.Point(165, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btn_CreateWorkSpace
            // 
            this.btn_CreateWorkSpace.Location = new System.Drawing.Point(25, 223);
            this.btn_CreateWorkSpace.Name = "btn_CreateWorkSpace";
            this.btn_CreateWorkSpace.Size = new System.Drawing.Size(124, 23);
            this.btn_CreateWorkSpace.TabIndex = 9;
            this.btn_CreateWorkSpace.Text = "创建工作区";
            this.btn_CreateWorkSpace.UseVisualStyleBackColor = true;
            this.btn_CreateWorkSpace.Click += new System.EventHandler(this.btn_CreateWorkSpace_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 596);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Com_workspaceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_workspaceName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_yes;
        private System.Windows.Forms.TextBox txt_URI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.Button btn_CreateWorkSpace;

    }
}

