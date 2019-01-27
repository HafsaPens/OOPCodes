using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_my
{
             class Graph
        {

            public int num_vertices;
            List<Vertex> vertices = new List<Vertex>();
            int[,] Adj_Matrix;
            public Graph(int no_vertices)
            {

                Adj_Matrix = new int[no_vertices, no_vertices];

            }

            public void AddVertex(string name)
            {
                vertices.Add(new Vertex(name));
                num_vertices++;
            }
            public void AddEdge(int V1, int V2)
            {
                Adj_Matrix[V1, V2] = 1;
                Adj_Matrix[V2, V1] = 1;

            }
            public int GetAdjVert(int v1)
            {
                for (int i = 0; i < Adj_Matrix.GetLength(0) - 1; i++)
                {
                    if (Adj_Matrix[v1, i] == 1 && vertices[i].Isvisited == false)
                    {
                        return i;
                    }
                }
                return -1;
            }
    }
    class Vertex
    {
        public string name;
        public bool Isvisited;

        public Vertex(string name)
        {
            this.name = name;
            this.Isvisited = false;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // string a = "55a";
            //int na= Convert.ToInt32(a);
            // Console.WriteLine(na);

            Graph g = new Graph(5);
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddEdge(0, 1);
            g.AddEdge(0, 3);
            g.AddEdge(3, 4);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
          
            Console.ReadKey();

        }
    }
}
