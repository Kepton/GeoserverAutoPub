﻿namespace GeoserverAutoPub
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
            this.SuspendLayout();
            // 
            // btn_CreateShape
            // 
            this.btn_CreateShape.Location = new System.Drawing.Point(727, 84);
            this.btn_CreateShape.Name = "btn_CreateShape";
            this.btn_CreateShape.Size = new System.Drawing.Size(196, 23);
            this.btn_CreateShape.TabIndex = 0;
            this.btn_CreateShape.Text = "生成图层";
            this.btn_CreateShape.UseVisualStyleBackColor = true;
            this.btn_CreateShape.Click += new System.EventHandler(this.btn_CreateShape_Click);
            // 
            // LayerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 529);
            this.Controls.Add(this.btn_CreateShape);
            this.Name = "LayerSetting";
            this.Text = "LayerSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateShape;
    }
}