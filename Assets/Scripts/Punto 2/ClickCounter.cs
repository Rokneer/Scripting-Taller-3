using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numberText;
    void Start()
    {
        ClickManager.instance.OnButtonClicked += DebugLogClickNumber;
    }

    private void DebugLogClickNumber(int clickNumber)
    {
        numberText.text = clickNumber.ToString();
        Debug.Log(clickNumber);
    }
}
