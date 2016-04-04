using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace HeartRateApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {   
            InitializeComponent();
        }

       
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return createParams;
            }
        }

        public Label HeartRateDisplay()
        {
            return this.heartRateDisplay;
        }
    }

}
