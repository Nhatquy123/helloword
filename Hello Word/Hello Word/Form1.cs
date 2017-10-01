using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hello_Word
{
    public partial class frmHelloWord : Form
    {
        public frmHelloWord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHelloWord.Text= "Hello Word!";
        }
    }
}
