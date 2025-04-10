var builder = WebApplication.CreateBuilder(args); // inicia a execu��o da API

// Add services to the container.


// Se��o de servi��s

builder.Services.AddControllers(); // adiciona os controlers que estiverem resgistrados, com a tag?
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); // ENDPOINTS
builder.Services.AddSwaggerGen(); // Adicionando o Swagger para testar // IMPORTANTE

var app = builder.Build(); // inicia a constru��o\execu��o da aplica��o

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())   // Ativa a API, usando o Swagger, sua interface
{
    app.UseSwagger();                         
    app.UseSwaggerUI();
}

app.UseAuthorization(); // se vai usar autentica��o

app.MapControllers(); // Mapeamento das Controlers

app.Run(); // Execu��o
