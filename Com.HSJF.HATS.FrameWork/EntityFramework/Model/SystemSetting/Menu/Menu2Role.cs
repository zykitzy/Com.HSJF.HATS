using Com.HSJF.Infrastructure.DoMain;
using System;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.SystemSetting.Menu
{
    public class Menu2Role : EntityModel
    {
        public Guid ID { get; set; }
        public string RoleID { get; set; }
        public string MenuID { get; set; }
    }
}