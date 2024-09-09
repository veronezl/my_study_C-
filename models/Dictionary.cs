namespace my_study_Csharp.models
{
    public class Dictionary
    {
        // Método para gerenciar o Dictionary
        public void GerenciarDictionary()
        {
            // Criação do dicionário com chave do tipo string e valor do tipo int
            Dictionary<string, int> alunos = new Dictionary<string, int>();

            // Adicionando elementos ao dicionário
            alunos.Add("João", 85);
            alunos.Add("Maria", 90);
            alunos.Add("Pedro", 78);

            // Mostrando todos os elementos do dicionário
            Console.WriteLine($"\nLista de alunos e suas notas:\n");
            foreach (KeyValuePair<string, int> aluno in alunos) // Pode usar var ao invés de KeyValue
            {
                Console.WriteLine($"Nome: {aluno.Key}, Nota: {aluno.Value}");
            }

            // Acessando um valor específico usando a chave
            string alunoNome = "Maria";
            if (alunos.ContainsKey(alunoNome))
            {
                Console.WriteLine($"\nNota de {alunoNome}: {alunos[alunoNome]}");
            }

        }
    }
}