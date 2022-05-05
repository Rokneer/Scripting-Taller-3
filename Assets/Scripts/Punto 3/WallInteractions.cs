using System;
using UnityEngine;

public class WallInteractions : MonoBehaviour 
{
    public static WallInteractions instance;
    BoxCollider wallCollider;
    public Action OnColliderDisable;
    public Action OnColliderEnable;
    float timer;
    bool isColliderDisabled;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        else
        {
            instance = this;
        }   
    }
    private void Start()
    {
        wallCollider = GetComponent<BoxCollider>();
    }
    private void Update()
    {
        if (timer > 0 && isColliderDisabled) timer -= Time.deltaTime;
        else
        {
            wallCollider.enabled = true;
            OnColliderEnable?.Invoke();
        }
    }
    public void DisableWallCollider()
    {
        wallCollider.enabled = false;
        OnColliderDisable?.Invoke();
        isColliderDisabled = true;
        timer = 1;
    }
}