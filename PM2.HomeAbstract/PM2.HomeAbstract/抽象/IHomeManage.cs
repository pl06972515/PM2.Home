#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

#endregion

namespace PM2.Home.Abstract
{
    public interface IHomeManage
    {
        IEnumerable<IHomeSource> Sources { get; }
        IHomeSource this[string input] { get; }
        IHomeSource GetSource(string input);

    }

}
