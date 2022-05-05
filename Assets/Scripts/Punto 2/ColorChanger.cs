using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    void Start()
    {
        ClickManager.instance.OnButtonClicked += ChangeColor;
    }

    private void ChangeColor(int clickNumber)
    {
        Renderer matColor = GetComponent<Renderer>();
        switch (clickNumber)
        {
            case 1:
                matColor.material.color = Color.red;
                break;
            case 2:
                matColor.material.color = Color.green;
                break;
            case 3:
                matColor.material.color = Color.blue;
                break;
            case 4:
                matColor.material.color = Color.yellow;
                break;
        }
    }
}
