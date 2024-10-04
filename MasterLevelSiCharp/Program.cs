using MasterLevelSiCharp.Models;
using MasterLevelSiCharp.Models.Transformers;
using MasterLevelSiCharp.Models.Transformers.Mappers;

//Book book = new Book()
//{
//    Id = 1,
//    Title = "Test",
//    Description = "Test",
//};

//Categgory category = new Categgory()
//{
//    Id = 1,
//    Name = "Dram",
//    Books = new List<Book>()
//};


//category = category + book;

//category = category + book;

//category = category + book;

//category = category + book;

//category = category + book;



//category = category - book;

//category = category - book;

//category = category - book;

//category.Books.ForEach(x => Console.WriteLine(x));

//void AddBookToCategory(Book book)
//{
//    category.Books.Add(book);
//}

CreateElmaDto dto = new CreateElmaDto()
{
    Color = Color.Red,
    KgPrice = 45,
    SellerName = "Muhammed Talha Özer",
    Type = "Yeşil Elma"
};

//Elma elma = ElmaMapper.ConvertToEntity(dto);
//ElmaResponseDto response = ElmaMapper.ConvertToResponseDto(elma);
//Console.WriteLine(response);

Elma elma = (Elma)dto; // explicit dönüşüm
ElmaResponseDto response = elma; // implicit dönüşüm
Console.WriteLine(response);

