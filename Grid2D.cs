using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��带 �����ϰ�, ����� �̿���带 �Ѱ��ֱ� ���� Ŭ����
public class Grid2D : MonoBehaviour
{
    public int nodeCount = 0;

    public Node nodePrefab;

    public Node[,] nodeArray;

    private Transform root;

    // �迭�� ������ ������� üũ�ϴ� �Լ�
    public bool CheckNode(int row, int column)
    {
        if ( row < 0 || column < 0 || row >= nodeCount || column >= nodeCount)
            return false;

        return true;
    }

    public Node FindNode( Vector3 screenPosition )
    {
        // ��尡 1000���� �鸸�� ��ȸ�ϰ� �ȴ�.
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
