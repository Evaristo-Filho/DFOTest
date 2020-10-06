using System;
using System.Collections.Generic;
using System.Text;

namespace DFOTest.Entities
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string Address { get; set; }
    }
}
