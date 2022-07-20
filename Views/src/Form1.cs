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

    }
}
