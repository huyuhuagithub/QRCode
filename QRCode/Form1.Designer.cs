namespace QRCode
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pic_MyImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Size = new System.Windows.Forms.NumericUpDown();
            this.num_version = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_LinkAddress = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MyImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_version)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_MyImg
            // 
            this.pic_MyImg.Location = new System.Drawing.Point(178, 190);
            this.pic_MyImg.Name = "pic_MyImg";
            this.pic_MyImg.Size = new System.Drawing.Size(273, 225);
            this.pic_MyImg.TabIndex = 1;
            this.pic_MyImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "二维码规模";
            // 
            // num_Size
            // 
            this.num_Size.Location = new System.Drawing.Point(120, 28);
            this.num_Size.Name = "num_Size";
            this.num_Size.Size = new System.Drawing.Size(120, 21);
            this.num_Size.TabIndex = 3;
            this.num_Size.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // num_version
            // 
            this.num_version.Location = new System.Drawing.Point(382, 26);
            this.num_version.Name = "num_version";
            this.num_version.Size = new System.Drawing.Size(120, 21);
            this.num_version.TabIndex = 3;
            this.num_version.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "二维码版本";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "二维码链接";
            // 
            // txb_LinkAddress
            // 
            this.txb_LinkAddress.Location = new System.Drawing.Point(120, 71);
            this.txb_LinkAddress.Name = "txb_LinkAddress";
            this.txb_LinkAddress.Size = new System.Drawing.Size(382, 21);
            this.txb_LinkAddress.TabIndex = 5;
            this.txb_LinkAddress.Text = "www.baidu.com";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "保存二维码";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txb_LinkAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_version);
            this.Controls.Add(this.num_Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_MyImg);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_MyImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_version)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_MyImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Size;
        private System.Windows.Forms.NumericUpDown num_version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_LinkAddress;
        private System.Windows.Forms.Button button2;
    }
}

