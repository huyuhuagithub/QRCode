using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
namespace QRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取生成二维码的参数（规模、版本、链接地址）
            int size = Convert.ToInt32(this.num_Size.Text);
            int version = Convert.ToInt32(this.num_version.Text);
            string linkaddress = this.txb_LinkAddress.Text.ToString();
            //调用生成二维码图片的事件，并把图片显示在图片框中
            Image img = QrCodeBitmap(linkaddress, size, version);
            this.pic_MyImg.Image = img;
        }

        private Image QrCodeBitmap(string link, int size, int version)
        {
            QRCodeEncoder qrcodeencoder = new QRCodeEncoder();//生成设置编码实例
            qrcodeencoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//字节编码
            qrcodeencoder.QRCodeScale = size;//二维码规模大小
            qrcodeencoder.QRCodeVersion = version;//二维码版本
            qrcodeencoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;//设置错误校验（错误更正）的级别：中等M
            Image img = qrcodeencoder.Encode(link);//生成二维码image图片
            return img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.pic_MyImg.Image == null)
            {
                MessageBox.Show("没有可用的二维码图片！");
            }
            else
            {
                SaveFileDialog saveqrimg = new SaveFileDialog();
                saveqrimg.Title = "二维码图片保存";
                saveqrimg.Filter = @"jpeg|*.jpg|bmp|*.bmp|gif|*.gif";
                if (saveqrimg.ShowDialog() == DialogResult.OK)
                {
                    this.pic_MyImg.Image.Save(saveqrimg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }
    }
}
