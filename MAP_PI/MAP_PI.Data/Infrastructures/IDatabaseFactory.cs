using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_PI.Data.Infrastructures
{
    public interface IDatabaseFactory : IDisposable
    {
        MAP_PIContext DataContext { get; }
    }
}
