using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02_SistemaMedico
{
  internal class Pessoa
  {
    internal string nome;
    internal int idade;
    internal double altura;
    internal double peso;

    public void setNome(string nome)
    {
      this.nome = nome;
    }

    public void setIdade(int idade)
    {
      this.idade = idade;
    }

    public void setAltura(double altura)
    {
      this.altura = altura;
    }

    public void setPeso(double peso)
    {
      this.peso = peso;
    }

    public string getInformacao()
    {
      return this.nome + "\n" + this.idade + "\n" + this.altura+ "\n" + this.peso;
    }
  }
}
