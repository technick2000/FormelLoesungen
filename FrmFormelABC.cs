using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcFormelLöser
{
    public partial class FrmFormelABC : Form
    {

        
        public FrmFormelABC()
        {
            InitializeComponent();
        }

        public void ABCFormelErgebniss()
        {
            int A = Int16.Parse(txtA.Text);
            int B = Int16.Parse(txtB.Text);
            int C = Int16.Parse(txtC.Text);

            int z = 2 * A;
            int i = -1 * B;
            int b = B * B;
            int y = 4 * A * C;
            int j = b - y;

            i = i / z;
            double J = Math.Sqrt(j);
            J = J / z;


            DialogResult result = MessageBox.Show($"Dein Ergebinss ist: {i + J} und {i - J}", "Ergebniss", MessageBoxButtons.OK);
        }

        private void btnRechnen_Click(object sender, EventArgs e)
        {
            ABCFormelErgebniss();

        }
    }
}
