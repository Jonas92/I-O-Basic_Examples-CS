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

        #region Método de leitura do arquivo

        public string ConteudoDoArquivo()
        {

            if (arquivoNaoEncontrado())
                throw new ArgumentException("Arquivo não encontrado!");

            return Conteudo();
        }

        #region Retorna o conteúdo do arquivo

        private string Conteudo()
        {
            string conteudo = "";
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

            return conteudo;
        }

        #endregion

        #region Verifica existência do arquivo

        private bool arquivoNaoEncontrado()
        {
            return !File.Exists(fileName);
        }

        #endregion

        #endregion
    }
}
