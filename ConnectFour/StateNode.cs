using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class StateNode
    {
        public StateNode Parent;
        public LinkedList<StateNode> Children;
        public int[,] gridState;
        private bool max_node;
        private int value = 0;
        private int alpha;
        private int beta;
        public static int win_count = 0;


        public StateNode(int[,] state, StateNode _Parent)
        {
            gridState = state;
            Parent = _Parent;

            if (Parent != null)
                max_node = !Parent.getNodeType();
            else
                max_node = true;

            Children = new LinkedList<StateNode>();

            alpha = -1000;
            beta = 1000;

        }

        override public String ToString()
        {
            String grid = "";

            for (int i = 0; i < gridState.GetLength(0); i++)
            {
                for (int j = 0; j < gridState.GetLength(1); j++)
                {
                    grid += gridState[i, j];
                }
                grid += "\n";
            }
            return grid;
        }
        public int[,] getState()
        {
            return gridState;
        }
        public int getValue()
        {
            return value;

        }
        public int getAlpha()
        {
            return alpha;
        }
        public int getBeta()
        {
            return beta;
        }
        public void setValue(int val)
        {
            value = val;
        }
        public void setAlpha(int alpha)
        {
            this.alpha = alpha;
        }
        public void setBeta(int beta)
        {
            this.beta = beta;
        }
        public bool getNodeType()
        {
            return max_node;
        }
        public bool isTerminalNode()
        {
            if (Children == null || Children.Count == 0)
                return true;
            else
                return false;
        }
    }

}
