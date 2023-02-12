using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            Cliente cliente = new Cliente();
            Inmueble inmueble = new Inmueble();

            empleado.nombre = "Juan";
            empleado.apellido = "Lopez";

            cliente.nombre = "Cristian";
            cliente.apellido = "Losano";

            inmueble.tipo = "Edificio";
            inmueble.altura = 16;
            inmueble.area = 35;

        }

        abstract class Persona
        {
            private string _nombre;
            private string _apellido;
            public string edad;
            public string nombre
            {
                get { return _nombre; }
                set { _nombre = nombre; }
            }
            public string apellido
            {
                get { return _apellido; }
                set { _apellido = apellido; }
            }

            abstract public string Saludar();
            abstract public string DecirNombre(string nombre, string apellido);
            public void Vender()
            {
                Console.WriteLine("Gracias por su compra vuelva pronto");
            }
        }

        class Empleado : Persona
        {
            public override string Saludar()
            {
                return ("Bienvenido a almacenes y más ¿En qué puedo ayudarle? ");
            }
            public override string DecirNombre(string nombre, string apellido)
            {
                return (nombre + apellido);
            }
        }

        class Cliente : Persona
        {
            private string _email;
            private int _tel;
            private string _contrato;
            public string contrato
            {
                get { return _contrato; }
                set { _contrato = contrato; }
            }
            public int tel
            {
                get { return _tel; }
                set { _tel = tel; }
            }
            public string email
            {
                get { return _email; }
                set { _email = email; }
            }

            public override string DecirNombre(string nombre, string apellido)
            {
                return (nombre + apellido);
            }
            public override string Saludar()
            {
                return ("Hola, necesito necesito un inmueble");
            }
            public void Comprar()
            {
                Console.WriteLine("Gracias");
            }
        }

        class Inmueble
        {
            public string tipo;
            public double altura;
            public double area;
        }
    }
}
