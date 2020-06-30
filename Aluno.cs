using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academico
{
    class Aluno : Pessoa
    {
        public string Curso;
        public int Matricula;

        public void Andar()
        {
            MessageBox.Show($"{Nome} começou a andar");
        }
    }
}
