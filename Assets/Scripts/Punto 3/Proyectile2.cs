using UnityEngine;

public class Proyectile2 : BaseProyectile
{
    public override void ProyectileAction(Collision collision)
    {
        base.ProyectileAction(collision);
        if (collision.gameObject.CompareTag("Wall")) WallInteractions.instance.DisableWallCollider();
    }
}
