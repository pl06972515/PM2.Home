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
using System.Collections.ObjectModel;
using System.Reflection;

#endregion

namespace PM2.Home.Abstract
{
    public static class HomeOptionExceptions
    {

        /// <summary>
        /// 正则匹配
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsMatch(this HomeOption _this, string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, _this.Regex);
        }
        
    }

}
