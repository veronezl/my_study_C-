using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_study_Csharp.models
{
    public class Curso
    {
       public string Nome { get; set; } 

       public List<Pessoa> Alunos { get; set; }

       public void AdicionarAluno(Pessoa aluno)
       {
        Alunos.Add(aluno);
       }

       public int ObterQuantidadeDeAlunosMatriculados()
       {
        int quantidade = Alunos.Count;
        return quantidade;
       }

       public void RemoverAluno(Pessoa aluno)
       {
        Alunos.Remove(aluno);
       }
    }
}