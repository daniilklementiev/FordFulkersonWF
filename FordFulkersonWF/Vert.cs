using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordFulkersonWF
{
    public partial class Form1
    {
        public void InitVertices()
        {
            vertices = new Vertex[]
            {
               new Vertex
               {
                   VertexNumber = 1,
                   Connections = new List<ConnectedVertex>
                   {
                       new ConnectedVertex
                       {
                           VertexNumber = 2,
                           ThroughputFrom = 31,
                           ThroughputTo = 21
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 4,
                           ThroughputFrom = 6,
                           ThroughputTo = 36
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 5,
                           ThroughputFrom = 4,
                           ThroughputTo = 21
                       }
                   }
               },
               new Vertex
               {
                   VertexNumber = 2,
                   Connections = new List<ConnectedVertex>
                   {
                       new ConnectedVertex
                       {
                           VertexNumber = 1,
                           ThroughputFrom = 21,
                           ThroughputTo = 31
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 3,
                           ThroughputFrom = 23,
                           ThroughputTo = 34
                       }
                   }
               },
               new Vertex
               {
                   VertexNumber = 3,
                   Connections = new List<ConnectedVertex>
                   {
                       new ConnectedVertex
                       {
                           VertexNumber = 2,
                           ThroughputFrom = 35,
                           ThroughputTo = 23
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 4,
                           ThroughputFrom = 3,
                           ThroughputTo = 4
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 7,
                           ThroughputFrom = 1,
                           ThroughputTo = 10
                       }
                   }
               },
               new Vertex
               {
                   VertexNumber = 4,
                   Connections = new List<ConnectedVertex>
                   {
                       new ConnectedVertex
                       {
                           VertexNumber = 1,
                           ThroughputFrom = 36,
                           ThroughputTo = 6
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 3,
                           ThroughputFrom = 4,
                           ThroughputTo = 3
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 5,
                           ThroughputFrom = 21,
                           ThroughputTo = 5
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 6,
                           ThroughputFrom = 1,
                           ThroughputTo = 8
                       }
                   }
               },
               new Vertex
               {
                   VertexNumber = 5,
                   Connections = new List<ConnectedVertex>
                   {
                       new ConnectedVertex
                       {
                           VertexNumber = 1,
                           ThroughputFrom = 21,
                           ThroughputTo = 4
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 4,
                           ThroughputFrom = 5,
                           ThroughputTo = 21
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 6,
                           ThroughputFrom = 2,
                           ThroughputTo = 23
                       }
                   }
               },
               new Vertex
               {
                   VertexNumber = 6,
                   Connections = new List<ConnectedVertex>
                   {
                       new ConnectedVertex
                       {
                           VertexNumber = 4,
                           ThroughputFrom = 8,
                           ThroughputTo = 1
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 5,
                           ThroughputFrom = 23,
                           ThroughputTo = 2
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 7,
                           ThroughputFrom = 4,
                           ThroughputTo = 44
                       }
                   }
               },
               new Vertex
               {
                   VertexNumber = 7,
                   Connections = new List<ConnectedVertex>
                   {
                       new ConnectedVertex
                       {
                           VertexNumber = 3,
                           ThroughputFrom = 10,
                           ThroughputTo = 1
                       },
                       new ConnectedVertex
                       {
                           VertexNumber = 6,
                           ThroughputFrom = 44,
                           ThroughputTo = 4
                       },
                   }
               }

            };
        }
    }
}

