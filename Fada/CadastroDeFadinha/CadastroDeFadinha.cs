using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeFadinha
{
    public partial class CadastroDeFadinha : Form
    {
        string nomeAntigo = "";
        bool novo = true;
        List<Fadinhas> fadinha = new List<Fadinhas>();

        public CadastroDeFadinha()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnSalvarFadinha_Click(object sender, EventArgs e)
        {
            try
            {
                Fadinhas fadinhas = new Fadinhas();

                {


                    fadinhas.Nome = txtNomeFadinha.Text;
                    fadinhas.Familia = txtFamiliaFadinha.Text;
                    fadinhas.Cor = txtCorFadinha.Text;
                    fadinhas.CorAsa = txtCorAsa.Text;
                    fadinhas.TamanhoAsa = Convert.ToInt32(txtTamanhoAsa.Text);
                    fadinhas.Elemento = txtElemento.Text;
                };

                if (nomeAntigo == "")
                {
                    fadinha.Add(fadinhas);
                    MessageBox.Show("Cadastrado com sucesso");
                    AdicionarFadaATabela(fadinhas);
                }
                else
                {
                    int linha = fadinha.FindIndex(x => x.Nome == nomeAntigo);
                    fadinha[linha] = fadinhas;
                    EditarFadinhaNaTabela(fadinhas, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                }
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void LimparCampos()
        {
           
            txtNomeFadinha.Text = "";
            txtFamiliaFadinha.Text = "";
            txtCorFadinha.Text = "";
            txtCorAsa.Text = "";
            txtTamanhoAsa.Text = "";
            txtElemento.Text = "";

        }

        private void EditarFadinhaNaTabela(Fadinhas fadinhas, int linha)
        {
            dataGridView1.Rows[linha].Cells[0].Value = fadinhas.Nome;
            dataGridView1.Rows[linha].Cells[1].Value = fadinhas.Familia;
            dataGridView1.Rows[linha].Cells[2].Value = fadinhas.Cor;
            dataGridView1.Rows[linha].Cells[3].Value = fadinhas.CorAsa;
            dataGridView1.Rows[linha].Cells[4].Value = fadinhas.TamanhoAsa;
            dataGridView1.Rows[linha].Cells[5].Value = fadinhas.Elemento;
        }

        private void AdicionarFadaATabela(Fadinhas fadinhas)
        {
            dataGridView1.Rows.Add(new Object[]{
                fadinhas.Nome, fadinhas.Familia, fadinhas.Cor, fadinhas.CorAsa, fadinhas.TamanhoAsa, fadinhas.Elemento
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fadinha!");
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um arquivo para editar");
                return;
            }
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            foreach (Fadinhas fadinhas in fadinha)
            {
                if (fadinhas.Nome == nome)
                {
                    txtNomeFadinha.Text = fadinhas.Nome;
                    txtFamiliaFadinha.Text = fadinhas.Familia;
                    txtCorFadinha.Text = fadinhas.Cor;
                    txtCorAsa.Text = fadinhas.CorAsa;
                    txtTamanhoAsa.Text = Convert.ToString(fadinhas.TamanhoAsa);
                    txtElemento.Text = fadinhas.Elemento;
                    nomeAntigo = fadinhas.Nome;
                    tabControl1.SelectedIndex = 1;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fadinha!");
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um arquivo para apagar");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            for (int i = 0; i < fadinha.Count(); i++)
            {
                Fadinhas fadinhas = fadinha[i];
                if (fadinhas.Nome == nome)
                {
                    fadinha.RemoveAt(i);
                }
            }

            dataGridView1.Rows.RemoveAt(linhaSelecionada);
        }

        private void btnCancelarFadinha_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnSalvarRapido_Click(object sender, EventArgs e)
        {
            try
            {
                Fadinhas fadinhas = new Fadinhas();

                {


                    fadinhas.Nome = txtNome.Text;
                    fadinhas.Familia = txtFamilia.Text;
                    fadinhas.Cor = txtcoor.Text;
                    
                };

                if (nomeAntigo == "")
                {
                    fadinha.Add(fadinhas);
                    MessageBox.Show("Cadastrado com sucesso");
                    AdicionarFadaATabela(fadinhas);
                }
                else
                {
                    int linha = fadinha.FindIndex(x => x.Nome == nomeAntigo);
                    fadinha[linha] = fadinhas;
                    EditarFadinhaNaTabela(fadinhas, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                }
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }

        

       


        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnCancelarRapido_Click(object sender, EventArgs e)
        {
            LimparCampos2();
        }

        private void LimparCampos2()
        {
            txtNome.Text = "";
            txtFamilia.Text = "";
            txtCor.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

       
    }
}
