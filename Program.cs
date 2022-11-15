using System;
namespace Desafio02_SistemaMedico;

class Program
{
  static void Main(string[] args)
  {
    Pessoa paciente= new Pessoa();
    paciente.setNome("Bruno Oliveira");
    paciente.setIdade(32);
    paciente.setAltura(1.82);
    paciente.setPeso(94.600);

    Console.WriteLine(paciente.getInformacao());
  }
}