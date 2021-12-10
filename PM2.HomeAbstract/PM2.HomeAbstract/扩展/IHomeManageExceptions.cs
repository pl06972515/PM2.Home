#region using
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using System.Collections.Generic;
using System.Collections.Concurrent;
using YamlDotNet.RepresentationModel;

#endregion

namespace PM2.Home
{
    public static class IHomeManageExceptions
    {

        #region [ 业务匹配 ]根据正则匹配模式

        public static IHomeSource MatchSource(this IHomeManage _this, string input)
            => _this.Sources.SingleOrDefault(x => x.HomeOption.IsMatch(input));

        public static bool TryGetSource(this IHomeManage _this, string input, out IHomeSource source)
            => (source = _this.MatchSource(input)) != null;

        #endregion

        /// <summary>
        /// 获取: 业务数据
        /// </summary>
        /// <param name="_this"></param>
        /// <param name="input"></param>
        /// <param name="isReload"></param>
        /// <returns></returns>
        public static Task<IHomeModel> LoadAsync(this IHomeManage _this, string input, bool isReload = false)
            => _this.MatchSource(input)?.LoadAsync(isReload);

    }

}
