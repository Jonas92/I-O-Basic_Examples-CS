using I_O_with_files.Forms.Util;
using I_O_with_files.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_O_with_files.Forms
{
    public partial class Form1 : Form
    {
        private const string FILE_NAME = "texto.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LeitorDeArquivo leitor = new LeitorDeArquivo(FILE_NAME);
                TextoTxt.Text = leitor.ConteudoDoArquivo();
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao ler o arquivo " + FILE_NAME);
            }
        }

        private void salvaTextoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EscritorDeArquivo escritor = new EscritorDeArquivo(FILE_NAME);
                string conteudo = TextoTxt.Text;
                escritor.Escreve(conteudo);
                MessageBox.Show("Texto salvo em " + FILE_NAME + " com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar texto no arquivo " + FILE_NAME);
            }
        }
    }
}
