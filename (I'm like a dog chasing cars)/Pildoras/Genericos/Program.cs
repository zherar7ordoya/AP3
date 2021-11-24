using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);
            empleados.Agregar(new Director(4500));
            empleados.Agregar(new Director(1500));
            empleados.Agregar(new Director(2500));
        }
    }
    class AlmacenEmpleados<T> where T : IParaEmpleados
    {
        private int i = 0;
        private T[] datosEmpleado;
        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }
        public void Agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }
        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }
    }
    interface IParaEmpleados
    {
        double getSalario();
    }
    class Director : IParaEmpleados
    {
        private double salario;
        public Director(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }
    class Secretaria : IParaEmpleados
    {
        private double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }
    class Electricista : IParaEmpleados
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }
    class Estudiante
    {
        private double edad;
        public Estudiante(double edad)
        {
            this.edad = edad;
        }
        public double getEdad()
        {
            return edad;
        }
    }

    ///////////////////////////////////////////////////////////////////////////
    /*
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);
            
            //archivos.Agregar("Juan");
            //archivos.Agregar("Elena");
            //archivos.Agregar("Antonio");
            //archivos.Agregar("Sandra");
            
            archivos.Agregar(new DateTime(1500));
            archivos.Agregar(new DateTime(2500));
            archivos.Agregar(new DateTime(3500));
            archivos.Agregar(new DateTime(4500));
            
            DateTime fecha = archivos.getElemento(2);
            Console.WriteLine(fecha);
            ///////////////////////////////////////////////////////////////////
            Console.ReadLine();
        }
    }

    // USO DE LA SÚPER CLASE CÓSMICA
    class AlmacenObjetos<T>
    {
        private T[] datosElemento;
        private int i = 0;

        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }
        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public T getElemento(int i)
        {
            return datosElemento[i];
        }
    }
    class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }
    */
}
