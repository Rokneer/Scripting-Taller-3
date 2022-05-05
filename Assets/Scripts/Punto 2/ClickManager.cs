using System;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public static ClickManager instance;
    private int clickNumber = 0;
    public event Action<int> OnButtonClicked;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickNumber++;
            if (clickNumber >= 5) clickNumber = 1;   
            OnButtonClicked(clickNumber);
        }
    }
}
