using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    public void PressToCreate()
    {
        Client.instance.InstantiateObject();
    }
}
