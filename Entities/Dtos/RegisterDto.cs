using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage ="Kullanıcı adı alanı zorunlu")]
        public String?  UserName { get; init; }
        [Required(ErrorMessage = "Email alanı zorunlu")]
        public String? Email { get; init; }
        [Required(ErrorMessage = "Parola alanı zorunlu")]
        public String? Password { get; init; }

    }
}
