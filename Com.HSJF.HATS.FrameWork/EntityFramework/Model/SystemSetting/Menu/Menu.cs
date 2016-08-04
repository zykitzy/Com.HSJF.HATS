using Com.HSJF.Infrastructure.DoMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.SystemSetting.Menu
{
    public class Menu : EntityModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public Guid? ParentID { get; set; }
        public virtual Menu ParentMenu { get; set; }
        public virtual ICollection<Menu> ChildMenu { get; set; }
    }
}