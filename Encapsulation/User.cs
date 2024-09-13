namespace Encapsulation;


// Name alanı minimum 2 karakterli olmalıdır.
// Surname alanı minimum 2 karakterli olmalıdır.
public class User
{

    private string name;
    private string surname;

    public  string Name
    {
        init
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
    public string Surname 
    {
        set
        {
            if(value.Length < 2)
            {
                Console.WriteLine("Soyad alanı 2 den büyük olmak zorundadır.");
                return;
            }
            surname = value;
        }
        get
        {
            return surname;
        }
    }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public string FullName {
        get {
            return $"{name} {surname}";
        }
    }


    public override string ToString()
    {
        return $"Ad : {Name}, Soyad: {Surname}, Email: {Email}" +
            $"Parola : {Password}, Tam Ad: {FullName}";
    }

}
