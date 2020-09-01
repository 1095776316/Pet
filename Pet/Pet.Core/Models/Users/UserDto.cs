using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pet.Core.Models.Users
{
    [Description("账户信息")]
    public class UserDto
    {
        [Display(Name = "编号")]
        public int? Id { get; set; }

        [Display(Name = "账号")]
        [Required(ErrorMessage = "{0},不能为空")]
        [StringLength(18, ErrorMessage = "{0},不能大于{1}")]
        public string Name { get; set; }

        [Display(Name = "NickName")]
        [Required(ErrorMessage = "{0} Is Required")]
        [StringLength(18, ErrorMessage = "{0},不能大于{1}")]
        public string NickName { get; set; }

        [Display(Name = "Eamil")]
        [EmailAddress]
        public string Eamil { get; set; }
        [Display(Name = "Eamil")]

        [Phone]
        public string PhoneNumber { get; set; }
        
        /// summary>
        /// 密码
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        [StringLength(11, ErrorMessage = "{0},不能小于{2}，最长{1}", MinimumLength = 6)]
        public string PassWord { get; set; }

        /// <summary>
        /// 确认密码
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("PassWord", ErrorMessage = "密码和确认密码不匹配")]
        public string ConfirmPassword { get; set; }

        public string UserTypeDesc { get; set; }
    }
}
