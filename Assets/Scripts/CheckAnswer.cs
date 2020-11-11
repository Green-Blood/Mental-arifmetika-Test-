using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    [SerializeField] private GameObject _blurPanel;

    public void PopUpOn()
    {
        _blurPanel.SetActive(true);
    }

    public void PopUpOff()
    {
        _blurPanel.SetActive(false);
    }

}
