using System;
using System.Collections.Generic;
using catsApi.DB;
using catsApi.Models;

namespace catsApi.Services
{
    public class CatsService
    {
        public IEnumerable<Cat> Get()
        {
            return FAKEDB.Cats;
        }

        public Cat GetById(string id)
        {
            Cat found = FAKEDB.Cats.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

        internal Cat Create(Cat newCat)
        {
            FAKEDB.Cats.Add(newCat);
            return newCat;
        }
    }
}