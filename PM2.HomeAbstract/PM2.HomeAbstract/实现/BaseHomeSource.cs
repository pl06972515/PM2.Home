#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Collections.Generic;

#endregion

namespace PM2.Home.Abstract
{
    public abstract class BaseHomeSource : IHomeSource
    {
        public HomeOption HomeOption { get; }

        public IDictionary<string, object> Properties { get; }

        public BaseHomeSource(HomeOption option)
        { 

            this.HomeOption = option;
            this.Properties = new Dictionary<string, object>();

        }

        #region [最终]加载
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isReload">是否: 重新加载</param>
        /// <returns></returns>
        public async Task<IHomeModel> LoadAsync(bool isReload = false)
        {

            IHomeModel @model = null;
            if (isReload == true || !this.HomeOption.Cache.IsEnabled)
                @model = await this.LoadAsync();
            else
                @model = await this.HomeOption.Cache.Cache.GetOrAddValueAsync(this.HomeOption, () => this.LoadAsync());
            return @model;

        }

        /// <summary>
        /// 模板: 数据加载
        /// </summary>
        /// <returns></returns>
        protected abstract Task<IHomeModel> LoadAsync();

        #endregion

    }

}
