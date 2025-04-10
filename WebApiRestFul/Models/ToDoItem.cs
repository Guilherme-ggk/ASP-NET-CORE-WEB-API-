namespace WebApiRestFul.Models
{
    public class ToDoItem // Item de Tarefa
    {
        // USAR O SQLSERVER

        public int Id { get; set; } // ID relacionado
        public string Title { get; set; } = string.Empty; // Titulo   // deixando vazio ao inves de nulo
        public string Description { get; set; } = string.Empty ; // Descrição   // deixando vazio ao inves de nulo
        public DateTime CreatedAt { get; set; } // Data de Criação
        public bool IsCompleted { get; set; } // Se a tarefa está completa ou não


        // como vamos usar o EntityFramework, precisamos de um ID
        // ao usar a nomenclatura ID, o EntityFramework já entende que vai ser uma Primary Key do banco de dados
    }
}
