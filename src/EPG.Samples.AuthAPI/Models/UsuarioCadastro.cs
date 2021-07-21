using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPG.Samples.AuthAPI.Models
{
    public class UsuarioCadastro
    {        
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SenhaConfirmacao { get; set; }
    }
}
