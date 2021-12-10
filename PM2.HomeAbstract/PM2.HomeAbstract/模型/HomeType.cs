#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

#endregion

namespace PM2.Home
{
    public enum HomeType
    {
        /// <summary>
        /// 自定义
        /// </summary>
        Custom,

        /// <summary>
        /// 标准报表
        /// </summary>
        Report,

        /// <summary>
        /// 柱状图
        /// </summary>
        HistoChart,

        /// <summary>
        /// 折线图
        /// </summary>
        LineChart,

        /// <summary>
        /// 饼状图
        /// </summary>
        CircChart,

        /// <summary>
        /// 仪表盘
        /// </summary>
        PanelChart

    }

}
