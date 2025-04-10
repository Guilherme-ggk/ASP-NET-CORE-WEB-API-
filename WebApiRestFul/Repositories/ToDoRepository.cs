using Microsoft.EntityFrameworkCore;
using WebApiRestFul.Data;
using WebApiRestFul.Models;

namespace WebApiRestFul.Repositories
{
    public class ToDoRepository : IToDoRepository // Adicionar na herança e implementar a interface
    { 
        private readonly ToDoContext _context; // Propriedade de apenas leitura do Contexto


        // Construtor
        public ToDoRepository(ToDoContext context) => this._context = context /*expressão*/;  // passando o _context por parametro para que ele seja carregado assim que o repositório for iniciado
        // quando o repositório for carregado, vai ser junto recebendo o contexto, depois disso ele vai ser atribuido a nossa classe e apartir dela vamos conseguir fazer as operações.
        
        public async Task AddAsync(ToDoItem item) // Adiciona
        {
            await _context.ToDoItens.AddAsync(item);
            await _context.SaveChangesAsync();



            //throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id) // Deleta por ID
        {
            var item = await _context.ToDoItens.FindAsync(id); // procura pelo id
            if(item != null) // se for diferente de nulo, ele deleta e salva as mudanças
            {
                _context.ToDoItens.Remove(item);
                await _context.SaveChangesAsync();
            }




            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<ToDoItem>> GetAllAsync() // Pega todos 
        {
            return await _context.ToDoItens.ToListAsync();




            //throw new NotImplementedException();
        }

        public async Task<ToDoItem> GetByIdAsync(int id) // Pesquisa por ID
        {

            return await _context.ToDoItens.FindAsync(id);


            //throw new NotImplementedException();
        }

        public async Task UpdateAsync(ToDoItem item) // Atualiza
        {

            _context.ToDoItens.Update(item); // Atualiza o item
            await _context.SaveChangesAsync(true); // Salva as mudanças


            //throw new NotImplementedException();
        }

        // Qual a função do Repositório?

        // ele vai ter uma conexão com o nosso Contexto(ToDoContext.cs)
        // sua função é se ligar ao contexto para termos acesso as operações do banco de dados, incluindo nossa tabela (ToDoItens)
        // a lógica para acessar o banco fica aqui, relacionado a lista de tarefas
        // agora vamos criar uma injeção de dependência
    }
}
