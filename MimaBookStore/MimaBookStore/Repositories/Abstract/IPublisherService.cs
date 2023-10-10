using MimaBookStore.Models.Domain;

namespace MimaBookStore.Repositories.Abstract
{
    public interface IPublisherService
    {
        bool Add(Publisher model);
        bool Delete(int id);
        bool Update(Publisher model);
        Publisher FindById(int id);
        IEnumerable<Publisher> GetAll();
    }
}
