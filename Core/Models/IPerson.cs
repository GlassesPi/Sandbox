using System;

namespace Core.Models
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Group { get; set; }
    }
}
