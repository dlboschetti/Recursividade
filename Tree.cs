using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Recursividade
{
    class Tree
    {
        public int QtdeNumeros;
        public int Qtdeniveis;

        public int[] Numeros;
        public int Nivel;


        public Tree()
        {

            Console.WriteLine("Digite a quantidade de níveis:");
            Qtdeniveis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de numeros:");
            QtdeNumeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------");

            Numeros = new int[Qtdeniveis];
            Nivel = 0;

            for (int i = 1; i <= QtdeNumeros; i++)
            {
                Numeros[Nivel] = i;
                Imprimir();
            

                if (Qtdeniveis > Nivel + 1)
                    Add();
            }
        }

        public void Add()
        {
            Nivel++;    
            for (int i = 1; i <= QtdeNumeros; i++)
            {
                Numeros[Nivel] = i;
                Imprimir();
            

                if (Qtdeniveis > Nivel + 1)
                    Add();
            }
            Numeros[Nivel] = 0;
            Nivel--;
        }


        public void Imprimir()
        {
            string imprimir = "";
            for (int i = 0; i <  Numeros.Length; i++)
            {
                if (i == 0)
                    imprimir += Numeros[i].ToString();
                else
                    if (Numeros[i] != 0)
                    imprimir += $".{Numeros[i]}";
            }           

            Console.WriteLine(imprimir);
        }

    }
}
