using UnityEngine;

public class Proyectile3 : BaseProyectile
{
    [SerializeField] ParticleSystem particles;
    MeshRenderer meshRenderer;

    public override void ProyectileAction(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            particles.Play();
            if (meshRenderer == null) meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.enabled = false;
            Invoke("Recicle", 2f);
        }
    }
    public override void MakeVisible()
    {
        base.MakeVisible();
        if(meshRenderer == null) meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;
    }
}
