using System.Collections.Generic;
using catsApi.Models;

namespace catsApi.DB
{
    static class FAKEDB
    {
        public static List<Cat> Cats { get; set; } = new List<Cat>(){
                new Cat("Mr. Snibbley", 207),
                new Cat("Garfield", 56),
                new Cat("Felix", 3),
                new Cat("Snuffles", 1)
            }; //NOTE TEMPORARY, DO NOT DO WHEN WE HAVE A DATABASE

        public static List<Dog> Dogs { get; set; } = new List<Dog>(){
                new Dog("Lassie", 20),
                new Dog("Air Bud", 56),
                new Dog("Kujo", 300),
                new Dog("Marley", 12)
            };
    }
}