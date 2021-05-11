using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmTest
{
    public partial class FrmTester : Form
    {
        private Vendedor v = new Vendedor("vendedor1");
        public FrmTester()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Text = "Prueba de informe";
            //rtbInforme.Text = Vendedor.InformedeVentas(v);


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
