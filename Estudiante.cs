using System;
using System.Collections.Generic;
using System.Text;

namespace Evidencia._Estudiantes
{
    class Estudiante
    {
        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public int Nota1 { get; set; }

        public int Nota2 { get; set; }

        public int Nota3 { get; set; }


        public int TotalN(List<int> sumaNotas)

        {
            int suma = 0;

            foreach (int SumaNota in sumaNotas)

            {
                suma = suma + SumaNota;
            }

            return suma;

        }
        public double PromedioN(int TotalN)

        {
            double Pro = TotalN / 100;
            return Pro;


        }



    }



}
