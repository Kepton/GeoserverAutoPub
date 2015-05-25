namespace GeoserverAutoPub
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
            this.xtc_workspace = new DevExpress.XtraTab.XtraTabControl();
            this.xtp_workspace = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xtc_workspace)).BeginInit();
            this.xtc_workspace.SuspendLayout();
            this.xtp_workspace.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtc_workspace
            // 
            this.xtc_workspace.Location = new System.Drawing.Point(37, 34);
            this.xtc_workspace.Name = "xtc_workspace";
            this.xtc_workspace.SelectedTabPage = this.xtp_workspace;
            this.xtc_workspace.Size = new System.Drawing.Size(1150, 665);
            this.xtc_workspace.TabIndex = 0;
            this.xtc_workspace.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtp_workspace,
            this.xtraTabPage2});
            // 
            // xtp_workspace
            // 
            this.xtp_workspace.Controls.Add(this.button1);
            this.xtp_workspace.Controls.Add(this.comboBox1);
            this.xtp_workspace.Controls.Add(this.label1);
            this.xtp_workspace.Name = "xtp_workspace";
            this.xtp_workspace.Size = new System.Drawing.Size(1141, 629);
            this.xtp_workspace.Text = "工作区设置";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1141, 629);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "工作区列表：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择工作区";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 745);
            this.Controls.Add(this.xtc_workspace);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xtc_workspace)).EndInit();
            this.xtc_workspace.ResumeLayout(false);
            this.xtp_workspace.ResumeLayout(false);
            this.xtp_workspace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtc_workspace;
        private DevExpress.XtraTab.XtraTabPage xtp_workspace;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;

    }
}

