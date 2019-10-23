using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Avaliativa_PA
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double cpf, sal1, sal2, sal3, sal4, sal5, sal6, media, valorretido;
            
            Console.WriteLine("Por favor digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("{0} Por favor digite seu CPF", nome);
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Ola senhor por favor digite o valor recebido no primeiro salario");
            sal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ola senhor por favor digite o valor recebido no segundo salario");
            sal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ola senhor por favor digite o valor recebido no terceiro salario");
            sal3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ola senhor por favor digite o valor recebido no quarto salario");
            sal4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ola senhor por favor digite o valor recebido no quinto salario");
            sal5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ola senhor por favor digite o valor recebido no sexto salario");
            sal6 = double.Parse(Console.ReadLine());
            media = (sal1 + sal2 + sal3 + sal4 + sal5 + sal6) / 6;

            if (media < 951.99)
            {
                Console.WriteLine("isento");
            }
            else if (media <= 1413.32) 
            {
                valorretido = (media * 0.075) - 71.4;
                Console.WriteLine("{0} o valor retido foi igual a {1} reais", nome, valorretido );
            }
             else if (media <= 1875.52)
            {
                valorretido = (media * 0.15) - 177.4;
                Console.WriteLine("{0} o valor retido foi igual a {1} reais", nome, valorretido);
            }
            else if (media <= 2332.34)
            {
                valorretido = (media * 0.225) - 318.06;
                Console.WriteLine("{0} o valor retido foi igual a {1} reais", nome, valorretido);
            }
            else if (media <= 2332.35)
            {
                valorretido = (media * 0.275) - 434.68;
                Console.WriteLine("{0} o valor retido foi igual a {1} reais", nome, valorretido);
            }
            Console.ReadKey();
            
          
          
   

        }
    }
}
