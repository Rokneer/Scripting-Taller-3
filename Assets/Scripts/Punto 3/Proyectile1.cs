using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile1 : BaseProyectile
{
    public override void ProyectileAction(Collision collision)
    {
        base.ProyectileAction(collision);
        Debug.Log("Proyectile Impact");
    }
}
