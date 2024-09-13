
using Encapsulation;

User user = new User()
{
    Name = "a",
    Surname = string.Empty,
    Email = "denizkaya@gmail.com",
    Password = "123456",
    FullName = "Deniz Kaya",
   
};
// User -> Name , Surname, Email, Password, FullName
Console.WriteLine(user.Name);
