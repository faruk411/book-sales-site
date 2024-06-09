using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models
{
    public class LoginModel
    {
        private string? _returnurl;

        [Required(ErrorMessage ="Ad alanı zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Şifre alanı zorunlu")]
        public string?  Password { get; set; }

        public string Returnurl
        {
            get
            {
                if (_returnurl is null)
                    return "/";
                else
                    return _returnurl;
            }
            set
            {
                _returnurl = value;
            }
        }
    }
}
