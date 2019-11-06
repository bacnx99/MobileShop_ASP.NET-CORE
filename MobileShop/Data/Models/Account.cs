using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class Account
    {
        [Key]
        public int Account_Id { get; set; }

        [Required(ErrorMessage = "Email không được để trống.")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Email không hợp lệ.")]
        public string Account_Email { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống.")]
        public string Account_FullName { get; set; }

        [Required(ErrorMessage = "Password không được để trống.")]
        [DataType(DataType.Password)]
        public string Account_Password { get; set; }

        [NotMapped]
        [Compare("Account_Password", ErrorMessage = "Nhập lại mật khẩu không khớp.")]
        public string Account_ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        [RegularExpression(@"^[0-9]", ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string Account_Phone { get; set; }

        public string Account_Sex { get; set; }

        public string Account_Permission { get; set; }

        public bool? Account_IsBlocked { get; set; }
    }
}
