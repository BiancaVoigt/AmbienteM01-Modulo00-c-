using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08dLendoNumeros
{
    public partial class M01A08d : Form
    {
        public M01A08d()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        { 
            int n = Convert.ToInt32(txtN1.Text); // Int vai receber o que está na TextBox
            int d = n * 2;

            lblMsg.Text = " O dobro de " + n + " é igual a " + d + "."; // digitar a mensagem do label 2

            lblMsg.Visible = true;
        }
    }
}
