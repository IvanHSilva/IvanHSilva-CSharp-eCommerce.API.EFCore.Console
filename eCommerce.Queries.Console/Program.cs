using eCommerce.API.Database;
using eCommerce.Models;

// Context
eCommerceContext db = new eCommerceContext()!;

// Select all users
//List<User> users = db.Users.ToList();

//Console.WriteLine("Usuários:");
//foreach (User user in users) {
//    Console.WriteLine($"{user.Id} - {user.Name}");
//}

//Console.WriteLine();
Console.WriteLine("Usuário Id 2");
//User user2 = db.Users!.Find(2);
User user2 = db.Users!.FirstOrDefault(u => u.Id == 2);
Console.WriteLine($"{user2!.Id} - {user2.Name}");
Console.WriteLine();
Console.WriteLine("Primeiro Usuário");
User user1 = db.Users!.FirstOrDefault();
Console.WriteLine($"{user1!.Id} - {user1.Name}");
Console.WriteLine();
Console.WriteLine("Último Usuário");
user1 = db.Users!.OrderBy(u => u.Id).LastOrDefault();
Console.WriteLine($"{user1!.Id} - {user1.Name}");
Console.WriteLine();
Console.WriteLine("Sexo feminino:");
List<User> users = db.Users!.Where(u => u.Gender! == "F").OrderBy(u => u.Name).ToList();
foreach (User user in users) {
    Console.WriteLine($"{user.Name}");
}
Console.WriteLine();
Console.WriteLine("Buca por e-mail:");
user1 = db.Users!.SingleOrDefault(u => u.EMail == "fernanda.araujo@gmail.com");
Console.WriteLine($"{user1!.Id} - {user1.Name}");

Console.WriteLine();
Console.WriteLine("Quantidade de nomes com 'D':");
int regCount = db.Users!.Where(u => u.Name.Contains("d")).Count();
Console.WriteLine($"{regCount}");

Console.WriteLine();
Console.WriteLine("Maior Id:");
regCount = db.Users!.Max(u => u.Id);
Console.WriteLine($"{regCount}");

Console.WriteLine();
Console.WriteLine("Menor Data de Cadastro:");
DateTime date = db.Users!.Min(u => u.RegDate);
Console.WriteLine($"{date.ToString("dd/MM/yyyy")}");
