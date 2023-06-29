namespace Natação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Criar uma intância de Natação
            Aluno alunoNatacao = new Aluno();

            alunoNatacao.Professor = txtProfessor.Text;
            alunoNatacao.Nome = txtNome.Text;
            alunoNatacao.Aula = txtAula.Text;
            alunoNatacao.MarcacaoDeAula = txtMarcacaoDeAula.Value;
            MessageBox.Show(" O aluno" + alunoNatacao.Nome + "foi cadastrado");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}