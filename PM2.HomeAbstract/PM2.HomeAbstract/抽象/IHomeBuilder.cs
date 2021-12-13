#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Concurrent;

#endregion

namespace PM2.Home.Abstract
{
    public interface IHomeBuilder
    {
        /// <summary>
        /// 共享信息
        /// </summary>
        IDictionary<string, object> Properties { get; }

        IHomeBuilder Add(IHomeConfig config);

        /// <summary>
        /// 首页: 管理
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        IHomeManage Build();

    }

}
