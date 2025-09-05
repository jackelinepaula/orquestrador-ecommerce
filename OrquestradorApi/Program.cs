var builder = WebApplication.CreateBuilder(args);

//Ativa o sistema de Controllers, que � o que queremos usar.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

//Diz � aplica��o para mapear as URLs para os m�todos nos seus arquivos de Controller.
//Esta � a linha que faz o OrquestradorController ser encontrado.
app.MapControllers();

app.Run();