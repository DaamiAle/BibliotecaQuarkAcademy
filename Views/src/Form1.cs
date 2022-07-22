using DataObjects.src;

namespace Views.src
{
    public partial class Form1 : Form
    {
        private readonly Presentador presentador;
        public Form1()
        {
            presentador = new();
            presentador.CrearDB();
            presentador.PoblarDB();
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            presentador.PrestamosSocioComun();
            presentador.PrestamosSocioVIP();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new Historial(presentador).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<EjemplarDTO> ejemplares = presentador.EjemplaresDisponiblesDe("aventura001");
            string resultado = "";
            ejemplares.ForEach(it =>
            {
                resultado += "Nombre: " + it.Libro().Nombre().ToString() + " -- Edicion: " + it.NumEdicion().ToString() + "\n";
            });
            MessageBox.Show(resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<EjemplarDTO> ejemplares = presentador.EjemplaresDisponiblesDe("drama001");
            string resultado = "";
            ejemplares.ForEach(it =>
            {
                resultado += "Nombre: " + it.Libro().Nombre().ToString() + " -- Edicion: " + it.NumEdicion().ToString() + "\n";
            });
            MessageBox.Show(resultado);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            presentador.PrestarEjemplar("drama001",3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            presentador.PrestarEjemplar("drama001", 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            presentador.AgregarLibroConValoresInvalidos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            presentador.DevolverUnEjemplarCualquieraDeUnSocioCualquiera();
        }
    }
}
