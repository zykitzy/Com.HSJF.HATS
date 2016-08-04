using System.Data.Entity.ModelConfiguration;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.SystemSetting.Menu.Mapping
{
    internal class Menu2RoleMap : EntityTypeConfiguration<Menu2Role>
    {
        public Menu2RoleMap()
        {
            this.HasKey(t => t.ID);
            this.ToTable("Menu2Role", "sysset");
        }
    }
}