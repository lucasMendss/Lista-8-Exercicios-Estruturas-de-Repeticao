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
                    for (int indcNota = 1; indcNota <= 2; indcNota++)
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
                    Console.WriteLine("A média do aluno {0}: {1}", indcAluno, mediaUnica);
                    mediaGeral = mediaGeral + mediaUnica;
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Média geral dos alunos: {0}", (mediaGeral / 5));
            }

            void Exercicio2()
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

            void Exercicio3()
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
                        Console.WriteLine("Digite a idade da {0}ª pessoa: ", ii);
                        converteuParaInt = int.TryParse(Console.ReadLine(), out idadeAtual);

                        if (!converteuParaInt || idadeAtual < 0)
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
                int idade = 0, qtdefx1 = 0, qtdefx2 = 0, qtdefx3 = 0, qtdefx4 = 0, qtdefx5 = 0;
                for (int ii = 1; ii <= 15; ii++)
                {
                    bool converteuParaInt = false;
                    while (!converteuParaInt)
                    {
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Digite a {0}ª idade: ", ii);
                        converteuParaInt = int.TryParse(Console.ReadLine(), out idade);

                        if (!converteuParaInt || idade < 0)
                        {
                            Console.WriteLine("Idade inválida.");
                            converteuParaInt = false;
                        }
                    }

                    if (idade <= 15) qtdefx1++;
                    else if (idade <= 30) qtdefx2++;
                    else if (idade <= 45) qtdefx3++;
                    else if (idade <= 60) qtdefx4++;
                    else qtdefx5++;
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Dados: ");
                Console.WriteLine("-- Integrantes da faixa etária 1 (1 a 15 anos): {0} pessoas ({1}%) ", qtdefx1, ((qtdefx1 * 100) / 15.0).ToString("N1"));
                Console.WriteLine("-- Integrantes da faixa etária 2 (16 a 30 anos): {0} pessoas ({1}%) ", qtdefx2, ((qtdefx2 * 100) / 15.0).ToString("N1"));
                Console.WriteLine("-- Integrantes da faixa etária 3 (31 a 45 anos): {0} pessoas ({1}%) ", qtdefx3, ((qtdefx3 * 100) / 15.0).ToString("N1"));
                Console.WriteLine("-- Integrantes da faixa etária 4 (46 a 60 anos): {0} pessoas ({1}%) ", qtdefx4, ((qtdefx4 * 100) / 15.0).ToString("N1"));
                Console.WriteLine("-- Integrantes da faixa etária 5 (acima de 60 anos): {0} pessoas ({1}%) ", qtdefx5, ((qtdefx5 * 100) / 15.0).ToString("N1"));
            }

            void Exercicio6()
            {
                string sexo = "";
                int peso = 0, altura = 0, pessoas = 20;
                int qtdeHomens = 0, qtdeMulheres = 0, somaPesoHomens = 0, somaPesoMulheres = 0, somaALturaHomens = 0, somaALturaMulheres = 0;

                for (int ii = 1; ii <= pessoas; ii++)
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("{0}ª pessoa: ", ii);

                    bool contemApenasLetras = false;
                    while (!contemApenasLetras)
                    {
                        Console.WriteLine("- Digite o sexo (M/F): ");
                        sexo = Console.ReadLine().ToUpper();
                        contemApenasLetras = sexo.All(Char.IsLetter);

                        if (!contemApenasLetras || (sexo != "M" && sexo != "F"))
                        {
                            Console.WriteLine("Valor inválido.");
                            contemApenasLetras = false;
                        }
                    }

                    bool converteuParaInt = false;
                    while (!converteuParaInt)
                    {
                        Console.WriteLine("- Digite o peso em kg: ");
                        converteuParaInt = int.TryParse(Console.ReadLine(), out peso);

                        if (!converteuParaInt || peso <= 0)
                        {
                            Console.WriteLine("Valor inválido.");
                            converteuParaInt = false;
                        }
                    }

                    converteuParaInt = false;
                    while (!converteuParaInt)
                    {
                        Console.WriteLine("- Digite a altura em cm: ");
                        converteuParaInt = int.TryParse(Console.ReadLine(), out altura);

                        if (!converteuParaInt || altura <= 0)
                        {
                            Console.WriteLine("Valor inválido.");
                            converteuParaInt = false;
                        }
                    }

                    if (sexo == "M")
                    {
                        qtdeHomens++;
                        somaPesoHomens = somaPesoHomens + peso;
                        somaALturaHomens = somaALturaHomens + altura;
                    }
                    else if (sexo == "F")
                    {
                        qtdeMulheres++;
                        somaPesoMulheres = somaPesoMulheres + peso;
                        somaALturaMulheres = somaALturaMulheres + altura;
                    }
                }

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Dados:");
                Console.WriteLine("");
                Console.WriteLine("HOMENS:");
                Console.WriteLine("- Quantidade: {0} homens ({1}%)", qtdeHomens, (qtdeHomens * 100) / pessoas);
                Console.WriteLine("- Peso médio: {0}kg ", (somaPesoHomens / qtdeHomens));
                Console.WriteLine("- Altura média: {0}m ", (somaALturaHomens / qtdeHomens));
                Console.WriteLine("-----------------------------");
                Console.WriteLine("MULHERES:");
                Console.WriteLine("- Quantidade: {0} mulheres ({1}%)", qtdeMulheres, (qtdeMulheres * 100) / pessoas);
                Console.WriteLine("- Peso médio: {0}kg ", (somaPesoMulheres / qtdeMulheres));
                Console.WriteLine("- Altura média: {0}m ", (somaALturaMulheres / qtdeMulheres));
            }

            void Exercicio7()
            {
                int voto = 1;
                int totalVotos = 1;
                int qtdeVotos1 = 0, qtdeVotos2 = 0, qtdeVotos3 = 0, qtdeVotos4 = 0, qtdeVotosNulos = 0, qtdeVotosBrancos = 0;

                Console.WriteLine("INFORMAÇÕES:");
                Console.WriteLine("- Para votar no candidato 1 digite 1");
                Console.WriteLine("- Para votar no candidato 2 digite 2");
                Console.WriteLine("- Para votar no candidato 3 digite 3");
                Console.WriteLine("- Para votar no candidato 4 digite 4");
                Console.WriteLine("- Para votar NULO digite 5");
                Console.WriteLine("- Para votar BRANCO digite 6");
                Console.WriteLine("---------------------------------------");

                do
                {
                    bool converteuParaInt = false;
                    while (!converteuParaInt)
                    {
                        Console.WriteLine("{0}º VOTO: Digite o seu voto ou finalize a votação digitando '0': ", totalVotos);
                        converteuParaInt = int.TryParse(Console.ReadLine(), out voto);

                        if (!converteuParaInt || voto < 0 || voto > 6)
                        {
                            Console.WriteLine("Valor inválido.");
                            converteuParaInt = false;
                        }
                    }
                    Console.WriteLine("Voto registrado.");
                    Console.WriteLine("------------------");

                        totalVotos++;

                    switch (voto)
                    {
                        case 0:
                            totalVotos--;
                            break;
                        case 1:
                            qtdeVotos1++;
                            break;
                        case 2:
                            qtdeVotos2++;
                            break;
                        case 3:
                            qtdeVotos3++;
                            break;
                        case 4:
                            qtdeVotos4++;
                            break;
                        case 5:
                            qtdeVotosNulos++;
                            break;
                        case 6:
                            qtdeVotosBrancos++;
                            break;
                        default:
                            converteuParaInt = false;
                            break;
                    }
                }
                while (voto != 0);

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Dados:");
                Console.WriteLine("");
                Console.WriteLine("Total de votos: {0}", totalVotos - 1);
                Console.WriteLine("- Candidato 1: {0} votos", qtdeVotos1);
                Console.WriteLine("- Candidato 2: {0} votos", qtdeVotos2);
                Console.WriteLine("- Candidato 3: {0} votos", qtdeVotos3);
                Console.WriteLine("- Candidato 4: {0} votos", qtdeVotos4);
                Console.WriteLine("- Nulos: {0} votos ({1}%)", qtdeVotosNulos, (qtdeVotosNulos * 100) / totalVotos);
                Console.WriteLine("- Brancos: {0} votos ({1}%)", qtdeVotosBrancos, (qtdeVotosBrancos * 100) / totalVotos);
            }

            void Exercicio8()
            {
                // Exibir os 30 primeiros valores de série de Fibonacci: 1,1,2,3,5,8,13,...
                int anterior = 1, atual = 0, proximo = 0;

                Console.WriteLine("Sequência de Fibonacci até o 30º valor:");
                for (int ii = 1; ii <= 30; ii++)
                {
                    proximo = anterior + atual;
                    atual = anterior;
                    anterior = proximo;
                    Console.WriteLine(proximo);
                }
            }

            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
            //Exercicio7();
            Exercicio8();
        }
    }
}

