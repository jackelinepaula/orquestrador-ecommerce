var builder = WebApplication.CreateBuilder(args);

//Ativa o sistema de Controllers, que é o que queremos usar.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

//Diz à aplicação para mapear as URLs para os métodos nos seus arquivos de Controller.
//Esta é a linha que faz o OrquestradorController ser encontrado.
app.MapControllers();

app.Run();