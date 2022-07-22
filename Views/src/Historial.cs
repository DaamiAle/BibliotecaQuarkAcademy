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
    }
}
