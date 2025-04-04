using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEjemploBibliotecaClase.Models
{
    [Table("Users")]
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string Nickname { get; set; }

        public bool Status { get; set; }

    }
}
