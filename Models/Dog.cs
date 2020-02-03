using System;
using System.ComponentModel.DataAnnotations;

namespace catsApi.Models
{
    public class Dog
    {
        public string Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(0, 1000)]
        public int Age { get; set; }
        public int Fetches { get; set; }
        public bool IsGood { get; } = true;

        public Dog()
        {
            Id = Guid.NewGuid().ToString();
        }
        public Dog(string name, int age)
        {

            Name = name;
            Age = age;
            Fetches = 0;
            Id = Guid.NewGuid().ToString(); //NOTE makes Globaly Unique ID
        }
    }
}