using System.Collections;

namespace ArrayListActividad1
{
    class program
    {
        public static void Main(String[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };
            ArrayList provincias = new ArrayList()
            {
                "Almería", "Granada", "Málaga","Jaén","Córdoba", "Sevilla", "Cádiz", "Huelva"
            };

            provincias.Sort();
            provincias.Insert(0, numeros[0]);
            provincias.Insert(2, numeros[1]);
            provincias.Insert(4, numeros[2]);
            provincias.Insert(6, numeros[3]);
            provincias.Insert(8, numeros[4]);
            provincias.Insert(10, numeros[5]);
            provincias.Insert(12, numeros[6]);
            provincias.Insert(14, numeros[7]);



            //Recorredor del ArrayList
            for ( int i = 0; i < provincias.Count; i++)
            {
                Console.WriteLine(provincias[i]);
            }
        }
    }
}