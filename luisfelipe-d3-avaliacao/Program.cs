using luisfelipe_d3_avaliacao.Models;
using luisfelipe_d3_avaliacao.Repositorios;

namespace luisfelipe_d3_avaliacao
{
    internal class Program
    {
        private const string path = "database/log.txt";

        static void Main(string[] args)
        {
            UsuarioRepositorio _user = new();
            LogRepositorio _log = new();

            string? option;

            do
            {
                Console.WriteLine("\nBem Vindo ao sistema LogCons:\n");
                Console.WriteLine("\nEscolha uma das opções abaixo:\n");
                Console.WriteLine("1 - Acessar o sistema");
                Console.WriteLine("2 - Cadastrar um novo Usuário");
                Console.WriteLine("0 - Sair do sistema\n");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nDigite o Email:");
                        var email = Console.ReadLine();
                        Console.WriteLine("\nDigite a Senha:");
                        var pass = Console.ReadLine();
                        if (email != "admin@email.com" || pass != "admin123")
                        {
                            Console.WriteLine("\nNão foi possível encontrar este Usuário, tente novamente!\n");
                        }
                        else
                        {
                            Console.WriteLine($"\nLogin feito com sucesso\n");
                            Usuario user = new Usuario()
                            {
                                Nome = "admin"
                              
                            };
                            _log.RegistrarAcesso(user);
                            Menu2();

                        }
                        break;

                    case "2":
                        Console.WriteLine("Digite o Id do Usuário(A partir do número 1):");
                        var id = Console.ReadLine();
                        Console.WriteLine("Digite o Nome do Usuário:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Digite a Senha do Usuário:");
                        var senha = Console.ReadLine();
                        Console.WriteLine("Digite o Email do Usuário:");
                        var em = Console.ReadLine();

#pragma warning disable CS8601 // Possível atribuição de referência nula.
                        Usuario newUser = new()
                        {
                            Id = Convert.ToInt32(id),
                            Nome = name,
                            Senha = senha,
                            Email = em
                        };
#pragma warning restore CS8601 // Possível atribuição de referência nula.

                        _user.Create(newUser);
                        Console.WriteLine($"Usuário:{newUser.Nome} criado com sucesso!");
                        break;

                    default:
                        break;
                }

            } while (option != "0");

           
        }

        private static void Menu2()
        {
            LogRepositorio _log = new();

            string? option;

            do
            {
                Console.WriteLine("\nEscolha uma das opções abaixo:\n");
                Console.WriteLine("1 - Deslogar o sistema");
                Console.WriteLine("2 - Encerrar o sistema \n");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Usuario user = new Usuario()
                        {
                            Nome = "admin"
                        };
                        _log.RegistrarAcessoSaida(user);
                        break;
                    
                    case "2":
                       Environment.Exit(0);
                        break;

                    default:
                        break;
                }

            } while (option != "1");
        }
    }
}