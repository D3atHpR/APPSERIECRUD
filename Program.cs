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
    Conole.WriteLine("Obrigrado por utilizar o app");
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
            Console.WriteLine("#ID {0}: - {1}". serie.retornaId(). serie.retornaTitulo());
        }

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

        string opcaoUsuario = Conole.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
        {
            
        }
    }

