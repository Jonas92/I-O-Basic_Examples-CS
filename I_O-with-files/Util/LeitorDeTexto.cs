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
                throw new ArgumentException("Arquivo " + fileName + "encontrado!");

            return Conteudo();
        }

        #region Retorna o conteúdo do arquivo

        private string Conteudo()
        {
            string conteudo = "";

            using (Stream entrada = File.Open(fileName, FileMode.Open))
            {

                using (StreamReader leitor = new StreamReader(entrada))
                {
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        conteudo += linha;
                        linha = leitor.ReadLine();
                    }
                }
            }

            return conteudo;
        }

        #endregion

        #region Verifica existência do arquivo

        private bool arquivoNaoEncontrado()
        {
            return !File.Exists(fileName);
        }

        #endregion

        #region Retorna o conteúdo do arquivo, sem levar em consideração a performance

        private string ConteudoSemPerformance()
        {
            string conteudo = "";

            using (Stream entrada = File.Open(fileName, FileMode.Open))
            {

                using (StreamReader leitor = new StreamReader(entrada))
                {
                    conteudo = leitor.ReadToEnd();
                }
            }

            return conteudo;
        }

        #endregion

        #endregion
    }
}
