using WebApiRestFul.Models;

namespace WebApiRestFul.Repositories
{
    public interface IToDoRepository
    {
        // vamos precisar de alguns métodos assincronos de preferencia que peguem todos os dados,
        // que pegue por ID e adicione, atualize e delete, um CRUD bem simples.
        //como deixar como assincrono

        Task<IEnumerable<ToDoItem>> GetAllAsync();

        Task<ToDoItem> GetByIdAsync(int id);

        Task AddAsync(ToDoItem item);
        Task UpdateAsync(ToDoItem item);

        Task DeleteAsync(int id);

        // esse vai ser o contrato do nosso repositório
        // agora precisamos adicionar uma classe para implementar esse contrato da Interface
        
    }
}
