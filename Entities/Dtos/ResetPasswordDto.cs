using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String? UserName { get; init; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Parola alanı zorunlu")]
        public String? Password { get; init; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Parola onayı alanı zorunlu")]
        [Compare("Password",ErrorMessage ="Parolara uyuşmuyor")]
        public String? ConfirmPassword { get; init; }

    }
}
