namespace GeoserverAutoPub
{
    partial class WorkSpaceSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CreateWorkSpace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Com_workspaceList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_yes = new System.Windows.Forms.RadioButton();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_URI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CreateWorkSpace);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Com_workspaceList);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_URI);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_Msg);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 454);
            this.panel1.TabIndex = 4;
            // 
            // btn_CreateWorkSpace
            // 
            this.btn_CreateWorkSpace.Location = new System.Drawing.Point(25, 306);
            this.btn_CreateWorkSpace.Name = "btn_CreateWorkSpace";
            this.btn_CreateWorkSpace.Size = new System.Drawing.Size(124, 23);
            this.btn_CreateWorkSpace.TabIndex = 9;
            this.btn_CreateWorkSpace.Text = "创建工作区";
            this.btn_CreateWorkSpace.UseVisualStyleBackColor = true;
            this.btn_CreateWorkSpace.Click += new System.EventHandler(this.btn_CreateWorkSpace_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择工作区";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "工作区列表：";
            // 
            // Com_workspaceList
            // 
            this.Com_workspaceList.FormattingEnabled = true;
            this.Com_workspaceList.Location = new System.Drawing.Point(155, 46);
            this.Com_workspaceList.Margin = new System.Windows.Forms.Padding(2);
            this.Com_workspaceList.Name = "Com_workspaceList";
            this.Com_workspaceList.Size = new System.Drawing.Size(130, 20);
            this.Com_workspaceList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_yes);
            this.groupBox1.Controls.Add(this.rb_no);
            this.groupBox1.Location = new System.Drawing.Point(155, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
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
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "是否设置成默认：";
            // 
            // txt_URI
            // 
            this.txt_URI.Location = new System.Drawing.Point(155, 173);
            this.txt_URI.Name = "txt_URI";
            this.txt_URI.Size = new System.Drawing.Size(282, 21);
            this.txt_URI.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "命名空间（URI）：";
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Location = new System.Drawing.Point(341, 111);
            this.lbl_Msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(53, 12);
            this.lbl_Msg.TabIndex = 2;
            this.lbl_Msg.Text = "名称检测";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(155, 108);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(150, 21);
            this.txt_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "工作区名称（NAME）：";
            // 
            // WorkSpaceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 456);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WorkSpaceSetting";
            this.Text = "WorkspaceSetting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CreateWorkSpace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Com_workspaceList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_yes;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_URI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;


    }
}

