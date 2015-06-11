namespace GeoserverAutoPub
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
            this.panCaiDan = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Store = new System.Windows.Forms.Button();
            this.btn_workspace = new System.Windows.Forms.Button();
            this.panWorking = new System.Windows.Forms.Panel();
            this.panCaiDan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCaiDan
            // 
            this.panCaiDan.Controls.Add(this.button4);
            this.panCaiDan.Controls.Add(this.button3);
            this.panCaiDan.Controls.Add(this.btn_Store);
            this.panCaiDan.Controls.Add(this.btn_workspace);
            this.panCaiDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCaiDan.Location = new System.Drawing.Point(0, 0);
            this.panCaiDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panCaiDan.Name = "panCaiDan";
            this.panCaiDan.Size = new System.Drawing.Size(1269, 159);
            this.panCaiDan.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(835, 49);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Geoserver服务";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 49);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "图层生成";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Store
            // 
            this.btn_Store.Location = new System.Drawing.Point(379, 49);
            this.btn_Store.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Store.Name = "btn_Store";
            this.btn_Store.Size = new System.Drawing.Size(131, 29);
            this.btn_Store.TabIndex = 1;
            this.btn_Store.Text = "数据存储设置";
            this.btn_Store.UseVisualStyleBackColor = true;
            this.btn_Store.Click += new System.EventHandler(this.btn_Store_Click);
            // 
            // btn_workspace
            // 
            this.btn_workspace.Location = new System.Drawing.Point(139, 49);
            this.btn_workspace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_workspace.Name = "btn_workspace";
            this.btn_workspace.Size = new System.Drawing.Size(100, 29);
            this.btn_workspace.TabIndex = 0;
            this.btn_workspace.Text = "工作区设置";
            this.btn_workspace.UseVisualStyleBackColor = true;
            this.btn_workspace.Click += new System.EventHandler(this.btn_workspace_Click);
            // 
            // panWorking
            // 
            this.panWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panWorking.Location = new System.Drawing.Point(0, 159);
            this.panWorking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panWorking.Name = "panWorking";
            this.panWorking.Size = new System.Drawing.Size(1269, 567);
            this.panWorking.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 726);
            this.Controls.Add(this.panWorking);
            this.Controls.Add(this.panCaiDan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panCaiDan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCaiDan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Store;
        private System.Windows.Forms.Button btn_workspace;
        private System.Windows.Forms.Panel panWorking;
    }
}