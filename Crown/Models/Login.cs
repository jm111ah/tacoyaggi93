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
        [Required(ErrorMessage = "Email을 입력해 주세요.")]
        [RegularExpression(@"^[0-9a-zA-Z]([-_.]?[0-9a-zA-Z])*@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "이메일 형식이 올바르지 않습니다.")]
        public string Email { get; set; }

        [MinLength(5,ErrorMessage = "비밀번호를 5글자 이상 입력해주세요.")]
        [Required(ErrorMessage = "비밀번호를 입력해 주세요.")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }
    }
}
