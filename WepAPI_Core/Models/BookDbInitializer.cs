using System.Data.Entity;

namespace WepAPI_Core.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Year = 1863 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Year = 1896 });
           
            base.Seed(db);
        }
    }
}