using Com.HSJF.Infrastructure.Identity.Model;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.HSJF.HATS.FrameWork.DAL.SystemSetting.Users
{
    public class PermissionDAL
    {
        private Infrastructure.Identity.Context.IdentityContext context;
        private Infrastructure.Identity.Store.PermissionStore PermissionStore;
        private Infrastructure.Identity.Manager.PermissionManager PermissionManager;

        public PermissionDAL() : this(new Infrastructure.Identity.Context.IdentityContext())
        { }

        public PermissionDAL(Infrastructure.Identity.Context.IdentityContext conn)
        {
            context = conn;
            PermissionStore = new Infrastructure.Identity.Store.PermissionStore();
            PermissionManager = new Infrastructure.Identity.Manager.PermissionManager(PermissionStore);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<IdentityResult> CreateAsync(Permission model)
        {
            return Task<IdentityResult>.Run(() =>
            {
                return PermissionManager.CreateAsync(model);
            });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<IdentityResult> DeleteAsync(Permission model)
        {
            return Task<IdentityResult>.Run(() =>
            {
                return PermissionManager.DeleteAsync(model);
            });
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<IdentityResult> UpdateAsync(Permission model)
        {
            return Task<IdentityResult>.Run(() =>
            {
                return PermissionManager.DeleteAsync(model);
            });
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Permission> GetAll()
        {
            return PermissionManager.GetAll();
        }
    }
}