using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile3 : BaseProyectile
{
    ParticleSystem particles;
    MeshRenderer meshRenderer;

    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }
    public override void ProyectileAction(Collision collision)
    {
        base.ProyectileAction(collision);
        particles.Play();
        if(meshRenderer == null) meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        Invoke("Recicle", 1f);
    }
    public override void MakeVisible()
    {
        base.MakeVisible();
        if(meshRenderer == null) meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;
    }
}
