using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Pessoa AlunoObj;
        private Pessoa FuncionarioObj;

        private void btnCriarAluno_Click(object sender, EventArgs e)
        {
            AlunoObj = new Aluno();
            AlunoObj.Nome = txtNomeAluno.Text;
            AlunoObj.Endereco = txtEnderecoAluno.Text;
            AlunoObj.Email = txtEmailAluno.Text;
            (AlunoObj as Aluno).Curso = txtCursoAluno.Text;
            (AlunoObj as Aluno).Matricula = int.Parse(txtMatriculaAluno.Text);
            MessageBox.Show($"Aluno {txtNomeAluno.Text} Criado com sucesso!","Atenção");
            txtNomeAluno.Text = null;
            txtEnderecoAluno.Text = null;
            txtEmailAluno.Text = null;
            txtCursoAluno.Text = null;
            txtMatriculaAluno.Text = null;
        }

        private void btnCriarFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioObj = new Funcionario();
            FuncionarioObj.Nome = txtNomeFuncionario.Text;
            FuncionarioObj.Endereco = txtEnderecoFuncionario.Text;
            FuncionarioObj.Email = txtEmailFuncionario.Text;
            (FuncionarioObj as Funcionario).Cargo = txtCargoFuncionario.Text;
            (FuncionarioObj as Funcionario).Salario = int.Parse(txtSalarioFuncionario.Text);
            MessageBox.Show($"Funcionario {txtNomeFuncionario.Text} Criado com sucesso!", "Atenção");
            txtNomeFuncionario.Text = null;
            txtEnderecoFuncionario.Text = null;
            txtEmailFuncionario.Text = null;
            txtCargoFuncionario.Text = null;
            txtSalarioFuncionario.Text = null;
        }

        private void btnMoverAluno_Click(object sender, EventArgs e)
        {
            AlunoObj.Andar();
        }

        private void btnMoverFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioObj.Andar();
        }
    }
}
