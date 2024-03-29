﻿namespace DataObjects.src
{
    public class SocioDTO
    {
        private string nombre;
        private string apellido;
        private int numIdentificacion;
        private bool esVIP;
        private int cuotaSocio;
        private List<PrestamoDTO> prestamos;

        public string Nombre() => nombre;
        public void Nombre(string value) => nombre = value;
        public string Apellido() => apellido;
        public void Apellido(string value) => apellido = value;
        public int NumIdentificacion() => numIdentificacion;
        public void NumIdentificacion(int value) => numIdentificacion = value;
        public bool EsVIP() => esVIP;
        public void EsVIP(bool value) => esVIP = value;
        public int CuotaSocio() => cuotaSocio;
        public void CuotaSocio(int value) => cuotaSocio = value;
        public List<PrestamoDTO> EjemplaresRetirados() => prestamos;
        public void EjemplaresRetirados(List<PrestamoDTO> value) => prestamos = value;
    }
}
