using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o {0}")]
        [Display(Name = "Usuário")]
        public string UserName;
        [Required(ErrorMessage = "Informe o {0}")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password;
        public string ReturnUrl;
    }
}
