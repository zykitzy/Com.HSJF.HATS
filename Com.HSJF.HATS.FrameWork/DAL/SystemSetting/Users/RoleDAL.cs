using Com.HSJF.Infrastructure.Identity.Manager;
using Com.HSJF.Infrastructure.Identity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.HSJF.HATS.FrameWork.DAL.SystemSetting.Users
{
    public class RoleDAL
    {
        private RoleManager RoleManager;

        public RoleDAL()
        {
            RoleManager = new RoleManager();
        }

        public async Task<bool> Add(Role role)
        {
            var result = await RoleManager.Create(role);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 添加权限角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public async Task<bool> Update(Role role)
        {
            var result = await RoleManager.Update(role);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 修改权限角色
        /// </summary>
        /// <param name="roleid"></param>
        /// <returns></returns>
        public async Task<bool> Update(string roleid)
        {
            var result = await RoleManager.Update(new Role() { ID = roleid });
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除权限角色
        /// </summary>
        /// <param name="roleid"></param>
        /// <returns></returns>
        public async Task<bool> Delete(string roleid)
        {
            var result = await RoleManager.Delete(new Role() { ID = roleid });
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 查询全部权限角色
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Role>> GetAll()
        {
            var result = await RoleManager.GetAll();
            return result;
        }

        /// <summary>
        /// 根据ID查询权限角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Role> GetRole(string id)
        {
            var result = await RoleManager.GetRole(id);
            return result;
        }

        /// <summary>
        /// 根据权限角色ID查询对应权限
        /// </summary>
        /// <param name="roleid"></param>
        /// <returns></returns>
        public IEnumerable<Permission> GetPermissionByRole(string roleid)
        {
            return RoleManager.GetPermissionByRole(roleid);
        }

        public async Task<bool> FlushPermission(string roleid, params string[] roles)
        {
            await RoleManager.FlushPermission(roleid, roles);
            return true;
        }

        /// <summary>
        /// 根据用户ID查询对应权限角色
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public IEnumerable<Role> GetRoleByUser(string userid)
        {
            var result = RoleManager.GetRoleByUser(userid);
            return result;
        }
    }
}