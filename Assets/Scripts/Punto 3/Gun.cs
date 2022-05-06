using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    BasePool currentPool;
    Proyectile1Pool pool_1;
    Proyectile2Pool pool_2;
    Proyectile3Pool pool_3;
    bool isLocked;
    int poolNumber;

    void Start()
    {
        pool_1 = GetComponent<Proyectile1Pool>();
        pool_2 = GetComponent<Proyectile2Pool>();
        pool_3 = GetComponent<Proyectile3Pool>();
        currentPool = pool_1;

        WallInteractions.instance.OnColliderDisable += lockShooting;
        WallInteractions.instance.OnColliderEnable += unlockShooting;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && !isLocked)
        {
            Rigidbody proyectile = currentPool.GetProyectile();
            proyectile.transform.position = transform.position;
        }
        if (Input.GetButtonDown("Fire2")) ChangeProyectile();
    }
    void ChangeProyectile()
    {
        poolNumber++;
        switch (poolNumber)
        {
            case 0:
                currentPool = pool_1;
                break;
            case 1:
                currentPool = pool_2;
                break;
            case 2:
                currentPool = pool_3;
                break;
        }
        if (poolNumber > 3) poolNumber = 0;
    }
    void lockShooting() { isLocked = true; }
    void unlockShooting() { isLocked = false; }
}
