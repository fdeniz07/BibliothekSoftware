using MessagingToolkit.QRCode.Codec;
using System;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmQRCode : Form
    {
        public FrmQRCode()
        {
            InitializeComponent();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureEdit1.Image = encoder.Encode(textEdit1.Text);
        }
    }
}