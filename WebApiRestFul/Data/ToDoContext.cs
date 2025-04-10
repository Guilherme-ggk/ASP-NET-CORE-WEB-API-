using Microsoft.EntityFrameworkCore;
using WebApiRestFul.Models;

namespace WebApiRestFul.Data
{
    public class ToDoContext : DbContext // O DbContext pertence ao entityFramework, fazemos a herança para fazer a ponte ao EntityFramework  
    {
        public  DbSet<ToDoItem> ToDoItens { get; set; } // Propriedade para construir nossa tabela

        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) // Construtor para receber nossas opçoes relacionadas ao banco de dados
        {

        }


        // Construtor , DbContextOptions<NossaClasse> options, passa as options pelo Construtor do DbContext, ele vai receber para fazer essa configuração para nós
    }
}
