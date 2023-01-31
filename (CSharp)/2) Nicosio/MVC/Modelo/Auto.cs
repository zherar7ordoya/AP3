﻿namespace MVC.Modelo
{
    public class Auto
    {
        private string nombre;
        private int modelo;
        private double costo;

        public Auto(string nombre,
                    int modelo,
                    double costo)
        {
            this.Nombre = nombre;
            this.Modelo = modelo;
            this.Costo = costo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}