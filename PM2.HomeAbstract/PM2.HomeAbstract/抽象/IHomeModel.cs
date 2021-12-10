using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PM2.Home
{

    public interface IHomeModel
    {

        /// <summary>
        /// 模型类型
        /// </summary>
        HomeType HomeType { set; get; }

        /// <summary>
        /// 自定义扩展
        /// </summary>
        IDictionary<string, object> Properties { get; }

        /// <summary>
        /// 最终: 数据源( 针对首页显示 )
        /// </summary>
        object Data { set; get; }

    }

}
