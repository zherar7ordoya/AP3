using static System.Console;
using System.Collections.Generic;
using System;

namespace DelegadosPredicadosLambdas
{
    partial class Program
    {
        // Definición del Objeto Delegado
        delegate void ObjetoDelegado(string msj);
        public delegate int OperacionesMatematicas1(int numero);
        public delegate int OperacionesMatematicas2(int num1, int num2);
        public delegate bool ComparaEdad(int edad1, int edad2);
        public delegate bool ComparaNombre(string nombre1, string nombre2);
        static void Main(string[] args)
        {
            #region ///////////////////////////////////////////////// DELEGADOS
            ObjetoDelegado delegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            delegado("Welcome Gerardo!");
            delegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            delegado("Farewell Gerardo!");
            #endregion

            #region //////////////////////////////////////////////// PREDICADOS

            // *---------------------------------------------------=> EJEMPLO 1
            List<int> lista = new List<int>();
            lista.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // Declaración de Delegado Predicado
            Predicate<int> predicado1 = new Predicate<int>(DamePares);

            List<int> pares = lista.FindAll(predicado1);
            foreach(int num in pares)
            {
                Write($"{ num } ");
            }
            Write(Environment.NewLine);

            // *---------------------------------------------------=> EJEMPLO 2
            List<Persona> gente = new List<Persona>();

            Persona persona1 = new Persona();
            persona1.Nombre = "Juan";
            persona1.Edad = 15;

            Persona persona2 = new Persona();
            persona2.Nombre = "María";
            persona2.Edad = 15;

            Persona persona3 = new Persona();
            persona3.Nombre = "Ana";
            persona3.Edad = 17;

            gente.AddRange(new Persona[] { persona1, persona2, persona3 });

            Predicate<Persona> predicado2 = new Predicate<Persona>(ExisteJuan);
            bool existe1 = gente.Exists(predicado2);
            if (existe1) WriteLine("Hay Juanes");
            else WriteLine("Nada...");

            Predicate<Persona> predicado3 = new Predicate<Persona>(ExistenMayores);
            bool existe2 = gente.Exists(predicado3);
            if (existe2) WriteLine("Hay algún mayor");
            else WriteLine("Son todos menores!");
            #endregion

            #region /////////////////////////////////////////////////// LAMBDAS

            // *---------------------------------------------------=> EJEMPLO 1
            OperacionesMatematicas1 operaciones1 = new OperacionesMatematicas1(Cuadrado);
            OperacionesMatematicas1 operaciones2 = new OperacionesMatematicas1(num => num * num);

            WriteLine(operaciones1(4));
            WriteLine(operaciones2(4));

            // *---------------------------------------------------=> EJEMPLO 2
            OperacionesMatematicas2 operaciones3 = new OperacionesMatematicas2(Suma);
            OperacionesMatematicas2 operaciones4 = new OperacionesMatematicas2((x, y) => x + y);

            WriteLine(operaciones3(4, 7));
            WriteLine(operaciones4(4, 7));

            // *---------------------------------------------------=> EJEMPLO 3
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> soloPares = numeros.FindAll(i => i % 2 == 0);
            foreach(int x in soloPares)
            {
                Write($"{ x }  ");
            }

            Write(Environment.NewLine);
            soloPares.ForEach(numero => Write($"{ numero }  "));

            Write(Environment.NewLine);
            soloPares.ForEach(numero => 
            {
                Write("Número: ");
                WriteLine(numero);
            });

            // *---------------------------------------------------=> EJEMPLO 4
            ComparaEdad edadComparada = (p1, p2) => p1 == p2;
            ComparaNombre nombreComparado = (p1, p2) => p1 == p2;
            WriteLine(edadComparada(persona1.Edad, persona2.Edad));
            WriteLine(nombreComparado(persona1.Nombre, persona2.Nombre));
            #endregion

            ReadKey();
        }
    }
}
