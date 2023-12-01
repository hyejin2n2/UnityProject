using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public enum NodeType
{
    Normal,
    Wall,

}
// 우선순위 힙

public class Node : MonoBehaviour
{
    public NodeType nodeType = NodeType.Normal;

    // 소비되는 비용
    public int hCost;
    public int fCost;
    public int gCost;

    // 행과 열
    public int row;
    public int column;

    // 기준노드
    public Node parent;

    private TMP_Text fText;
    private TMP_Text hText;
    private TMP_Text gText;
    private Image image;

    public bool Contains( Vector3 screenPosition)
    {
        RectTransform rect = GetComponent<RectTransform>();

        return RectTransformUtility.RectangleContainsScreenPoint(rect, screenPosition);
    }

    public void SetGCost ( int cost )
    {
        gText.text = "G : " + cost;
        gCost = cost;
    }
    public void SetHCost ( int cost )
    {
        hText.text = "H : " + cost;
        hCost = cost;
    }
    public void UpdateFCost()
    {
        fCost = gCost + hCost;
        fText.text = "F : " + fCost;
    }

    public void SetColor( Color color)
    {
        if (image != null) image.color = color;
    }

    public void SestParent(Node parent)
    {
        this.parent = parent;
    }
    public void SetNode ( int row, int column )
    {
        this.row = row;
        this.column = column;
    }

    public void Initialize()
    {
        fText = transform.Find("F").GetComponent<TMP_Text>();
        hText = transform.Find("H").GetComponent<TMP_Text>();
        gText = transform.Find("G").GetComponent<TMP_Text>();

        image = GetComponent<Image>();
    }

    public void OnReset()
    {
        nodeType = NodeType.Normal;
        fText.text = "F : ";
        hText.text = "H : ";
        gText.text = "G : ";

        image.color = Color.white;
    }

}
