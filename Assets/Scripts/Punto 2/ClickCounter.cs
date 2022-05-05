using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    void Start()
    {
        ClickManager.instance.OnButtonClicked += DebugLogClickNumber;
    }

    private void DebugLogClickNumber(int clickNumber)
    {
        Debug.Log(clickNumber);
    }
    //Poner algo en pantalla
}
