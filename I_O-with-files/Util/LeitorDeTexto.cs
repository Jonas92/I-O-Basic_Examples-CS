using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_O_with_files.Forms.Util
{
    class LeitorDeArquivo
    {
        private string fileName;

        public LeitorDeArquivo(string fileName)
        {
            this.fileName = fileName;
        }

        public string ConteudoDoArquivo()
        {
            string conteudo = "";

            if (File.Exists(fileName))
            {
                Stream entrada = File.Open(fileName, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    conteudo += linha;
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }

            return conteudo;
        }
    }
}
