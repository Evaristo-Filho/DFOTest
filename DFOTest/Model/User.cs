using DFOTest.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.ViewModel
{
    public class User : IUser
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(length: 50)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
