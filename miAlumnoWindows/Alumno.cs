using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miAlumnoWindows
{
    class Alumno
    {   
        //iniciar los atributos
        private int legajo, documento;
        private string nombre;
        private double nota1, nota2;

        //sets y gets
        public int pLegajo
        {
            set { legajo = value; }
            get { return legajo; }
        }
        public int pDocumento
        {
            set { documento = value; }
            get { return documento; }
        }
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public double pNota1
        {
            set { nota1 = value; }
            get { return nota1; }
        }
        public double pNota2
        {
            set { nota2 = value; }
            get { return nota2; }
        }

        // Constructor Null, que pone en 0 por defecto los valores.
        public Alumno()
        { 
            legajo=documento=0;
            nombre="";
            nota1 = nota2 = 0;
        }
        //este metodo es para calcular el promedio
        public double calcularPromedio()
        { 
            return (nota1 + nota2) / 2; 
        }
        public string toString()
        {
            return legajo + nombre + documento + nota1 + nota2 + calcularPromedio();
        }  
        //Este ToString Lo Usamos Despues en el Message Box
    }
}
