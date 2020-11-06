using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragger : MonoBehaviour
{
    [SerializeField] private RectMask2D _maskTree;
    [SerializeField] private RectMask2D _mask;


    public void OnMouseDrag()
    {
        Debug.Log("Alo ya tut");
        _maskTree.enabled = true;
        _mask.enabled = false;

    }
    public void OnMouseUp()
    {

        _maskTree.enabled = false;
        _mask.enabled = true;
    }
}
