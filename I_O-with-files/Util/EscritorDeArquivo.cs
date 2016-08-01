using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_O_with_files.Util
{
    class EscritorDeArquivo
    {
        private string fileName;

        public EscritorDeArquivo(string fileName)
        {
            this.fileName = fileName;
        }

        public void Escreve(string conteudo)
        {
            Stream saida = File.Open(fileName, FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.WriteLine(conteudo);
            escritor.Close();
            saida.Close();
        }
    }
}
