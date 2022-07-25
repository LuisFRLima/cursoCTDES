using luisfelipe_d3_avaliacao.Interfaces;
using luisfelipe_d3_avaliacao.Models;
using System.Text;

namespace luisfelipe_d3_avaliacao.Repositorios
{
    public class LogRepositorio : ILog
    {
        private const string path = "database/log.txt";
        public LogRepositorio()
        {
            CreateFolderAndFile(path);
            
        }

        private static string PrepareLine(Usuario user)
        {
            var DateAndTime = DateTime.Now;
            var Date = DateAndTime.ToString("dd/MM/yyyy");
            return $"O usuário:{user.Nome} acessou o sistema da LogCons no dia {Date} as {DateTime.Now.Hour}:{DateTime.Now.Minute}";
        }

        private static string PrepareLineSaida(Usuario user)
        {
            var DateAndTime = DateTime.Now;
            var Date = DateAndTime.ToString("dd/MM/yyyy");
            return $"O usuário:{user.Nome} deslogou do sistema da LogCons no dia {Date} as {DateTime.Now.Hour}:{DateTime.Now.Minute}";
        }

        public static void CreateFolderAndFile(string path)
        {
            string folder = path.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
        public void RegistrarAcessoSaida(Usuario user)
        {

            using (StreamWriter output = new(path,true))
            {
                string line = PrepareLineSaida(user);
                output.WriteLine(line);
            }


        }
        public void RegistrarAcesso(Usuario user)
        {

            using (StreamWriter output = new(path,true)) 
            {
               string line = PrepareLine(user);
               output.WriteLine(line);
            }
              
            
        }
    }
}
