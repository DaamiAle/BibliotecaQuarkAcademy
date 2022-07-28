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

namespace Views.src.UI
{
    public partial class MainPage : Form
    {
        private readonly Presentador presentador;
        public MainPage()
        {
            presentador = new();
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            presentador.CrearDB();
        }



        #region Carga de pestañas
        private void socioRegister_Enter(object sender, EventArgs e)
        {
            Size = new(650,500);
        }
        private void libroRegister_Enter(object sender, EventArgs e)
        {
            Size = new(650, 500);
        }
        private void ejemplarSave_Enter(object sender, EventArgs e)
        {
            Size = new(650, 500);
        }
        private void prestamoRegister_Enter(object sender, EventArgs e)
        {
            Size = new(650, 500);
        }
        private void devolverEjemplar_Enter(object sender, EventArgs e)
        {
            Size = new(650, 500);
        }
        private void prestamoHistory_Enter(object sender, EventArgs e)
        {
            Size = new(1000, 500);
            CargarHistorial();
        }

        #endregion

        #region Verificacion de campos Socio
        private void nuevoSocioNombre_TextChanged(object sender, EventArgs e)
        {
            if (nuevoSocioNombre.Text != "" && nuevoSocioApellido.Text != "" && nuevoSocioIdentificacion.Text != "" && nuevoSocioCuota.Text != "")
            {
                buttonRegisterSocio.Enabled = true;
            }
            else
            {
                buttonRegisterSocio.Enabled = false;
            }
        }
        private void nuevoSocioApellido_TextChanged(object sender, EventArgs e)
        {
            if (nuevoSocioNombre.Text != "" && nuevoSocioApellido.Text != "" && nuevoSocioIdentificacion.Text != "" && nuevoSocioCuota.Text != "")
            {
                buttonRegisterSocio.Enabled = true;
            }
            else
            {
                buttonRegisterSocio.Enabled = false;
            }
        }
        private void nuevoSocioIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (nuevoSocioNombre.Text != "" && nuevoSocioApellido.Text != "" && nuevoSocioIdentificacion.Text != "" && nuevoSocioCuota.Text != "")
            {
                buttonRegisterSocio.Enabled = true;
            }
            else
            {
                buttonRegisterSocio.Enabled = false;
            }
        }
        private void nuevoSocioCuota_TextChanged(object sender, EventArgs e)
        {
            if (nuevoSocioNombre.Text != "" && nuevoSocioApellido.Text != "" && nuevoSocioIdentificacion.Text != "" && nuevoSocioCuota.Text != "")
            {
                buttonRegisterSocio.Enabled = true;
            }
            else
            {
                buttonRegisterSocio.Enabled = false;
            }
        }

        #endregion
        private void buttonRegisterSocio_Click(object sender, EventArgs e)
        {
            presentador.RegistrarSocio(nuevoSocioNombre.Text, nuevoSocioApellido.Text, nuevoSocioIdentificacion.Text, nuevoSocioVIP.Checked, nuevoSocioCuota.Text);
        }


        #region Verificacion de campos Libro
        private void libroNuevoNombre_TextChanged(object sender, EventArgs e)
        {
            if (libroNuevoNombre.Text != "" && libroNuevoAutor.Text != "" && libroNuevoCodigoISBN.Text != "")
            {
                buttonRegisterLibro.Enabled = true;
            }
            else
            {
                buttonRegisterLibro.Enabled = false;
            }
        }
        private void libroNuevoAutor_TextChanged(object sender, EventArgs e)
        {
            if (libroNuevoNombre.Text != "" && libroNuevoAutor.Text != "" && libroNuevoCodigoISBN.Text != "")
            {
                buttonRegisterLibro.Enabled = true;
            }
            else
            {
                buttonRegisterLibro.Enabled = false;
            }
        }
        private void libroNuevoCodigoISBN_TextChanged(object sender, EventArgs e)
        {
            if (libroNuevoNombre.Text != "" && libroNuevoAutor.Text != "" && libroNuevoCodigoISBN.Text != "")
            {
                buttonRegisterLibro.Enabled = true;
            }
            else
            {
                buttonRegisterLibro.Enabled = false;
            }
        }

        #endregion
        private void buttonRegisterLibro_Click(object sender, EventArgs e)
        {
            presentador.RegistrarLibro(libroNuevoNombre.Text, libroNuevoAutor.Text, libroNuevoCodigoISBN.Text);
        }

        
        #region Verificacion de campos Ejemplar
        private void ejemplarNuevoNombreLibro_TextChanged(object sender, EventArgs e)
        {
            if ((ejemplarNuevoNombreLibro.Text != "" || ejemplarNuevoCodigoISBN.Text != "") && ejemplarNuevoNumero.Text != "" && ejemplarNuevoUbicacion.Text != "")
            {
                buttonSaveEjemplarButton.Enabled = true;
            }
            else
            {
                buttonSaveEjemplarButton.Enabled = false;
            }

        }
        private void ejemplarNuevoCodigoISBN_TextChanged(object sender, EventArgs e)
        {
            if ((ejemplarNuevoNombreLibro.Text != "" || ejemplarNuevoCodigoISBN.Text != "") && ejemplarNuevoNumero.Text != "" && ejemplarNuevoUbicacion.Text != "")
            {
                buttonSaveEjemplarButton.Enabled = true;
            }
            else
            {
                buttonSaveEjemplarButton.Enabled = false;
            }
        }
        private void ejemplarNuevoNumero_TextChanged(object sender, EventArgs e)
        {
            if ((ejemplarNuevoNombreLibro.Text != "" || ejemplarNuevoCodigoISBN.Text != "") && ejemplarNuevoNumero.Text != "" && ejemplarNuevoUbicacion.Text != "")
            {
                buttonSaveEjemplarButton.Enabled = true;
            }
            else
            {
                buttonSaveEjemplarButton.Enabled = false;
            }
        }
        private void ejemplarNuevoUbicacion_TextChanged(object sender, EventArgs e)
        {
            if ((ejemplarNuevoNombreLibro.Text != "" || ejemplarNuevoCodigoISBN.Text != "") && ejemplarNuevoNumero.Text != "" && ejemplarNuevoUbicacion.Text != "")
            {
                buttonSaveEjemplarButton.Enabled = true;
            }
            else
            {
                buttonSaveEjemplarButton.Enabled = false;
            }
        }

        #endregion
        private void buttonSaveEjemplarButton_Click(object sender, EventArgs e)
        {
            string codigoISBN = ejemplarNuevoCodigoISBN.Text == "" ? null : ejemplarNuevoCodigoISBN.Text;
            string nombreLibro = ejemplarNuevoNombreLibro.Text == "" ? null : ejemplarNuevoNombreLibro.Text;
            presentador.RegistrarEjemplar(ejemplarNuevoNumero.Text, ejemplarNuevoUbicacion.Text, codigoISBN, nombreLibro);
        }


        #region Verificacion de campos Prestamo
        private void prestamoNuevoSocioDNI_TextChanged(object sender, EventArgs e)
        {
            if (prestamoNuevoSocioDNI.Text != "" && prestamoNuevoNumEjemplar.Text != "" && (prestamoNuevoCodigoISBN.Text != "" || prestamoNuevoNombreLibro.Text!= ""))
            {
                buttonRegisterPrestamo.Enabled = true;
            }
            else
            {
                buttonRegisterPrestamo.Enabled = false;
            }
        }
        private void prestamoNuevoCodigoISBN_TextChanged(object sender, EventArgs e)
        {
            if (prestamoNuevoSocioDNI.Text != "" && prestamoNuevoNumEjemplar.Text != "" && (prestamoNuevoCodigoISBN.Text != "" || prestamoNuevoNombreLibro.Text != ""))
            {
                buttonRegisterPrestamo.Enabled = true;
            }
            else
            {
                buttonRegisterPrestamo.Enabled = false;
            }
            if (prestamoNuevoCodigoISBN.Text != "" || prestamoNuevoNombreLibro.Text != "")
            {
                buttonVerificadorEjemplares.Enabled = true;
            }
            else
            {
                buttonVerificadorEjemplares.Enabled = false;
            }

        }
        private void prestamoNuevoNombreLibro_TextChanged(object sender, EventArgs e)
        {
            if (prestamoNuevoSocioDNI.Text != "" && prestamoNuevoNumEjemplar.Text != "" && (prestamoNuevoCodigoISBN.Text != "" || prestamoNuevoNombreLibro.Text != ""))
            {
                buttonRegisterPrestamo.Enabled = true;
            }
            else
            {
                buttonRegisterPrestamo.Enabled = false;
            }
            if (prestamoNuevoCodigoISBN.Text != "" || prestamoNuevoNombreLibro.Text != "")
            {
                buttonVerificadorEjemplares.Enabled = true;
            }
            else
            {
                buttonVerificadorEjemplares.Enabled = false;
            }
        }
        private void prestamoNuevoNumEjemplar_TextChanged(object sender, EventArgs e)
        {
            if (prestamoNuevoSocioDNI.Text != "" && prestamoNuevoNumEjemplar.Text != "" && (prestamoNuevoCodigoISBN.Text != "" || prestamoNuevoNombreLibro.Text != ""))
            {
                buttonRegisterPrestamo.Enabled = true;
            }
            else
            {
                buttonRegisterPrestamo.Enabled = false;
            }
        }


        #endregion
        private void buttonRegisterPrestamo_Click(object sender, EventArgs e)
        {
            string codigoISBN = prestamoNuevoCodigoISBN.Text == "" ? null : prestamoNuevoCodigoISBN.Text;
            string nombreLibro = prestamoNuevoNombreLibro.Text == "" ? null : prestamoNuevoNombreLibro.Text;
            presentador.RegistrarPrestamo(prestamoNuevoSocioDNI.Text, codigoISBN, nombreLibro, prestamoNuevoNumEjemplar.Text);
        }
        private void buttonVerificadorEjemplares_Click(object sender, EventArgs e)
        {
            string codigoISBN = prestamoNuevoCodigoISBN.Text == "" ? null : prestamoNuevoCodigoISBN.Text;
            string nombreLibro = prestamoNuevoNombreLibro.Text == "" ? null : prestamoNuevoNombreLibro.Text;
            presentador.VerificarDisponibilidadDeEjemplares(nombreLibro, codigoISBN);
        }


        #region Verificacion de campos Devolucion
        private void devolucionSocioDNI_TextChanged(object sender, EventArgs e)
        {
            if (devolucionSocioDNI.Text != "" && devolucionNumEjemplar.Text != "" && (devolucionCodigoISBN.Text != "" || devolucionNombreLibro.Text != ""))
            {
                buttonRegisterDevolucion.Enabled = true;
            }
            else
            {
                buttonRegisterDevolucion.Enabled = false;
            }
        }
        private void devolucionNumEjemplar_TextChanged(object sender, EventArgs e)
        {
            if (devolucionSocioDNI.Text != "" && devolucionNumEjemplar.Text != "" && (devolucionCodigoISBN.Text != "" || devolucionNombreLibro.Text != ""))
            {
                buttonRegisterDevolucion.Enabled = true;
            }
            else
            {
                buttonRegisterDevolucion.Enabled = false;
            }
        }
        private void devolucionCodigoISBN_TextChanged(object sender, EventArgs e)
        {
            if (devolucionSocioDNI.Text != "" && devolucionNumEjemplar.Text != "" && (devolucionCodigoISBN.Text != "" || devolucionNombreLibro.Text != ""))
            {
                buttonRegisterDevolucion.Enabled = true;
            }
            else
            {
                buttonRegisterDevolucion.Enabled = false;
            }
        }
        private void devolucionNombreLibro_TextChanged(object sender, EventArgs e)
        {
            if (devolucionSocioDNI.Text != "" && devolucionNumEjemplar.Text != "" && (devolucionCodigoISBN.Text != "" || devolucionNombreLibro.Text != ""))
            {
                buttonRegisterDevolucion.Enabled = true;
            }
            else
            {
                buttonRegisterDevolucion.Enabled = false;
            }
        }

        #endregion
        private void buttonRegisterDevolucion_Click(object sender, EventArgs e)
        {
            string codigoISBN = devolucionCodigoISBN.Text == "" ? null : devolucionCodigoISBN.Text;
            string nombreLibro = devolucionNombreLibro.Text == "" ? null : devolucionNombreLibro.Text;
            presentador.RegistrarDevolucion(devolucionSocioDNI.Text, codigoISBN, nombreLibro,devolucionNumEjemplar.Text);
        }





        private void CargarHistorial()
        {
            listView1.Items.Clear();

            List<PrestamoDTO> prestamos = presentador.ObtenerPrestamos();
            for (int i = 0; i < prestamos.Count; i++)
            {
                ListViewItem item = new();
                item.Text = prestamos[i].Ejemplar().Libro().Nombre();
                item.SubItems.Add(prestamos[i].Ejemplar().Libro().CodigoISBN());
                item.SubItems.Add(prestamos[i].Ejemplar().NumEdicion().ToString());
                item.SubItems.Add($"{prestamos[i].Socio().Nombre()} {prestamos[i].Socio().Apellido()} - DNI:{prestamos[i].Socio().NumIdentificacion()}");
                item.SubItems.Add(prestamos[i].FechaPrestamo().ToString());
                item.SubItems.Add(prestamos[i].EstaFinalizado() ? "Devuelto" : "Pendiente");
                listView1.Items.Add(item);
            }

        }


    }
}
