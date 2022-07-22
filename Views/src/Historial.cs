using DataObjects.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.src
{
    public partial class Historial : Form
    {
        private readonly Presentador presentador;
        public Historial(Presentador presentador)
        {
            this.presentador = presentador;
            List<PrestamoDTO> prestamos = presentador.HistorialPrestamos();
            prestamos.ForEach(prest =>
            {
                nombreLibro.Text += ("\n" + prest.Ejemplar().Libro().Nombre());
                codigoISBN.Text += ("\n" + prest.Ejemplar().Libro().CodigoISBN());
                numEdicion.Text += ("\n" + prest.Ejemplar().NumEdicion().ToString());
                idSocio.Text += ("\n" + prest.Socio().NumIdentificacion());
                fechaPrestamo.Text += ("\n" + prest.FechaPrestamo().ToString());
                estadoPrestamo.Text += ("\n" + (prest.EstaFinalizado() ? "Devuelto" : "Pendiente"));
            });
            InitializeComponent();
            
        }
        /*
        private void Historial_Enter(object sender, EventArgs e)
        {
            List<PrestamoDTO> prestamos = presentador.HistorialPrestamos();
            prestamos.ForEach(prest =>
            {
                nombreLibro.Text += "\n" + prest.Ejemplar().Libro().Nombre();
                codigoISBN.Text += "\n" + prest.Ejemplar().Libro().CodigoISBN();
                numEdicion.Text += "\n" + prest.Ejemplar().NumEdicion();
                idSocio.Text += "\n" + prest.Socio().NumIdentificacion();
                fechaPrestamo.Text += "\n" + prest.FechaPrestamo().ToString();
                estadoPrestamo.Text += "\n" + (prest.EstaFinalizado() ? "Devuelto" : "Pendiente");
            });
        }
        */
    }
}
