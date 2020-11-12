using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# é uma linguagem case sensitive ->
            //string nomeCompleto; //Declaramos a variavel tipo string

            //exibe o primeiro nome
            //nomeCompleto = "Joyce Santos Silva";
            //Console.WriteLine(nomeCompleto);

            //exibe o segundo nome

            //nomeCompleto = "Naely";
            //Console.WriteLine(nomeCompleto);

            //Declarar as variaveis
            float nota1, nota2, nota3, media;
            string nomeCompleto;
            
            //Entrada de dados
            Console.Write("Digite o nome do aluno: ");
            nomeCompleto = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //Processamento
            media = (nota1+nota2+nota3)/3;

            //Exibir o resultado
            if(media>5){  
                    //valor verdadeiro
                    Console.WriteLine("O Aluno "+nomeCompleto+" esta aprovado com a media de: "+media);
                    }else{ 
                    //valor falso
                    Console.WriteLine("O Aluno "+nomeCompleto+" está Reprovado com a media de: "+media);
                }
        }
    }
}
