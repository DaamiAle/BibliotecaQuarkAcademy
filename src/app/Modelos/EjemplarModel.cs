﻿
namespace BibliotecaQuarkAcademy.src.app.Modelos
{
    public class EjemplarModel
    {
        // Propiedades
        public int Id { get; set; }
        public LibroModel Libro { get; set; }
        public int NumEdicion { get; set; }
        public string Ubicacion { get; set; }
    }
}
