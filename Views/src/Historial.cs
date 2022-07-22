using DataObjects.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.src
{
    public partial class Historial : Form
    {
        public Historial(Presentador presentador)
        {
            List<PrestamoDTO> prestamos = presentador.HistorialPrestamos();
            InitializeComponent();
            prestamos.ForEach(prest =>
            {
                nombreLibro.Text += ("\n" + prest.Ejemplar().Libro().Nombre().ToString());
                codigoISBN.Text += ("\n" + prest.Ejemplar().Libro().CodigoISBN().ToString());
                numEdicion.Text += ("\n" + prest.Ejemplar().NumEdicion().ToString());
                idSocio.Text += ("\n" + prest.Socio().NumIdentificacion().ToString());
                fechaPrestamo.Text += ("\n" + prest.FechaPrestamo().ToString());
                estadoPrestamo.Text += ("\n" + (prest.EstaFinalizado() ? "Devuelto" : "Pendiente").ToString());
            });
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1 = new();
            PrinterSettings printSet = new();
            printDocument1.PrinterSettings = printSet;
            printDocument1.PrintPage += GuardarPDF;
            printDocument1.Print();
        }

        private void GuardarPDF(object sender, PrintPageEventArgs e)
        {
            
        }
    }
}
