#region using
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

#endregion

namespace PM2.Home
{
    public interface IHomeConfig
    {
        IHomeSource Build();
    }
    
}
