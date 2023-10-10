using MimaBookStore.Models.Domain;

namespace MimaBookStore.Repositories.Abstract
{
    public interface IBookService
    {
        bool Add(Book model);
        bool Delete(int id);
        bool Update(Book model);
        Book FindById(int id);
        IEnumerable<Book> GetAll();
    }
}
