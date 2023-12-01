using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PathFinder : MonoBehaviour
{
    private Grid2D grid2D;

    // 닫힘목록 : 기준노드였던 노드의 집합
    private List<Node> closedList = new List<Node>();

    // 열린목록 : 기준노드의 이웃노드 집합
    // ★★★★ 중요 : 열린목록내에서 최소값을 찾아 새로운 기준노드를 지정한다. ★★★★
    private List<Node> openedList = new List<Node>();

    // 길을 찾았을 때의 경로
    private List<Node> pathList = new List<Node>();
    private DataComparer nodeComparer = new DataComparer();


    // -------------------시각적으로 보여주기 위한 데이터--------------------------//
    // 길찾기에서 시작점
    private Node startNode;

    // 길찾기에서 도착점
    private Node targetNode;

    // 현재 위치
    private Node currentNode;

    // 이전 위치
    private Node prevNode;

    private List<Node> currentNeighbours = new List<Node>();
    // -------------------시각적으로 보여주기 위한 데이터--------------------------//

    public void OnReset()
    {
        closedList.Clear();
        openedList.Clear();
        pathList.Clear();
        startNode = null;
        targetNode = null;
    }

    // 목표까지의 추정치값을 구하는 공식
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