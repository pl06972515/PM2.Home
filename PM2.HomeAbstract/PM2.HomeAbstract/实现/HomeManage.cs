#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

#endregion

namespace PM2.Home
{
    public class HomeManage: IHomeManage
    {

        private IEnumerable<IHomeConfig> _configs;
        public HomeManage(IEnumerable<IHomeConfig> configs)
            => this._configs = configs;

        /// <summary>
        /// [集合]
        /// </summary>
        public IEnumerable<IHomeSource> Sources 
            => this._configs.Select(x => x.Build());

        #region Get -> IHomeSource
        public IHomeSource this[string input]
           => this.GetSource(input);

        public IHomeSource GetSource(string input)
            => this.MatchSource(input);

        #endregion

    }

}
