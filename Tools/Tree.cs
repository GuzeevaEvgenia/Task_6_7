using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{

   
    public class Tree
    {
        public Node Root { get; set; }
        public void Generate(int N)
        {
            Root.Nodes.Clear();
            Root.Generate(N - 1);
        }
        public string GetWays(bool positive)
        {
            List<string> Ways = new List<string>();
            List<char> Way = new List<char>();
            Root.GetWays(Ways, Way, 0, positive);
            return string.Join("\r\n", Ways);
        }
        public int GetLevelCount() => Root.GetLevelCount();

        public Tree()
        {
            Root = new Node();
        }
    }
}
