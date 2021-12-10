#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

#endregion

namespace PM2.Home
{
    public interface IHomeSource
    {

        HomeOption HomeOption { get; }

        /// <summary>
        /// 自定义扩展
        /// </summary>
        IDictionary<string, object> Properties { get; }
        
        /// <summary>
        /// 数据加载
        /// </summary>
        /// <param name="isReload">True: 强制加载</param>
        /// <returns></returns>
        Task<IHomeModel> LoadAsync(bool isReload = false);

    }

}
