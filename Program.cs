using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesAula07
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota1;
            double nota2;
            double media;

            Console.WriteLine("Digite sua nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua nota:");
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;
            Console.WriteLine(" Sua média é" + media);
            if(media>6)
            {
                Console.WriteLine("Media superior a media minima 6 - APROVADO");

            }
            else
            {
                Console.WriteLine("Media igual a minima 6 - REPROVADO");
            }

            Console.ReadLine();







            
          

            
            
            
            
            
            
            







            void Atividade01()
            {


                int num;


                Console.WriteLine("Digite um numero:");
                numero = int.Parse(Console.ReadLine());
                if (numero > 100)
                {
                    numero = numero + 150;
                }

                Console.WriteLine($" O resultado é: {numero}");


                Console.ReadKey();




            }
        }
         void Atividade02()
        {
            string nome;
            double numero;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua média:");
            numero = double.Parse(Console.ReadLine());
            if (numero >= 6)
            {
                Console.WriteLine($"Você {nome} está aprovado");
            }
            else
            {
                Console.WriteLine($"Você {nome} está reprovado");
            }

            Console.ReadKey();
        }
    }








}
