#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

#endregion

namespace PM2.Home.Abstract
{

    public class HomeOption
    {
        /// <summary>
        /// 报表类型
        /// </summary>
        public HomeType HomeType { get; }

        /// <summary>
        /// 匹配模式
        /// </summary>
        public string Regex { get; }

        /// <summary>
        /// 缓存配置
        /// </summary>
        public CacheOption Cache { get; }

        public HomeOption(string regex, HomeType @type, CacheOption cache)
        {
            this.Regex = regex;
            this.HomeType = @type;
            this.Cache = cache;
        }

    }

}
