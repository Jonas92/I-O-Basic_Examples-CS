using I_O_with_files.Forms.Util;
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
            LeitorDeArquivo leitor = new LeitorDeArquivo(FILE_NAME);
            TextoTxt.Text = leitor.ConteudoDoArquivo();
        }

        private void salvaTextoBtn_Click(object sender, EventArgs e)
        {
            Stream saida = File.Open(FILE_NAME, FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.WriteLine(TextoTxt.Text);
            escritor.Close();
            saida.Close();


        }
    }
}
