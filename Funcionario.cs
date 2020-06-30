using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academico
{
    class Funcionario : Pessoa
    {
        public string Cargo;
        public int Salario;

        public void Andar()
        {
            MessageBox.Show($"{Nome} começou a andar");
        }
    }
}
