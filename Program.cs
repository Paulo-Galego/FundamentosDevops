var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); //Adicionando suporte ao razor pages
var app = builder.Build(); //criando a isntancia

//Asp.Net Razor pages (� mais simples, basicamente uma pagina interpolada de html e c#)
//� uma forma de estruturar a program���o � diferente de MVC


app.UseHttpsRedirection();

//arquivos estaticos, especificando a pasta wwwroot que ser� usada como padr�o web,
////� a raiz da aplica��o para arquivos estaticos, css, json, se tiver uma imagem o diretorio ficara dentro desta pasta.
app.UseStaticFiles(); 


app.UseRouting(); //
app.MapRazorPages(); //qual pagina eu chamo? Dentro da pasta pages localiza o arquivo index o m�todo onGet

app.Run();
