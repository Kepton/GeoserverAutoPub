namespace GeoserverAutoPub
{
    partial class StoreSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.com_storeslist = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_selectedworkspacename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_storeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_storedescription = new System.Windows.Forms.TextBox();
            this.ckb_isenabled = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_shapepath = new System.Windows.Forms.TextBox();
            this.btn_selectpath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dbf = new System.Windows.Forms.TextBox();
            this.ckb_create_index = new System.Windows.Forms.CheckBox();
            this.ckb_cache_memory_map = new System.Windows.Forms.CheckBox();
            this.ckb_cache_reuse_memory = new System.Windows.Forms.CheckBox();
            this.btn_addstore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据存储列表：";
            // 
            // com_storeslist
            // 
            this.com_storeslist.FormattingEnabled = true;
            this.com_storeslist.Location = new System.Drawing.Point(444, 27);
            this.com_storeslist.Name = "com_storeslist";
            this.com_storeslist.Size = new System.Drawing.Size(121, 20);
            this.com_storeslist.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择当前数据存储";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前工作区：";
            // 
            // lbl_selectedworkspacename
            // 
            this.lbl_selectedworkspacename.AutoSize = true;
            this.lbl_selectedworkspacename.Location = new System.Drawing.Point(178, 32);
            this.lbl_selectedworkspacename.Name = "lbl_selectedworkspacename";
            this.lbl_selectedworkspacename.Size = new System.Drawing.Size(65, 12);
            this.lbl_selectedworkspacename.TabIndex = 4;
            this.lbl_selectedworkspacename.Text = "工作区名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(935, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "--------------------------------------------------增加数据存储-------------------------" +
    "--------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "数据源名称：";
            // 
            // txt_storeName
            // 
            this.txt_storeName.Location = new System.Drawing.Point(103, 122);
            this.txt_storeName.Name = "txt_storeName";
            this.txt_storeName.Size = new System.Drawing.Size(188, 21);
            this.txt_storeName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据源说明：";
            // 
            // txt_storedescription
            // 
            this.txt_storedescription.Location = new System.Drawing.Point(429, 121);
            this.txt_storedescription.Name = "txt_storedescription";
            this.txt_storedescription.Size = new System.Drawing.Size(188, 21);
            this.txt_storedescription.TabIndex = 9;
            // 
            // ckb_isenabled
            // 
            this.ckb_isenabled.AutoSize = true;
            this.ckb_isenabled.Location = new System.Drawing.Point(103, 157);
            this.ckb_isenabled.Name = "ckb_isenabled";
            this.ckb_isenabled.Size = new System.Drawing.Size(54, 16);
            this.ckb_isenabled.TabIndex = 10;
            this.ckb_isenabled.Text = " 启用";
            this.ckb_isenabled.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "---------------连接参数设置--------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Shape文件位置：";
            // 
            // txt_shapepath
            // 
            this.txt_shapepath.Location = new System.Drawing.Point(130, 226);
            this.txt_shapepath.Name = "txt_shapepath";
            this.txt_shapepath.Size = new System.Drawing.Size(188, 21);
            this.txt_shapepath.TabIndex = 13;
            // 
            // btn_selectpath
            // 
            this.btn_selectpath.Location = new System.Drawing.Point(325, 226);
            this.btn_selectpath.Name = "btn_selectpath";
            this.btn_selectpath.Size = new System.Drawing.Size(75, 23);
            this.btn_selectpath.TabIndex = 14;
            this.btn_selectpath.Text = "选择";
            this.btn_selectpath.UseVisualStyleBackColor = true;
            this.btn_selectpath.Click += new System.EventHandler(this.btn_selectpath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "DBF字符集：";
            // 
            // txt_dbf
            // 
            this.txt_dbf.Location = new System.Drawing.Point(568, 231);
            this.txt_dbf.Name = "txt_dbf";
            this.txt_dbf.Size = new System.Drawing.Size(188, 21);
            this.txt_dbf.TabIndex = 16;
            // 
            // ckb_create_index
            // 
            this.ckb_create_index.AutoSize = true;
            this.ckb_create_index.Checked = true;
            this.ckb_create_index.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_create_index.Location = new System.Drawing.Point(130, 276);
            this.ckb_create_index.Name = "ckb_create_index";
            this.ckb_create_index.Size = new System.Drawing.Size(324, 16);
            this.ckb_create_index.TabIndex = 17;
            this.ckb_create_index.Text = "如果缺少空间索引或者空间索引过时，重新建立空间索引";
            this.ckb_create_index.UseVisualStyleBackColor = true;
            // 
            // ckb_cache_memory_map
            // 
            this.ckb_cache_memory_map.AutoSize = true;
            this.ckb_cache_memory_map.Location = new System.Drawing.Point(130, 309);
            this.ckb_cache_memory_map.Name = "ckb_cache_memory_map";
            this.ckb_cache_memory_map.Size = new System.Drawing.Size(144, 16);
            this.ckb_cache_memory_map.TabIndex = 18;
            this.ckb_cache_memory_map.Text = "使用内存映射的缓冲区";
            this.ckb_cache_memory_map.UseVisualStyleBackColor = true;
            // 
            // ckb_cache_reuse_memory
            // 
            this.ckb_cache_reuse_memory.AutoSize = true;
            this.ckb_cache_reuse_memory.Checked = true;
            this.ckb_cache_reuse_memory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_cache_reuse_memory.Location = new System.Drawing.Point(130, 342);
            this.ckb_cache_reuse_memory.Name = "ckb_cache_reuse_memory";
            this.ckb_cache_reuse_memory.Size = new System.Drawing.Size(156, 16);
            this.ckb_cache_reuse_memory.TabIndex = 19;
            this.ckb_cache_reuse_memory.Text = "高速缓存和重用内存映射";
            this.ckb_cache_reuse_memory.UseVisualStyleBackColor = true;
            // 
            // btn_addstore
            // 
            this.btn_addstore.Location = new System.Drawing.Point(31, 381);
            this.btn_addstore.Name = "btn_addstore";
            this.btn_addstore.Size = new System.Drawing.Size(156, 23);
            this.btn_addstore.TabIndex = 20;
            this.btn_addstore.Text = "添加数据存储";
            this.btn_addstore.UseVisualStyleBackColor = true;
            this.btn_addstore.Click += new System.EventHandler(this.btn_addstore_Click);
            // 
            // StoreSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 416);
            this.Controls.Add(this.btn_addstore);
            this.Controls.Add(this.ckb_cache_reuse_memory);
            this.Controls.Add(this.ckb_cache_memory_map);
            this.Controls.Add(this.ckb_create_index);
            this.Controls.Add(this.txt_dbf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_selectpath);
            this.Controls.Add(this.txt_shapepath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckb_isenabled);
            this.Controls.Add(this.txt_storedescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_storeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_selectedworkspacename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.com_storeslist);
            this.Controls.Add(this.label1);
            this.Name = "StoreSetting";
            this.Text = "StoreSetting";
            this.Load += new System.EventHandler(this.StoreSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_storeslist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_selectedworkspacename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_storeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_storedescription;
        private System.Windows.Forms.CheckBox ckb_isenabled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_shapepath;
        private System.Windows.Forms.Button btn_selectpath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dbf;
        private System.Windows.Forms.CheckBox ckb_create_index;
        private System.Windows.Forms.CheckBox ckb_cache_memory_map;
        private System.Windows.Forms.CheckBox ckb_cache_reuse_memory;
        private System.Windows.Forms.Button btn_addstore;
    }
}