using System;
using System.Collections.Generic;
using System.Text;

namespace practica2JoseMeroQ
{
    public class EspecialistaRH
    {
        public string nombre { get; set; }

        public List <Aplicacion> aplicacions { get; set; }

        public EspecialistaRH (string nombre)
        {
            this.nombre = nombre;
            aplicacions = new ();
        }

        public void ListaAplicacion()
        {
            if(aplicacions.Any())
            {
                foreach(var app in aplicacions)
                {
                    Console.WriteLine($"Hola, { nombre}! {app.NombreAplicacion} acaba de solicitar el trabajo no. {app.IdJob}");
                }
            }else {
                Console.WriteLine($"Hola, {nombre}! Aun no hay aplicaciones");
                }
            }
        }
}
