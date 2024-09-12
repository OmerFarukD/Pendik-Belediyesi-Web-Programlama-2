// kullanıcıdan 1 ile 4 arasında bir rakam alınız
// 1-> İlkbahar
// 2-> Yaz
// 3 -> SonBahar
// 4 -> Kış

Console.WriteLine("Lütfen bir rakam giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

string mevsim = string.Empty;

//switch (sayi)
//{
//    case 1:
//        mevsim = "İlkbahar";
//        break;
//    case 2:
//        mevsim = "Yaz";
//        break;
//    case 3:
//        mevsim = "Sonbahar";
//        break;
//    case 4:
//        mevsim = "Kış";
//        break;
//    default:
//        Console.WriteLine("Lütfen 1 ile 4 arasında bir rakam giriniz.");
//        break;
//}

// switch expresion

mevsim = sayi switch
{
    1 => "İlkbahar",
    2 => "Yaz",
    3 => "Sonbahar",
    4 => "Kış",
    _ => "Lütfen 1 ile 4 arasında bir değer giriniz."
};



Console.WriteLine(mevsim);



