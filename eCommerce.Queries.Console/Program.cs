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
User user2 = db.Users!.FirstOrDefault(u => u.Id == 200);
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
//List<User> users = db.Users!.Where(u => u.Gender! == "F").OrderBy(u => u.Name).ToList();
List<User> users = db.Users!.Where(u => u.Gender! == "F").OrderBy(u => u.Name).ToList();
foreach (User user in users) {
    Console.WriteLine($"{user.Name}");
}
