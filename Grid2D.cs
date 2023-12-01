using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 노드를 생성하고, 노드의 이웃노드를 넘겨주기 위한 클래스
public class Grid2D : MonoBehaviour
{
    public int nodeCount = 0;

    public Node nodePrefab;

    public Node[,] nodeArray;

    private Transform root;

    // 배열의 범위를 벗어났는지 체크하는 함수
    public bool CheckNode(int row, int column)
    {
        if ( row < 0 || column < 0 || row >= nodeCount || column >= nodeCount)
            return false;

        return true;
    }

    public Node FindNode( Vector3 screenPosition )
    {
        // 노드가 1000개면 백만번 순회하게 된다.
        for ( int r  = 0; r < nodeCount; ++r )
        {
            for ( int c =0; c < nodeCount; ++c )
            {
                if (nodeArray[r,c].Contains(screenPosition))
                {
                    return nodeArray[r,c];
                }
            }
        }

        return null;
    }

    public void OnReset()
    {
        foreach ( Node node in nodeArray)
            node.OnReset();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
