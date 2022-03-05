using System.ComponentModel.DataAnnotations.Schema;
using Core.Models;

namespace Worker.Models
{
    public class Person : IPerson
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("group")]
        public string Group { get; set; }
    }
}
