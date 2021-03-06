using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SP_MedicalGroup_API.ViewModel
{

        public class LoginViewModel
        {
            [Required(ErrorMessage = "Informe o e-mail do usuário!")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Informe a senha do usuário!")]
            public string Senha { get; set; }
        }
}
