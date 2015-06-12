namespace GeoserverAutoPub
{
    partial class LayerSetting
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
            this.btn_CreateShape = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateShape
            // 
            this.btn_CreateShape.Location = new System.Drawing.Point(545, 67);
            this.btn_CreateShape.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateShape.Name = "btn_CreateShape";
            this.btn_CreateShape.Size = new System.Drawing.Size(121, 22);
            this.btn_CreateShape.TabIndex = 0;
            this.btn_CreateShape.Text = "生成图层";
            this.btn_CreateShape.UseVisualStyleBackColor = true;
            this.btn_CreateShape.Click += new System.EventHandler(this.btn_CreateShape_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(545, 140);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(121, 22);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "开启定时服务";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(545, 208);
            this.btn_End.Margin = new System.Windows.Forms.Padding(2);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(121, 22);
            this.btn_End.TabIndex = 2;
            this.btn_End.Text = "关闭定时服务";
            this.btn_End.UseVisualStyleBackColor = true;
            // 
            // LayerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 423);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_CreateShape);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LayerSetting";
            this.Text = "LayerSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateShape;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_End;
    }
}