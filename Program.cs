using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadodolivro
{
    class Program
    {
        static void Main(string[] args)
        {
            void atividade()
            {

                double nota;

                string nome;

                Console.WriteLine($"Nome do aluno:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a nota do aluno:");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 6)
                {

                    Console.WriteLine("Aluno aprovado");

                }
                else
                {

                    Console.WriteLine("Aluno reprovado de ano! Estude um pouco mais.");
                }


                Console.ReadKey();



            }

            

            void atividade77()
            {
                int numero;

                Console.WriteLine("Digite um número maior que 100:");
                numero = int.Parse(Console.ReadLine());

                if (numero > 100)
                {
                    numero = numero + 150;
                }


                Console.WriteLine("Resultado da soma:" + numero);



                Console.ReadKey();
            }



        }

        void atividade()
        {

            int nota1;
            int nota2;
            int media;

            Console.WriteLine("Digite a segunda nota do aluno:");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno:");
            nota2 = int.Parse(Console.ReadLine());



            if (media > 6)
            {
                Console.WriteLine("Parabéns, você passou de ano!!!");

            }
            else
            {
                Console.WriteLine("Você reprovou de ano");

            }

            if (media = 6)

                Console.WriteLine("A média esta ");

            
            else 
            
            Console.ReadKey();




        }
    }

    void atividade()
    {

        double numero;
        Console.WriteLine("Digite um número: ");
        numero = double.Parse(Console.ReadLine());

        if (numero > 10)
        {
            numero = numero * 0.1;
        }

        Console.WriteLine("O resultado é:" + numero);


        Console.ReadKey();




    }
}
