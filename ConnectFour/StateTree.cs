using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class StateTree
    {
        public StateNode root;
        private int alpha;
        private int beta;

        public StateTree(int m, int n)
        {
            int[,] initState = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    initState[i, j] = 0;

            root = new StateNode(initState, null);
            generateStates();
        }

        public void setNewRoot(int[,] newState)
        {
            int[,] state = CopyArray(newState);
            root = new StateNode(state, null);
            generateStates();
        }

        public int[,] getBestState(StateNode currentNode)
        {
            alpha = -1000;
            beta = 1000;
            int depth = 0;
            int nodeValue = maxValue(currentNode, depth, alpha, beta);
            int[,] nodeState = CopyArray(root.getState());

            foreach (StateNode child in currentNode.Children)
            {
                if (child.getValue() == nodeValue)
                {
                    nodeState = CopyArray(child.getState());
                    break;
                }
            }

            return nodeState;
        }

        private int maxValue(StateNode currentNode, int depth, int alpha, int beta)
        {
            if (currentNode.isTerminalNode())
            {
                currentNode.setAlpha(alpha);
                currentNode.setBeta(beta);
                return currentNode.getValue();
            }
            else
            {
                currentNode.setAlpha(alpha);
                currentNode.setBeta(beta);
                currentNode.setValue(-1000);

                foreach (StateNode child in currentNode.Children)
                {
                    currentNode.setValue(Math.Max(currentNode.getValue(), minValue(child, depth++, currentNode.getAlpha(), currentNode.getBeta())));

                    currentNode.setAlpha(Math.Max(currentNode.getAlpha(), currentNode.getValue()));

                    if (currentNode.getAlpha() >= currentNode.getBeta())
                        return currentNode.getValue();
                }
                return currentNode.getValue();
            }
        }

        private int minValue(StateNode currentNode, int depth, int alpha, int beta)
        {

            if (currentNode.isTerminalNode())
            {
                currentNode.setAlpha(alpha);
                currentNode.setBeta(beta);
                StateNode.win_count++;
                return currentNode.getValue();
            }
            else
            {
                currentNode.setAlpha(alpha);
                currentNode.setBeta(beta);
                currentNode.setValue(1000);

                foreach (StateNode child in currentNode.Children)
                {
                    currentNode.setValue(Math.Min(currentNode.getValue(), maxValue(child, depth++, currentNode.getAlpha(), currentNode.getBeta())));

                    currentNode.setBeta(Math.Min(currentNode.getBeta(), currentNode.getValue()));

                    if (currentNode.getBeta() <= currentNode.getAlpha())
                        return currentNode.getValue();
                }
                return currentNode.getValue();
            }
        }

        private void generateStates()
        {
            int MAX = 1;
            int MIN = 2;
            int TURNVAL = 0;
            bool MAXTURN = true;
            int CONNECTBY = 4;
            int M = 4;
            int N = 4;
            int MAXDEPTH = 9;//M * N;
            int DEPTH = 1;
            long count = 0;

            Queue<StateNode> currentLevel = new Queue<StateNode>();
            Queue<StateNode> nextLevel = new Queue<StateNode>();
            StateNode currentNode;
            currentLevel.Enqueue(root);

            //While the depth of the tree is less than or equal to 8
            //and the number of nodes at the current level of the tree
            //is greater than 0
            while (DEPTH <= MAXDEPTH && currentLevel.Count > 0)
            {
                if (MAXTURN)
                {
                    TURNVAL = 1;
                }
                else
                {
                    TURNVAL = 2;
                }
                //Switch turns in tree
                MAXTURN = !MAXTURN;

                //Probably not the best way to implement this, but
                //this loop will deplete the currentLevel, and then
                //repopulate it with the nodes from next level
                while (currentLevel.Count > 0)
                {
                    //Find a node that has children and while currentLevel has children
                    do
                    {
                        currentNode = currentLevel.Dequeue();
                    } while (currentNode.Children == null && currentLevel.Count > 0);

                    for (int i = 0; i < N; i++)
                    {
                        bool STATEFILLED = false;
                        int j = M - 1;
                        if (currentNode.gridState[0, i] == 0)
                        {
                            while (j >= 0 && !STATEFILLED)
                            {
                                if (currentNode.gridState[j, i] == 0)
                                {
                                    int[,] newState;
                                    StateNode newStateNode;

                                    newState = CopyArray(currentNode.gridState);
                                    newState[j, i] = TURNVAL;
                                    newStateNode = new StateNode(newState, currentNode);

                                    if (IsWinningTermState(newState, TURNVAL, CONNECTBY))
                                    {
                                        newStateNode.Children = null;
                                        if (TURNVAL == MAX)
                                            newStateNode.setValue(1 * DEPTH);
                                        else
                                            newStateNode.setValue(-1 * DEPTH);
                                    }
                                    else if (IsNonWinningTermState(newState, TURNVAL))
                                    {
                                        newStateNode.Children = null;
                                        newStateNode.setValue(0);
                                    }

                                    /*if (DEPTH >= (2 * CONNECTBY - 1))
                                    {
                                        if (IsWinningTermState(newState, TURNVAL, CONNECTBY))
                                        {
                                            newStateNode.Children = null;
                                            if (TURNVAL == MAX)
                                                newStateNode.setValue(1);
                                            else
                                                newStateNode.setValue(-1);

                                        }
                                        else if( DEPTH == MAXDEPTH )
                                        {
                                            newStateNode.Children = null;
                                            newStateNode.setValue(0);
                                        }
                                    }*/


                                    count++;
                                    currentNode.Children.AddLast(newStateNode);
                                    STATEFILLED = true;
                                }

                                j--;
                            }
                        }
                    }

                    foreach (StateNode n in currentNode.Children)
                    {
                        if (n.Children != null)
                            nextLevel.Enqueue(n);
                    }
                }

                while (nextLevel.Count > 0)
                    currentLevel.Enqueue(nextLevel.Dequeue());

                DEPTH++;
            }
        }

        public bool IsNonWinningTermState(int[,] state, int turnval)
        {

            for (int i = 0; i < state.GetLength(0); i++)
                for (int j = 0; j < state.GetLength(1); j++)
                    if (state[i, j] == 0)
                        return false;

            return true;
        }

        public void setRoot(StateNode current)
        {
            root = current;
            generateStates();
        }

        public override string ToString()
        {
            int numStates = 0;
            int i = 1;
            int j = 1;
            String states = "";
            Queue<StateNode> printQueue = new Queue<StateNode>();
            Queue<StateNode> toEnqueue = new Queue<StateNode>();
            printQueue.Enqueue(root);


            while (printQueue.Count > 0)
            {
                while (printQueue.Count > 0)
                {
                    if (printQueue.Peek().Children != null)
                    {
                        foreach (StateNode n in printQueue.Dequeue().Children)
                        {
                            states += "i = " + i + "; j = " + j + "\n";
                            states += "value = " + n.getValue() + "\n";
                            states += "Terminal State? " + n.isTerminalNode() + "\n";
                            states += "alpha = " + n.getAlpha() + "\n";
                            states += "beta = " + n.getBeta() + "\n";
                            states += n;
                            numStates++;
                            j++;

                            if (n.Children != null)
                            {
                                if (n.Children.Count > 0)
                                    toEnqueue.Enqueue(n);
                            }
                        }
                    }
                }
                while (toEnqueue.Count > 0)
                    printQueue.Enqueue(toEnqueue.Dequeue());
                i++;
                j = 1;
            }
            return states + "\nNumber of States: " + numStates;
        }

        public static int[,] CopyArray(int[,] oArray)
        {
            int length = oArray.GetLength(0);
            int[,] newArray = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    newArray[i, j] = oArray[i, j];
                }
            }

            return newArray;
        }

        public static bool IsWinningTermState(int[,] state, int turnval, int connectby)
        {
            if (horizontalWin(state, turnval, connectby))
                return true;
            else if (verticalWin(state, turnval, connectby))
                return true;
            else if (diagWin(state, turnval, connectby))
                return true;
            else
                return false;
        }

        public static bool horizontalWin(int[,] state, int turnval, int connectby)
        {
            bool winner;

            for (int i = 0; i < state.GetLength(0); i++)
            {
                winner = true;

                for (int j = 0; j < state.GetLength(1); j++)
                {
                    if (state[i, j] == turnval)
                        winner = winner && true;
                    else
                        winner = winner && false;
                }

                if (winner)
                    return true;
            }


            return false;
        }

        public static bool verticalWin(int[,] state, int turnval, int connectby)
        {
            bool winner;

            for (int j = 0; j < state.GetLength(1); j++)
            {
                winner = true;

                for (int i = 0; i < state.GetLength(0); i++)
                {
                    if (state[i, j] == turnval)
                        winner = winner && true;
                    else
                        winner = winner && false;
                }

                if (winner)
                    return true;
            }

            return false;
        }

        public static bool diagWin(int[,] state, int turnval, int connectby)
        {
            bool winner1 = true;
            bool winner2 = true;

            for (int i = 0; i < state.GetLength(0); i++)
            {
                if (state[i, i] == turnval)
                    winner1 = winner1 && true;
                else
                    winner1 = winner1 && false;

                if (state[i, state.GetLength(0) - 1 - i] == turnval)
                    winner2 = winner2 && true;
                else
                    winner2 = winner2 && false;
            }

            return winner1 || winner2;
        }
    }
}
