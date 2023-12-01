using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataComparer : IComparer<Node>
{
    public int Compare(Node left, Node right)
    {
        if ( left.fCost < right.fCost )
            return -1;
        else if ( left.fCost > right.fCost ) 
            return 1;
        else
        {
            if ( left.hCost < right.hCost )
                return -1;
            else if ( left.hCost > right.hCost )
                return 1;
        }
        return 0;
    }
}
