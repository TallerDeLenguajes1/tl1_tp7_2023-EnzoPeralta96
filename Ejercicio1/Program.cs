﻿using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        bool CalculadoraEnUso = true , ResultadoTermino, ResultadoOperacion;
        string option,operando;
        double termino;
        int Operacion;

        Calculadora MiCalculadora = new Calculadora();
        
        Console.WriteLine("Calculadora ON");

        while (CalculadoraEnUso)
        {
            do
                {
                    Console.WriteLine("Ingrese la operacion que desea realizar:");
                    Console.WriteLine("-1:Suma\n-2:Resta\n-3:Producto\n-4:Cociente\n-5:Limpiar\n-6:Salir");
                    option = Console.ReadLine();
                } while (string.IsNullOrEmpty(option));

                if (ResultadoOperacion = int.TryParse(option, out Operacion) && 1<= Operacion && Operacion<=5)
                {
                    switch (Operacion)
                        {
                        case 1:
                            do
                            {
                                Console.WriteLine("Ingrese el operando:");
                                operando = Console.ReadLine();
                            } while (String.IsNullOrEmpty(operando));

                            ResultadoTermino = double.TryParse(operando,out termino);

                            if (ResultadoTermino)
                            {
                                MiCalculadora.Sumar(termino);
                            }else
                            {
                                Console.WriteLine("error al ingresar valor");
                            }
                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("Ingrese el operando:");
                                operando = Console.ReadLine();
                            } while (String.IsNullOrEmpty(operando));

                            ResultadoTermino = double.TryParse(operando,out termino);

                            if (ResultadoTermino)
                            {
                               MiCalculadora.Restar(termino);
                            }else
                            {
                                Console.WriteLine("Sintax error");
                            }
                            break;
                        case 3:
                            do
                            {
                                Console.WriteLine("Ingrese el operando:");
                                operando = Console.ReadLine();
                            } while (String.IsNullOrEmpty(operando));

                            ResultadoTermino = double.TryParse(operando,out termino);

                            if (ResultadoTermino)
                            {
                                MiCalculadora.Multiplicar(termino);
                            }else
                            {
                                Console.WriteLine("Sintax error");
                            }
                            break;
                        case 4:
                            do
                            {
                                Console.WriteLine("Ingrese el operando:");
                                operando = Console.ReadLine();
                            } while (String.IsNullOrEmpty(operando));

                            ResultadoTermino = double.TryParse(operando,out termino);

                            if (ResultadoTermino)
                            {
                                MiCalculadora.Dividir(termino);
                            }else
                            {
                                Console.WriteLine("Sintax error");
                            }
                            break;
                        case 5:
                            MiCalculadora.Limpiar();
                            break;
                        }
                        if (Operacion != 5)
                        {
                            Console.WriteLine("Resultado:"+MiCalculadora.Resultado+"\n");
                        }
                }else
                {
                     if (Operacion==6)
                        {
                            CalculadoraEnUso = false;
                            Console.WriteLine("Saliendo...");
                        }else
                        {
                            Console.WriteLine("Operacion incorrecta");
                        } 
                }
        }
        Console.WriteLine("Calculadora OFF");
    }
}