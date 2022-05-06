using System;
using UnityEngine;

public abstract class BaseProyectile : MonoBehaviour
{
    Rigidbody bulletRB;
    [SerializeField] float force;
    public event Action<Rigidbody> OnCollision;

    void Awake()
    {
        bulletRB = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        bulletRB.AddForce(Vector3.forward * force);
        MakeVisible();
    }
    private void OnCollisionEnter(Collision collision)
    {
        ProyectileAction(collision);
    }
    public virtual void ProyectileAction(Collision collision)
    {
        OnCollision?.Invoke(bulletRB);
    }
    public virtual void MakeVisible()
    {
    }
    public void Recicle()
    {
        OnCollision?.Invoke(bulletRB);
    }
}
