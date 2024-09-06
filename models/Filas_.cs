namespace my_study_Csharp.models
{
    public class Filas
    { 
        // Método para gerenciar a fila
        public void GerenciarFila()
        {
            // Criação de uma fila usando o tipo genérico Queue<T>
            Queue<string> fila = new Queue<string>();

            // Adicionando elementos à fila (Enqueue)
            fila.Enqueue("João");
            fila.Enqueue("Maria");
            fila.Enqueue("Pedro");
            fila.Enqueue("Ana");

            // Mostrando os elementos da fila
            Console.WriteLine($"\nElementos da fila:\n"); // \n pula uma linha
            foreach (string item in fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}