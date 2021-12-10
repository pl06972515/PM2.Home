using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM2.Home
{
    public interface IObjectCache
    {
        Task<IHomeModel> GetOrAddValueAsync(HomeOption option, Func<Task<IHomeModel>> func);

    }
}
