using System;

namespace trabalhoVALDECIO
{
    class Program
    {
        static void Main(string[] args)
        {
             int itemmenu = 0;
            produtos meusprodutos = new produtos();
            while (itemmenu != 3)
            {
                switch (itemmenu)
                {
                    case 0:
                        Tela.Menu();
                        itemmenu = int.Parse(System.Console.ReadLine());
                        break;
                    case 1:
                        produto p = Tela.NovoProduto();
                        meusprodutos.AdicionarProduto(p);
                        System.Console.WriteLine("Cadastrar um novo produto? S-Sim, N-Não");
                        string r = System.Console.ReadLine();
                        if (r == "S")
                        {
                            itemmenu = 1;
                        }
                        else
                        {
                            itemmenu = 0;
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }            

        }
    }
}

        }
    }
}
