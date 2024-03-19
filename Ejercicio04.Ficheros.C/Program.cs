namespace Ejercicio04.Ficheros.C
{

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string rutaFichero = "C:\\Users\\dmelnez\\Desktop\\ActividadEjercicioC.txt";


                Console.WriteLine("NUMERO DE LINEA: ");
                int numeroLinea = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("POSICION A MODIFICAR: ");
                int posicion = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("TEXTO A REEMPLAZAR: ");
                string textoAReemplazar = Console.ReadLine();


                string[] lineasArchivo = File.ReadAllLines(rutaFichero);


                   string nuevaLinea =  lineasArchivo[numeroLinea - 1].Insert(posicion, textoAReemplazar);

                lineasArchivo[numeroLinea -1] = nuevaLinea;

                File.WriteAllLines(rutaFichero, lineasArchivo);


            }

            catch (Exception ex)
            {

                Console.WriteLine("[INFO] -> SE HA PODUCIDO UN ERRO");

            }

        }
    }

}


