using MinimalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", ()=> "Ola pessoal");

app.MapPost("/login", (LoginDTO LoginDTO) => {
    if(LoginDTO.Email == "adm@teste.com" && LoginDTO.Senha == "123456"){
         return Results.Ok ("Login com sucesso");
    }
    else
         return Results.Unauthorized();

});


public class LoginDTO
{
  public string Email {get; set;} = default!;
  public string Senha {get; set;} = default !;
  
}