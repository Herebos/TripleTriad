using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rank : MonoBehaviour
{
    public int Top { get; }
    public int Right { get; }
    public int Bottom { get; }
    public int Left { get; }
    public Rank(int top, int right, int bottom, int left)
    {
        Top = top;
        Right = right;
        Bottom = bottom;
        Left = left;
    }

    private void Start()
    {
        Debug.Log(Top);
    }

}
