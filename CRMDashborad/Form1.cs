using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMDashborad
{
    public partial class Form1 : Form
    {
        public Form1(string url)
        {
            InitializeComponent(url);
            this.Resize += new System.EventHandler(this.Form_Resize);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form_Resize(object sender, EventArgs e)
        {
            this.webView21.Size = this.ClientSize - new System.Drawing.Size(this.webView21.Location);
        }
    }
}
