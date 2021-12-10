#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Caching;

#endregion

namespace PM2.Home
{
    public abstract class BaseHomeConfig : IHomeConfig
    {

        /// <summary>
        /// YAML
        /// </summary>
        protected YAMLConfig YAMLConfig { get; }

        public BaseHomeConfig(YAMLConfig config)
            => this.YAMLConfig = config;

        #region 首页: IHomeSource
        public virtual IHomeSource Build()
        {

            #region [ 用户 ]缓存配置

            CacheOption option = new CacheOption();
            if (this.YAMLConfig.SlidingExpiration != -1)
            {

                option.IsEnabled = true;
                option.Key = ()=> this.YAMLConfig.ConfigFullName + "::Cache";
                option.SlidingExpiration = TimeSpan.FromSeconds(this.YAMLConfig.SlidingExpiration);
                option.Cache = DefaultCache.Instance;

            }

            #endregion

            HomeOption homeOption = new HomeOption(
                this.YAMLConfig.Regex, 
                this.YAMLConfig.HomeType, 
                option);

            return this.Build(homeOption);

        }

        /// <summary>
        /// 模板创建
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        protected abstract IHomeSource Build(HomeOption option);

        #endregion

        #region private

        private class DefaultCache : IObjectCache
        {

            public static DefaultCache Instance = new DefaultCache();
            private readonly static ObjectCache _mCache = MemoryCache.Default;
            public async Task<IHomeModel> GetOrAddValueAsync(HomeOption option, Func<Task<IHomeModel>> func)
            {

                IHomeModel @model = null;
                string _key = option.Cache.Key.Invoke();

                //缓存控制
                if (_mCache.Contains(_key))
                    @model = (IHomeModel)_mCache.Get(_key);
                else
                {
                    try
                    {

                        @model = await func.Invoke();
                        _mCache.Add(
                            _key,
                            @model,
                            new CacheItemPolicy { SlidingExpiration = option.Cache.SlidingExpiration });

                    }
                    catch (Exception)
                    { }
                }

                return @model;

            }

        }

        #endregion

    }

}
