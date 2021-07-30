using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Models
{
    public class Login
    {
        public string ID { get; set; }

        [Required(ErrorMessage = "Email을 입력해 주세요.")]
        public string Email { get; set; }

        [MinLength(5,ErrorMessage = "비밀번호를 5글자 이상 입력해주세요.")]
        [Required(ErrorMessage = "비밀번호를 입력해 주세요.")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }
    }
}
