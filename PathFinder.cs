using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PathFinder : MonoBehaviour
{
    private Grid2D grid2D;

    // ������� : ���س�忴�� ����� ����
    private List<Node> closedList = new List<Node>();

    // ������� : ���س���� �̿���� ����
    // �ڡڡڡ� �߿� : ������ϳ����� �ּҰ��� ã�� ���ο� ���س�带 �����Ѵ�. �ڡڡڡ�
    private List<Node> openedList = new List<Node>();

    // ���� ã���� ���� ���
    private List<Node> pathList = new List<Node>();
    private DataComparer nodeComparer = new DataComparer();


    // -------------------�ð������� �����ֱ� ���� ������--------------------------//
    // ��ã�⿡�� ������
    private Node startNode;

    // ��ã�⿡�� ������
    private Node targetNode;

    // ���� ��ġ
    private Node currentNode;

    // ���� ��ġ
    private Node prevNode;

    private List<Node> currentNeighbours = new List<Node>();
    // -------------------�ð������� �����ֱ� ���� ������--------------------------//

    public void OnReset()
    {
        closedList.Clear();
        openedList.Clear();
        pathList.Clear();
        startNode = null;
        targetNode = null;
    }

    // ��ǥ������ ����ġ���� ���ϴ� ����
    public int GetDistance ( Node a, Node b)
    {
        int x = Mathf.Abs(a.column - b.column);
        int y = Mathf.Abs(a.row - b.row);
        return 14 * Mathf.Min(x, y) + 10 * Mathf.Abs(x - y);
    }

    public void Ready ( Vector3 player, Vector3 target)
    {
        Node pNode = 
    }
}