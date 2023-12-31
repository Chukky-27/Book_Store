﻿using MimaBookStore.Models.Domain;
using MimaBookStore.Repositories.Abstract;

namespace MimaBookStore.Repositories.Implementation
{
    public class AuthorService : IAuthorService
    {
        private readonly MyDbContext context;
        public AuthorService(MyDbContext context)
        {
            this.context = context;
        }
        public bool Add(Author model)
        {
            try
            {
                context.Authors.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;
                context.Authors.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Author FindById(int id)
        {
            return context.Authors.Find(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return context.Authors.ToList();
        }

        public bool Update(Author model)
        {
            try
            {
                context.Authors.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
