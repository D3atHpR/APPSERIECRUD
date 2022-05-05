using System;
using APPSERIES.Classes;

   static SerieRepositorio repositorio = new SerieRepositorio();


    string opcaoUsuario = ObterOpcaoUsuario();

    while (opcaoUsuario.ToUpper() != "X")
    {
        switch (opcaoUsuario)
        {
            case "1":
                listaSerie();
                break;
            case "2":
                InserirSerie();
                break;
            case "3":
                AtualizarSerie();
                break;
            case "4":
                ExcluirSerie();
                break;
            case "5":
                VisualizarSerie();
                break;
            case "C":
                Console.Clear();
                break;                   
            default:
                throw new ArgummentOutOfRangeException();
                break;
        }
        
        opcaoUsuario = ObterOpcaoUsuario();

    }
    Console.WriteLine("Obrigrado por utilizar o app");
    Console.ReadLine(); 

    
    private static void listaSerie()
    {
        Console.WriteLine("listar séries");
        var lista = repositorio.Lista();
        if (lista.Count == 0)
        {
            Console.WriteLine("nehuma série cadastrada.");
            return;
        }
        foreach (var serie in lista)
        {
            var excluido = serie.retornaExcluido();

            Console.WriteLine("#ID {0}: - {1}  {2}". serie.retornaId(). serie.retornaTitulo(), (excluido ? "*Excluido*" : "Não"));
        }

    }

    private static void InserirSerie()
    {
        Console.WriteLine("Inserie nova Série");

        foreach(int i in Enum.GetValues(typeof(Genero),i))
        {
            Console.WriteLine("{0}-{1}", i Enum.GetName(typeof), i);
        }
        Console.Write("Digite o Gênero dentre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o Título da Série: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o ano de Inicio da Série: ");
        int EntradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite a Descrição da Série: ");
        string entradaDescricao = Console.ReadLine();

        Series novaSerie = new Series(id: repositorio.ProximoId(),
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    ano: EntradaAno,
                                    descricao: entradaDescricao);
        repositorio.Insere(novaSerie);

    }

    private static void AtualizarSerie()
    {
        Console.WriteLine("Digite Id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        foreach(int i in Enum.GetValues(typeof(Genero),i))
        {
            Console.WriteLine("{0}-{1}", i Enum.GetName(typeof), i);
        }
        Console.Write("Digite o Gênero dentre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o Título da Série: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o ano de Inicio da Série: ");
        int EntradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite a Descrição da Série: ");
        string entradaDescricao = Console.ReadLine();

        Series atualizarSerie= new Series(id: indiceSerie,
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    ano: EntradaAno,
                                    descricao: entradaDescricao);
        repositorio.Atualizar(IndiceSerie, atualizarSerie);

    }

    private static void ExcluirSerie()
    {
        Console.Write("Digite o id da Série: ");
        int indiceSerie = int.Parse(Console.ReadLine());
        repositorio.Exclui(indiceSerie); 
    }

    private static void VisualizarSerie()
    {
        Console.Write("Digite o id da Série: ");
        int indiceSerie = int.Parse(Console.ReadLine());
        var serie = repositorio.RetornaPorId(indiceSerie);
        Console.WriteLine(serie);
    }



    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("APP Series");
        Console.WriteLine("Infomra a opção desejada");

        Console.WriteLine("1- Listar séries");
        Console.WriteLine("2- Inserir nova série");
        Console.WriteLine("3- Atualizar série");
        Console.WriteLine("4- Excluir série");
        Console.WriteLine("5- Visualizar série");
        Console.WriteLine("C- Limpar Tela");
        Console.WriteLine("X- Sair");

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
        {
            
        }
    }

