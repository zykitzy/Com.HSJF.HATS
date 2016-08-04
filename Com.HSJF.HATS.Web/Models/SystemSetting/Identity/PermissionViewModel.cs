using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Com.HSJF.HATS.Web.Models.SystemSetting.Identity
{
    public class PermissionViewModel
    {
        public string ID { get; set; }

        [Display(Name = "权限名称")]
        [Required]
        [MaxLength(255)]
        public string PermissionName { get; set; }

        [Display(Name = "父权限")]
        public string ParentPermission { get; set; }

        [Display(Name = "备注")]
        public string Description { get; set; }
    }
}