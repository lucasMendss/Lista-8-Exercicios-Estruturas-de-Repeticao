using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista___Estruturas_de_Repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            void Exercicio1()
            {
                /* Fazer um programa que leia as notas P1 e P2 de 5 alunos, a cada leitura exibir a média
                do aluno e ao final, exibir a média geral dos alunos. */

                double mediaUnica = 0, mediaGeral = 0, notaAtual = 0, notasSomadas = 0;

                for (int indcAluno = 1; indcAluno <= 5; indcAluno++)
                {
                    mediaUnica = 0;
                    notasSomadas = 0;
                    for (int indcNota = 1; indcNota <=2; indcNota ++)
                    {
                        bool converteuParaDouble = false;

                        while (!converteuParaDouble)
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Digite a {0}ª nota do aluno {1}:", indcNota, indcAluno);
                            converteuParaDouble = double.TryParse(Console.ReadLine(), out notaAtual);

                            if (!converteuParaDouble || notaAtual < 0 || notaAtual > 10)
                            {
                                Console.WriteLine("A nota deve estar entre 0 e 10.");
                                converteuParaDouble = false;
                            }
                        }
                        notasSomadas = notasSomadas + notaAtual; 
                    }
                    mediaUnica = (notasSomadas / 2);
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("A média do aluno {0} é {1}", indcAluno, mediaUnica);
                    mediaGeral = mediaGeral + mediaUnica;
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("A nota média geral dos alunos é {0}.", (mediaGeral / 5));
            }

            void Exercicio2 ()
            {
                /* Fazer um programa que leia as notas P1 e P2 de “n” alunos, a cada leitura exibir a
                média do aluno e perguntar se irá ler as notas de novo aluno. Ao final, exibir a média
                dos alunos.*/

                double mediaUnica = 0, mediaGeral = 0, notaAtual = 0, notasSomadas = 0;
                int indcALuno = 0;
                string repetir = "s";

                do
                {
                    indcALuno++;
                    notasSomadas = 0;
                    for (int indcNota = 1; indcNota <= 2; indcNota++)
                    {
                        bool converteuParaDouble = false;

                        while (!converteuParaDouble)
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Digite a {0}ª nota do aluno {1}:", indcNota, indcALuno);
                            converteuParaDouble = double.TryParse(Console.ReadLine(), out notaAtual);

                            if (!converteuParaDouble || notaAtual < 0 || notaAtual > 10)
                            {
                                Console.WriteLine("A nota deve estar entre 0 e 10.");
                                converteuParaDouble = false;
                            }
                        }
                        notasSomadas = notasSomadas + notaAtual;
                    }
                    mediaUnica = (notasSomadas / 2);
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("A média do aluno {0} é {1}", indcALuno, mediaUnica);
                    mediaGeral = mediaGeral + mediaUnica;

                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Deseja inserir notas de um novo aluno(s/n)?");
                    repetir = Console.ReadLine().ToLower();
                }
                while (repetir == "s");

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("A nota média geral dos {0} alunos é {1}.", indcALuno, (mediaGeral / indcALuno));
            }

            void Exercicio3 ()
            {
                /* Escreva um programa que receba a idade de 10 pessoas, calcule e exiba a quantidade
                de pessoas maiores de idade */

                int qtdeMaiores = 0, idadeAtual = 0;
               
                for (int ii = 1; ii <= 10; ii++)
                {
                    bool converteuParaInt = false;
                    while (!converteuParaInt)
                    {
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Digite a {0}ª idade: ", ii);
                        converteuParaInt = int.TryParse(Console.ReadLine(), out idadeAtual);

                        if (!converteuParaInt|| idadeAtual < 0)
                        {
                            Console.WriteLine("Idade inválida.");
                            converteuParaInt = false;
                        }
                    }

                    if (idadeAtual >= 18)
                    {
                        qtdeMaiores++;
                    }
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Nesse grupo há {0} pessoas maiores de idade.", qtdeMaiores);
            }

            void Exercicio4()
            {
                /* Fazer um programa que imprima os números pares existentes no intervalo de 0 a 100. */

                for (int ii = 2; ii <= 100; ii += 2)
                {
                    Console.WriteLine(ii);
                }
                Console.WriteLine("");
            }

            void Exercicio5()
            {
                /* As faixas etárias são: 1 até 15 anos, 16 até 30 anos, 31 até 45 anos, 46 até 60 anos,
                acima de 60 anos. */
                int idadeAtual = 0, qtdefx1 = 0, qtdefx2 = 0, qtdefx3 = 0, qtdefx4 = 0, qtdefx5 = 0;
                for (int ii = 1; ii <= 15; ii++)
                {
                    bool converteuParaInt = false;
                    while (!converteuParaInt)
                    {
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Digite a {0}ª idade: ", ii);
                        converteuParaInt = int.TryParse(Console.ReadLine(), out idadeAtual);

                        if (!converteuParaInt || idadeAtual < 0)
                        {
                            Console.WriteLine("Idade inválida.");
                            converteuParaInt = false;
                        }
                    }

                    if (idadeAtual > 0 && idadeAtual <= 15) qtdefx1++;
                    else if (idadeAtual > 16 && idadeAtual <= 30) qtdefx2++;
                    else if (idadeAtual > 30 && idadeAtual <= 45) qtdefx3++;
                    else if (idadeAtual > 45 && idadeAtual <= 60) qtdefx4++;
                    else qtdefx5++;
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Dados: ");
                Console.WriteLine("-- Integrantes da faixa etária 1 (1 a 15 anos): {0} pessoas ({1}%) ", qtdefx1, (qtdefx1 * 100)/15);
                Console.WriteLine("-- Integrantes da faixa etária 2 (16 a 30 anos): {0} pessoas ({1}%) ", qtdefx2, (qtdefx2 * 100) / 15);
                Console.WriteLine("-- Integrantes da faixa etária 3 (31 a 45 anos): {0} pessoas ({1}%) ", qtdefx3, (qtdefx3 * 100) / 15);
                Console.WriteLine("-- Integrantes da faixa etária 4 (46 a 60 anos): {0} pessoas ({1}%) ", qtdefx4, (qtdefx4 * 100) / 15);
                Console.WriteLine("-- Integrantes da faixa etária 5 (acima de 60 anos): {0} pessoas ({1}%) ", qtdefx5, (qtdefx5 * 100) / 15);
            }

            void Exercicio8()
            {
                int a = 1, b = 0, soma = 0;

                Console.WriteLine("Sequência de Fibonacci até o 30º valor:");
                for (int ii = 1; ii <= 30; ii++)
                {
                    soma = a + b;
                    b = a;
                    a = soma;
                    Console.WriteLine(soma); 
                        
                }
            }
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            Exercicio8();
        }
    }
}
