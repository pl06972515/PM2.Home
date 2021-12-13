using System;

namespace PM2.Home.Abstract
{
    public class YAMLConfig
    {
        /// <summary>
        /// 配置类型
        /// </summary>
        public HomeType HomeType { get; set; }

        /// <summary>
        /// 匹配模式(正则表达式)
        /// </summary>
        public string Regex { get; set; }

        /// <summary>
        /// 配置完全限定名称(IHomeConfig)
        /// </summary>
        public string ConfigFullName { get; set; }

        /// <summary>
        /// 缓存配置(单位: 秒. -1 禁用缓存) 
        /// </summary>
        public int SlidingExpiration { get; set; }

        /// <summary>
        /// [配置]是否启用
        /// </summary>
        public bool IsEnable { set; get; }

    }

}
