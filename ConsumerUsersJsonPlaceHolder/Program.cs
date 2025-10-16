using System.Net.Http;
using System.Text.Json;
using ConsumerUsersJsonPlaceHolder.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Consumindo API JsonPlaceholder ...\n");


using var http = new HttpClient();


var response = await http.GetAsync("https://jsonplaceholder.typicode.com/users");


response.EnsureSuccessStatusCode();


var contentStream = await response.Content.ReadAsStreamAsync();


var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var users = await JsonSerializer.DeserializeAsync<List<User>>(contentStream, options);

if (users is null || users.Count == 0)
{
    Console.WriteLine("Nenhum usuário encontrado.");
    return;
}


var first = users[0];


Console.WriteLine("Dados da PRIMEIRA pessoa:\n");
Console.WriteLine($"Nome: {first.name}");
Console.WriteLine($"Cidade: {first.address?.city}");
Console.WriteLine($"Empresa: {first.company?.name}");

Console.WriteLine("\nConcluído com sucesso ✅");
