using System;
using System.ComponentModel.DataAnnotations;

namespace catsApi.Models
{
    public class Cat
    {
        public string Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(0, 1000)]
        public int Age { get; set; }
        public int Pets { get; set; }



        public Cat()
        {
            Id = Guid.NewGuid().ToString();
        }
        public Cat(string name, int age)
        {

            Name = name;
            Age = age;
            Pets = 0;
            Id = Guid.NewGuid().ToString(); //NOTE makes Globaly Unique ID
        }
    }
}