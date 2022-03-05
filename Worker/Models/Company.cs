using System.ComponentModel.DataAnnotations.Schema;
using Core.Models;

namespace Worker.Models
{
    public class Company : ICompany
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }
    }
}
