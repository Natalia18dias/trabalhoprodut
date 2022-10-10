class Tela
{
    public static void Menu()
    {
            System.Console.Clear();
            System.Console.WriteLine("|------------------------------------|");
            System.Console.WriteLine("|          MENU PRINCIPAL            |");
            System.Console.WriteLine("|------------------------------------|");
            System.Console.WriteLine("|1 - Cadastrar Produtos              |");
            System.Console.WriteLine("|2 - Lista de Produtos               |");
            System.Console.WriteLine("|3 - Sair                            |");
            System.Console.WriteLine("|------------------------------------|");
    }
    public static produto NovoProduto()
    {
        produto p = new produto();
        System.Console.Clear();
        System.Console.WriteLine("|------------------------------------|");
        System.Console.WriteLine("|          INCLUSÃO DE PRODUTO       |");
        System.Console.WriteLine("|------------------------------------|");
        

        System.Console.Write("Informe o código do produto:");
        p.Codigo  = int.Parse(System.Console.ReadLine());
        System.Console.Write("Informe o nome do produto:");
        p.nome = System.Console.ReadLine();
        System.Console.Write("Informe custo do produto:");
        p.custo = double.Parse(System.Console.ReadLine());
        System.Console.Write("Informe venda do produto:");
        p.venda = double.Parse(System.Console.ReadLine());
        return p;
    }
    public static void MostrarProdutos (produtos ps)
    {
        System.Console.WriteLine("|-------------------------------------------------------------|");
        System.Console.WriteLine("|                        LISTAR PRODUTOS                      |");
        System.Console.WriteLine("|-------------------------------------------------------------|");       
        System.Console.WriteLine("|COD. PROD |DESCRIÇÃO PRODUTO       |  VLR. CUSTO|  VLR. VENDA|");

        
    }
    private string RetornaTexto(string valor, int numerocasas)
    {
        string retorno;
        if (valor.Length>numerocasas)
        {
            retorno = valor.Substring(1,numerocasas);
        }
        else
        {
            retorno=valor;
        }
        return retorno;
    }
}