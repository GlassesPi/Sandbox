using System;

namespace Core.Models
{
    public interface ICompany
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
    }
}
