using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

// Context
eCommerceContext db = new eCommerceContext()!;

// Select all users
//List<User> users = db.Users.ToList();

//Console.WriteLine("Usuários:");
//foreach (User user in users) {
//    Console.WriteLine($"{user.Id} - {user.Name}");
//}

#region OrDefault
////Console.WriteLine();
//Console.WriteLine("Usuário Id 2");
////User user2 = db.Users!.Find(2);
//User user2 = db.Users!.FirstOrDefault(u => u.Id == 2);
//Console.WriteLine($"{user2!.Id} - {user2.Name}");
//Console.WriteLine();
//Console.WriteLine("Primeiro Usuário");
//User user1 = db.Users!.FirstOrDefault();
//Console.WriteLine($"{user1!.Id} - {user1.Name}");
//Console.WriteLine();
//Console.WriteLine("Último Usuário");
//user1 = db.Users!.OrderBy(u => u.Id).LastOrDefault();
//Console.WriteLine($"{user1!.Id} - {user1.Name}");
//Console.WriteLine();
//Console.WriteLine("Sexo feminino:");
//List<User> users = db.Users!.Where(u => u.Gender! == "F").OrderBy(u => u.Name).ToList();
//foreach (User user in users) {
//    Console.WriteLine($"{user.Name}");
//}
//Console.WriteLine();
//Console.WriteLine("Buca por e-mail:");
//user1 = db.Users!.SingleOrDefault(u => u.EMail == "fernanda.araujo@gmail.com");
//Console.WriteLine($"{user1!.Id} - {user1.Name}");
#endregion

#region CountMaxMin
//Console.WriteLine();
//Console.WriteLine("Quantidade de nomes com 'D':");
//int regCount = db.Users!.Where(u => u.Name.Contains("d")).Count();
//Console.WriteLine($"{regCount}");

//Console.WriteLine();
//Console.WriteLine("Maior Id:");
//regCount = db.Users!.Max(u => u.Id);
//Console.WriteLine($"{regCount}");

//Console.WriteLine();
//Console.WriteLine("Menor Data de Cadastro:");
//DateTime date = db.Users!.Min(u => u.RegDate);
//Console.WriteLine($"{date.ToString("dd/MM/yyyy")}");
#endregion

#region Where
//Console.WriteLine();
//Console.WriteLine("Lista de Usuários que começam com a letra 'A':");
////users = db.Users.Where(u => EF.Functions.Like(u.Name, "A%")).ToList();
//List<User> users = db.Users!.Where(u => u.Name.StartsWith("A")).ToList();
//int regCount = users.Count;
//foreach (User user in users) {
//    Console.WriteLine($"{user.Name}");
//}
//Console.WriteLine($"Total: {regCount}");
//Console.WriteLine();
//Console.WriteLine("Lista de Usuários que terminam com a letra 'A':");
////users = db.Users.Where(u => EF.Functions.Like(u.Name, "A%")).ToList();
//users = db.Users!.Where(u => u.Name.EndsWith("A")).ToList();
//regCount = users.Count;
//foreach (User user in users) {
//    Console.WriteLine($"{user.Name}");
//}
//Console.WriteLine($"Total: {regCount}");
//Console.WriteLine();
//Console.WriteLine("Lista de Usuários que contém a letra 'A':");
////users = db.Users.Where(u => EF.Functions.Like(u.Name, "A%")).ToList();
//users = db.Users!.Where(u => u.Name.Contains("A")).ToList();
//regCount = users.Count;
//foreach (User user in users) {
//    Console.WriteLine($"{user.Name}");
//}
//Console.WriteLine($"Total: {regCount}");
#endregion

#region OrderBy
//Console.WriteLine();
//Console.WriteLine("Lista de Usuários em ordem alfabética:");
//List<User> users = db.Users!.OrderBy(u => u.Name).ToList();
////int regCount = users.Count;
//foreach (User user in users) {
//    Console.WriteLine($"{user.Name}");
//}
//Console.WriteLine();
//Console.WriteLine("Lista de Usuários em ordem alfabética inversa:");
//users = db.Users!.OrderByDescending(u => u.Name).ToList();
////int regCount = users.Count;
//foreach (User user in users) {
//    Console.WriteLine($"{user.Name}");
//}
//Console.WriteLine();
//Console.WriteLine("Lista de Usuários em ordem alfabética por sexo:");
//users = db.Users!.OrderBy(u => u.Gender).ThenBy(u => u.Name).ToList();
////int regCount = users.Count;
////Console.WriteLine("Sexo feminino:");
//foreach (User user in users) {
//    //if (user.Gender == "M") Console.WriteLine("Sexo masculino:");
//    Console.WriteLine($"{user.Name}");
//}
//Console.WriteLine();
#endregion

#region Include
//Console.WriteLine();
//Console.WriteLine("Lista de Usuários com contatos:");
//List<User> users = db.Users!.Include(u => u.Contact).Include(u => u.Addresses!.Where(a => a.State == "SE")).ToList();
////int regCount = users.Count;
//foreach (User user in users) {
//    Console.WriteLine($"{user.Name}");
//    if (user.Contact != null) Console.WriteLine($"{user.Contact!.CellPhone}");
//    Console.WriteLine($"{user.Addresses!.Count} endereço(s) ");
//    if (user.Addresses!.Count > 0) {
//        foreach (Address address in user.Addresses) {
//            Console.WriteLine($"{address.Street}, {address.Number} - {address.District} - {address.City} - {address.State}");
//        }
//    }
//}
//Console.WriteLine();
#endregion

#region ThenInclude
//Console.WriteLine();
//Console.WriteLine("Lista de telefones dos contatos:");
//List<Contact> contacts = db.Contacts!.Include(c => c.User).
//    ThenInclude(u => u!.Addresses).ToList();
//foreach (Contact contact in contacts) {
//    Console.WriteLine($"{contact.CellPhone} - {contact.User!.Name} " +
//        $"/ endereços: {contact.User!.Addresses!.Count}");
//}
//Console.WriteLine();
#endregion

#region AutoInclude
//db.ChangeTracker.Clear();
//Console.WriteLine();
//Console.WriteLine("Lista de usuários com autoinclude:");
//List<User> users = db.Users!.ToList();
//foreach (User user in users) {
//    Console.WriteLine($"{user.Name} - {user.Contact?.CellPhone}");
//}
//Console.WriteLine();
#endregion

#region ExplicitLoad
//db.ChangeTracker.Clear();
//Console.WriteLine();
//Console.WriteLine("Lista de usuários sem explicit load:");
//User user = db.Users!.IgnoreAutoIncludes().FirstOrDefault(u => u.Id == 1);
//Console.WriteLine($"{user!.Name} - Tel: {user.Contact?.CellPhone} - End: {user.Addresses?.Count}");
//db.Entry(user).Reference(u => u.Contact).Load();
//db.Entry(user).Collection(u => u.Addresses!).Load();
//Console.WriteLine();
//Console.WriteLine("Lista de usuários com explicit load:"); 
//Console.WriteLine($"{user!.Name} - Tel: {user.Contact?.CellPhone} - End: {user.Addresses?.Count}");
//List<Address> addresses = db.Entry(user).Collection(u => u.Addresses!).Query().
//    Where(a => a.State == "SP").ToList();
//Console.WriteLine("Endereços de São Paulo:");
//foreach (Address address in addresses) {
//    Console.WriteLine($"{address.Street}, {address.Number} - {address.District} - {address.City} - {address.State}");
//}
//Console.WriteLine();
#endregion

#region LazyLoad
//db.ChangeTracker.Clear();
//Console.WriteLine();
//Console.WriteLine("Lista de usuários com lazy load:");
//User user = db.Users!.Find(1);
//Console.WriteLine($"{user!.Name} - Tel: {user.Contact?.CellPhone} - End: {user.Addresses?.Count}");
//Console.WriteLine();
#endregion

#region SplitQuery
//db.ChangeTracker.Clear();
//Console.WriteLine();
//Console.WriteLine("Lista de usuários com Split Query:");
//User user = db.Users!.AsSplitQuery().Include(u => u.Addresses).FirstOrDefault(u => u.Id == 1);
//Console.WriteLine($"{user!.Name} - Tel: {user.Contact?.CellPhone} - End: {user.Addresses?.Count}");
//Console.WriteLine();
#endregion

#region Take+Skip
db.ChangeTracker.Clear();
Console.WriteLine();
Console.WriteLine("Lista de usuários com Paginação:");
List<User> users = db.Users!.Skip(1).Take(5).ToList();
foreach (User user in users) { 
    Console.WriteLine($"{user!.Name} - Tel: {user.Contact?.CellPhone} - End: {user.Addresses?.Count}");
   }
Console.WriteLine();
#endregion
