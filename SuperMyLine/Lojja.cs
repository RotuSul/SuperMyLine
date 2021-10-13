using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SuperMyLine
{
    class Lojja
    {
        static void Loja(string[] args, ConsoleKeyInfo Tecla)
        {
            double impostor = 0.20;
            int ProbNunber = 9;
            int ProbNunber1 = 38;
            // aperta um botão para abrir a loja
            VarConsoleKeyInfo Var1;
            Var1 = new VarConsoleKeyInfo();

            Tecla = Console.ReadKey(true);
            if (Tecla.Key == ConsoleKey.E)
            {
                bool ProbPessoa = true;
                // Console.WriteLine("Loja abilitada");

                // Console.WriteLine("Comprar produtos C and V para vende");
                // Comprar Produtos                

                if (Tecla.Key == ConsoleKey.C)
                {
                    var InputVar = Console.ReadKey(true);
                    switch (InputVar.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                // Categoria : Tecnologias Produto : dispositivo.Celular and Computado

                                Var1.Dinero = Var1.Dinero - 599;
                                Var1.DispositivoComCell = Var1.DispositivoComCell + 2;
                                Var1.Loop = Var1.Loop + 1;
                                ProbNunber = ProbNunber - 1;
                                ProbNunber1 = ProbNunber1 + 1;
                                ProbPessoa = true;

                                break;
                            }
                        case ConsoleKey.D2:
                            {
                                // Categoria : Tecnologias Produto : geladeira and microondas

                                Var1.Dinero = Var1.Dinero - 299;
                                Var1.ColiTec = Var1.ColiTec + 4;
                                Var1.Loop = Var1.Loop + 1;
                                ProbNunber = ProbNunber - 1;
                                ProbNunber1 = ProbNunber1 + 1;
                                ProbPessoa = true;

                                break;
                            }
                        case ConsoleKey.D3:
                            {
                                // Categoria : Tecnologias Produto : patentes and ligaçõesPC

                                Var1.Dinero = Var1.Dinero - 99;
                                Var1.Hardware = Var1.Hardware + 6;
                                Var1.Loop = Var1.Loop + 1;
                                ProbNunber = ProbNunber - 1;
                                ProbNunber1 = ProbNunber1 + 1;
                                ProbPessoa = true;

                                break;

                            }


                    }
                    if (InputVar.Key != ConsoleKey.D1 || InputVar.Key != ConsoleKey.D2 || InputVar.Key != ConsoleKey.D3)
                    {
                        ProbPessoa = false;
                    }
                    if(ProbPessoa == true)
                    {
                        ProbNunber = ProbNunber + 1;
                        ProbNunber1 = ProbNunber1 - 1;
                    }
                    else
                    {
                        ProbNunber = ProbNunber - 1;
                        ProbNunber1 = ProbNunber1 + 1;
                    }


                    for (int i = 1; i <= Var1.Loop; i++)
                    {

                        Thread.Sleep(20000);
                        Var1.Dinero = Var1.Dinero * impostor;
                        bool boolAffirmation = Var1.Loop < 0;
                        Random Proba = new Random();
                        int SIstemProba = Proba.Next(50);
                        if (SIstemProba <= ProbNunber || SIstemProba > ProbNunber1)
                        {
                            Var1.Pessoa = SIstemProba * 0.09;
                            Var1.DispositivoComCell = Var1.DispositivoComCell - Var1.Pessoa;
                            Var1.ColiTec = Var1.ColiTec - Var1.Pessoa;
                            Var1.Hardware = Var1.Hardware - Var1.Pessoa; // 399 de dinheiro de 1 produto
                            Var1.Dinero = Var1.Dinero + (Var1.Dispositivopreço + Var1.PreçoColitec + Var1.PreçoHardware) * Var1.Pessoa;
                        }
                        else
                        {
                            Var1.Loop = Var1.Loop - 1;
                        }
                        if (boolAffirmation == true)
                        {
                            Var1.Loop = 0;
                            Var1.Loop = Var1.Loop + 1;
                        }

                    }
                }

            }
        }
    }
}
