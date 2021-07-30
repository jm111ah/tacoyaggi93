using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Models
{
    public class SignUp
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "Email을 입력해 주세요.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Name을 입력해 주세요.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "성별을 입력해 주세요.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Password를 입력해 주세요.")]
        [DataType(DataType.Password)]
        [MinLength(5,ErrorMessage = "Password는 최소 6글자 이상 입력해주세요.")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password가 일치하지 않습니다.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
