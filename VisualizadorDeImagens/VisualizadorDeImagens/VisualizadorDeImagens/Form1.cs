using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception
 ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
                }
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
