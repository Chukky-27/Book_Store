using MimaBookStore.Models.Domain;

namespace MimaBookStore.Repositories.Abstract
{
    public interface IAuthorService
    {
        bool Add(Author model);
        bool Delete(int id);
        bool Update(Author model);
        Author FindById(int id);
        IEnumerable<Author> GetAll();
    }
}
