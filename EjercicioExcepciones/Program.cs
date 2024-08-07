namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("**************MENÚ***************");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.WriteLine("*********************************");
                
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 5)
                {
                    continuar = false;
                    continue;
                }
                
                Console.WriteLine("Ingrese el primer número:");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                double numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                try
                {
                    double resultado = 0;
                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(numero1, numero2);
                            break;
                        case 2:
                            resultado = operaciones.Restar(numero1, numero2);
                            break;
                        case 3:
                            resultado = operaciones.Multiplicar(numero1, numero2);
                            break;
                        case 4:
                            resultado = operaciones.Dividir(numero1, numero2);
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            continue;
                    }

                    Console.WriteLine($"El resultado es: {resultado}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Entrada no válida. Por favor, ingrese números válidos.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }
                Console.WriteLine();
            }
        }
    }
}