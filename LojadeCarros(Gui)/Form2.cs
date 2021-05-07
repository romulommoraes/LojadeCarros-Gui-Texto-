using ClasseCarro;
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


namespace LojadeCarros_Gui_
{

    public partial class Form2 : Form
    {
        Loja minhaLoja = new Loja();
        List<Carro> total = new List<Carro>();
        List<string> output = new List<string>();

        static string filepathRaiz = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        static string fileBD = @$"{filepathRaiz}\bd.txt";

        Form1 form1;

        public Form2(Form1 f) //permite usar uma função do form 2 pra manipular a list view do form1 adicionando form1. antes do comando
        {
            InitializeComponent();
            form1 = f;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try //posso refinar mais isso
            {
                Carro c = new Carro(txt_Marca.Text, txt_modelo.Text, decimal.Parse(txt_preco.Text), int.Parse(txt_ano.Text), txt_estado.Text, txt_portas.Text, int.Parse(txt_qtd.Text), txt_codigo.Text);
                minhaLoja.ListaCarros.Add(c);

                txt_Marca.Text = "";
                txt_modelo.Text = "";
                txt_preco.Text = "";
                txt_ano.Text = "";
                txt_estado.Text = "";
                txt_portas.Text = "";
                txt_qtd.Text = "";
                txt_codigo.Text = "";
                total.Clear();
                listView1.Items.Clear();

                for (int i = 0; i < minhaLoja.ListaCarros.Count; i++)
                {
                    total.Add(minhaLoja.ListaCarros[i]);
                }
                foreach (var item in total)
                {
                    String[] itemLinha = new string[] { item.Marca, item.Modelo.ToString(), item.Preço.ToString(), item.Ano.ToString(), item.Estado, item.Portas, item.Qtd.ToString(), item.Codigo.ToString() };
                    listView1.Items.Add(new ListViewItem(itemLinha));//o list view item requer um array como parametro, no caso tem que criar ele pra poder adicionar ao list view
                }
            }
            catch
            {
                MessageBox.Show("ERRO DE INPUT");
            }
        }



        private void btn_carregar_Click(object sender, EventArgs e)
        {

            string filepathRaiz = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            string fileBD = @$"{filepathRaiz}\bd.txt";
            minhaLoja.ListaCarros.Clear();
            String[] itens = File.ReadAllLines(fileBD);//separa todas as linhas do arquivo numa lista de strings

            foreach (var item in itens)
            {
                string[] carro = item.Split("\t");
                Carro c = new Carro(carro[0].ToString(), carro[1].ToString(), decimal.Parse(carro[2]), int.Parse(carro[3]), carro[4].ToString(), carro[5].ToString(), int.Parse(carro[6]), carro[7]);
                minhaLoja.ListaCarros.Add(c);
            }
            total.Clear();
            listView1.Items.Clear();

            for (int i = 0; i < minhaLoja.ListaCarros.Count; i++)
            {
                total.Add(minhaLoja.ListaCarros[i]);
            }
            foreach (var item in total)
            {
                String[] itemLinha = new string[] { item.Marca, item.Modelo.ToString(), item.Preço.ToString(), item.Ano.ToString(), item.Estado, item.Portas, item.Qtd.ToString(), item.Codigo.ToString() };
                listView1.Items.Add(new ListViewItem(itemLinha));//o list view item requer um array como parametro, no caso tem que criar ele pra poder adicionar ao list view
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string outputFile = fileBD;
            for (int i = 0; i < minhaLoja.ListaCarros.Count; i++)
            {
                total.Add(minhaLoja.ListaCarros[i]);
                output.Add(total[i].ToStringData());
               
            }

            File.WriteAllLines(outputFile, output); //grava o arquivo 
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            form1.RecarregarListview();//recarrega a listview do form 1 com os itens adicionados
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            total.Clear();
            listView1.Items.Clear();
            minhaLoja.ListaCarros.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            String[] itens = File.ReadAllLines(fileBD);//separa todas as linhas do arquivo numa lista de strings

            foreach (var item in itens)
            {
                string[] carro = item.Split("\t");
                Carro c = new Carro(carro[0].ToString(), carro[1].ToString(), decimal.Parse(carro[2]), int.Parse(carro[3]), carro[4].ToString(), carro[5].ToString(), int.Parse(carro[6]), carro[7]);
                minhaLoja.ListaCarros.Add(c);
            }

            total.Clear();
            listView1.Items.Clear();

            for (int i = 0; i < minhaLoja.ListaCarros.Count; i++)
            {
                total.Add(minhaLoja.ListaCarros[i]);
            }
            foreach (var item in total)
            {
                String[] itemLinha = new string[] { item.Marca, item.Modelo.ToString(), item.Preço.ToString(), item.Ano.ToString(), item.Estado, item.Portas, item.Qtd.ToString(), item.Codigo };
                listView1.Items.Add(new ListViewItem(itemLinha));//o list view item requer um array como parametro, no caso tem que criar ele pra poder adicionar ao list view
            }
            listView1.Columns.Add("Marca", 75);
            listView1.Columns.Add("Modelo", 75);
            listView1.Columns.Add("Preço", 50);
            listView1.Columns.Add("Ano", 40);
            listView1.Columns.Add("Estado", 60);
            listView1.Columns.Add("Portas", 50);
            listView1.Columns.Add("QTD", 35);
            listView1.Columns.Add("Código", 70);

            listView1.View = View.Details;
            listView1.GridLines = true; //mostra linha de grades
            listView1.FullRowSelect = true; //seleciona toda a linha qdo clica
            listView1.Sorting = SortOrder.Ascending; //ordena a lista pela primeira coluna

        }

        private void txt_portas_TextChanged(object sender, EventArgs e)
        {
            // função pra gerar o codigo
            string codigoP1;
            string codigoP2 = txt_ano.Text;
            string codigoP3;
            string codigoP4;
            switch (txt_Marca.Text.ToUpper())
            {
                case "WW":
                    codigoP1 = "1";
                    break;
                case "FIAT":
                    codigoP1 = "2";
                    break;
                case "RENAULT":
                    codigoP1 = "3";
                    break;
                case "CHEVROLET":
                    codigoP1 = "4";
                    break;
                case "FORD":
                    codigoP1 = "5";
                    break;
                case "GURGEL":
                    codigoP1 = "6";
                    break;
                case "PEUJEOT":
                    codigoP1 = "7";
                    break;

                default:
                    codigoP1 = "9";
                    break;
            }
            switch (txt_portas.Text.ToUpper())
            {
                case "2":
                    codigoP3 = "2";
                    break;
                case "4":
                    codigoP3 = "4";
                    break;
                default:
                    codigoP3 = "3";
                    break;
            }

            Random r = new Random();
            int randomInt = r.Next(0, 100);
            codigoP4 = randomInt.ToString();

            txt_codigo.Text = codigoP1 + codigoP2 + codigoP3 + codigoP4;

        }

        private void LoadListview1()
        {
            total.Clear();
            listView1.Items.Clear();

            for (int i = 0; i < minhaLoja.ListaCarros.Count; i++)
            {
                total.Add(minhaLoja.ListaCarros[i]);
            }
            foreach (var item in total)
            {
                String[] itemLinha = new string[] { item.Marca, item.Modelo.ToString(), item.Preço.ToString(), item.Ano.ToString(), item.Estado, item.Portas, item.Qtd.ToString(), item.Codigo };
                listView1.Items.Add(new ListViewItem(itemLinha));//o list view item requer um array como parametro, no caso tem que criar ele pra poder adicionar ao list view
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < minhaLoja.ListaCarros.Count; j++)
            {
                if (int.Parse(listView1.SelectedItems[0].SubItems[7].Text) == int.Parse(minhaLoja.ListaCarros[j].Codigo))
                {

                    minhaLoja.ListaCarros.Remove(minhaLoja.ListaCarros[j]);

                    LoadListview1();
                    return;
                }
            }
        }
    }
}
