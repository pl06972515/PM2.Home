using System;
using System.Collections.Generic;

namespace PM2.Home.Abstract
{
    public class CacheOption
    {
        public Func<string> Key { get; set; }
        public TimeSpan SlidingExpiration { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        public IObjectCache Cache { set; get; }

        /// <summary>
        /// 附加信息
        /// </summary>
        public IDictionary<string, object> Params { get; }
        public CacheOption()
        {
            this.Params = new Dictionary<string, object>(); 
        }

    }

}
