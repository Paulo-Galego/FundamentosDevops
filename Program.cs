var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); //Adicionando suporte ao razor pages
var app = builder.Build(); //criando a isntancia

//Asp.Net Razor pages (é mais simples, basicamente uma pagina interpolada de html e c#)
//é uma forma de estruturar a programãção é diferente de MVC


app.UseHttpsRedirection();

//arquivos estaticos, especificando a pasta wwwroot que será usada como padrão web,
////é a raiz da aplicação para arquivos estaticos, css, json, se tiver uma imagem o diretorio ficara dentro desta pasta.
app.UseStaticFiles(); 


app.UseRouting(); //
app.MapRazorPages(); //qual pagina eu chamo? Dentro da pasta pages localiza o arquivo index o método onGet

app.Run();
