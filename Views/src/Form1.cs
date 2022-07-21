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
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string objetivo = "verificar posibilidad de prestamos";
            try 
            {
                MessageBox.Show("Exito al " + objetivo);
            }
            catch (Exception exception) 
            {
                MessageBox.Show($"Error: {exception.Message}");
            }
        }
    }
}
