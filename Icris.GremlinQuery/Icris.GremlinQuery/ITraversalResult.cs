using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public interface ITraversalResult
    {
        Query count();
        IEdgeResult where(IParameterResult parameter);
        ITraversalResult limit(int pathLimit);
    }
}
