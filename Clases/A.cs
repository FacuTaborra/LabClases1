using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {
        private string NombreInstancia;

        public A(){
            NombreInstancia = "Instancia sin nombre";
        }

        public A(String nombre){
            NombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("El metodo M1 fue invocado");
        }
        public void M2()
        {
            Console.WriteLine("El metodo M2 fue invocado");
        }
        public void M3()
        {
            Console.WriteLine("El metodo M3 fue invocado");
        }
    }
}
