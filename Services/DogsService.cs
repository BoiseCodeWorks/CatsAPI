using System;
using System.Collections.Generic;
using catsApi.DB;
using catsApi.Models;

namespace catsApi.Services
{
    public class DogsService
    {
        public IEnumerable<Dog> Get()
        {
            return FAKEDB.Dogs;
        }

        public Dog GetById(string id)
        {
            Dog found = FAKEDB.Dogs.Find(d => d.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

        internal Dog Create(Dog newDog)
        {
            FAKEDB.Dogs.Add(newDog);
            return newDog;
        }

        internal Dog Edit(Dog dogUpdate)
        {
            var current = FAKEDB.Dogs.Find(d => d.Id == dogUpdate.Id);
            if (current == null)
            {
                throw new Exception("Invalid Id");
            }
            FAKEDB.Dogs.Remove(current);
            FAKEDB.Dogs.Add(dogUpdate);
            return dogUpdate;
        }

        internal String Delete(string id)
        {
            var current = FAKEDB.Dogs.Find(d => d.Id == id);
            if (current == null)
            {
                throw new Exception("Invalid Id");
            }
            FAKEDB.Dogs.Remove(current);
            return "Successfully Deleted";
        }
    }
}