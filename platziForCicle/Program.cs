//LOS CICLOS FOR EJECUTAN UNA INSTRUCCION O VARIAS, CADA VES QUE SE EJECUTA UN CICLO 
using System;

namespace platziForCicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0 /*CONDICION INICIAL*/; i <= 50/*LIMITE DE REPETICIONES*/; i = i + 2/*INCREMENTO*/)
            Console.WriteLine("Hello, World! #{0}" , i);
        }
    }
}