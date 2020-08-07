using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueueProject
{
    class Node
    {
        public int priority;
        public int info;
        public Node link;

        public Node(int i, int pr)
        {
            info = i;
            priority = pr;
            link = null;
        }
    }
}
