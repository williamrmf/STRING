﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            Console.WriteLine("");
            TextReader reader1 = new StreamReader("nomes_telefones.txt");//chamada do arquivo.txt
            String l1 = reader1.ReadLine();
            while (l1 != null)
            {
                Console.WriteLine(l1.Substring(l1.IndexOf('(')).Replace("(", "").Replace(")", "").Replace("-", ""));
                l1 = reader1.ReadLine();
            }
            Console.WriteLine("");
            //Exercício 2
            TextReader texto = new StreamReader("nomes_telefones.txt"); 
            String linha = texto.ReadLine();

            while (linha != null)
            {   
                Console.WriteLine(linha);
                linha = texto.ReadLine();   
            }
            //Exercício 3
            Console.ReadKey(); ///break na tela 
            Console.WriteLine("");
            TextReader reader3 = new StreamReader("datas.txt");
            String l3 = reader3.ReadLine();
            while (l3 != null)
            {
                Console.WriteLine(l3.Substring(6, 4));
                l3 = reader3.ReadLine();
            }
            Console.WriteLine("");
            //Exercício 4
            Console.WriteLine("Exercício 4");
            Console.WriteLine("");
            TextReader reader4 = new StreamReader("marcas_carros.txt");
            String l4 = reader4.ReadLine();
            while (l4 != null)
            {
                Console.WriteLine(l4.Substring(0, l4.IndexOf('@')));
                l4 = reader4.ReadLine();
            }
            Console.WriteLine("");
            //Exercício 5
            Console.WriteLine("Exercício 5");
            Console.WriteLine("");
            TextReader reader5 = new StreamReader("produtos_estoque.txt");
            String l5 = reader5.ReadLine();
            Double valorTotal = 0.00;
            int estoqueTotal = 0;
            while (l5 != null)
            {
                valorTotal += Convert.ToDouble(l5.Substring(l5.IndexOf('$') + 1, 5).Replace(".", ","));
                estoqueTotal += Convert.ToInt32(l5.Substring(l5.IndexOf('|') + 1));
                l5 = reader5.ReadLine();
            }
            Console.WriteLine("Valor Total: " + valorTotal);
            Console.WriteLine("Estoque Total: " + estoqueTotal);

            Console.ReadKey();
        }
    }
}
