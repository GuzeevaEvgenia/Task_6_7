using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Nodes { get; set; }

        public int GetLevelCount()
        {
            if (Nodes.Count == 0)
                return 1;
            else
            {
                int max = 0;
                for (int i = 0; i < Nodes.Count; i++)
                    max = Math.Max(max, Nodes[i].GetLevelCount());
                return max + 1;
            }
        }
        internal void GetWays(List<string> ways, List<char> way, int weight, bool positive)
        {
            int newWeight = weight + Value;
            if ((positive && newWeight < 0) || (!positive && newWeight > 0))
                return;
            if (Value == -1)
                way.Add('B');
            else if (Value == 1)
                way.Add('A');
            else 
                way.Add('C');
            if(Nodes.Count == 0)
            {
                if (newWeight == 0)
                    ways.Add(string.Join("", way));
            }
            else
                foreach (var item in Nodes)
                    item.GetWays(ways, way, newWeight, positive);
            way.RemoveAt(way.Count - 1);
        }
        internal void Generate(int N)
        {
            if (N == 0)
                return;
            Nodes.Add(new Node(1));
            Nodes.Add(new Node(-1));
            Nodes[0].Generate(N - 1);
            Nodes[1].Generate(N - 1);
        }

        public Node(int value = 0)
        {
            Value = value;
            Nodes = new List<Node>();
        }
    }
}
