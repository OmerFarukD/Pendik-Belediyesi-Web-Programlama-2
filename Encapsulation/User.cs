namespace Encapsulation;


// Name alanı minimum 2 karakterli olmalıdır.
// Surname alanı minimum 2 karakterli olmalıdır.
public class User
{

    private string name;


    public string Name
    {
        set
        {
            if (value.Length<2)
            {
                Console.WriteLine("Ad alanı minimum 2 karakterli olmalıdır.");
            }

            name = value;
        }

        get
        {
            return name;
        }
    }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }


    public override string ToString()
    {
        return $"Ad : {Name}, Soyad: {Surname}, Email: {Email}" +
            $"Parola : {Password}, Tam Ad: {FullName}";
    }

}
