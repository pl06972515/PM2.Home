#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Concurrent;

#endregion

namespace PM2.Home
{
    public class HomeBuilder : IHomeBuilder
    {

        private readonly ConcurrentBag<IHomeConfig> _configs = new ConcurrentBag<IHomeConfig>();
        #region 单例模式
        private readonly static Lazy<IHomeBuilder> _instance = new Lazy<IHomeBuilder>(() =>
        {
            IHomeBuilder o = new HomeBuilder();
            return o;
        }, true);
        static HomeBuilder() { }
        public static IHomeBuilder Instance
        {
            get { return _instance.Value; }
        }

        #endregion

        public IDictionary<string, object> Properties { get; }
        private HomeBuilder()
            => this.Properties = new ConcurrentDictionary<string, object>();

        public IHomeBuilder Add(IHomeConfig config)
        {
            this._configs.Add(config);
            return this;
        }

        public IHomeManage Build()
            => new HomeManage(this._configs.ToList());


    }

}

