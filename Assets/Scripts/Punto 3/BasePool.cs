using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePool : MonoBehaviour
{
    [SerializeField] Rigidbody proyectilePrefab;
    [SerializeField] int poolSize;
    List<Rigidbody> proyectiles;

    void Start()
    {
        PrepareProyectiles();
    }
    private void PrepareProyectiles()
    {
        proyectiles = new List<Rigidbody>();
        for (int i = 0; i < poolSize; i++) AddProyectile();
    }
    private void AddProyectile()
    {
        Rigidbody instance = Instantiate(proyectilePrefab);
        instance.gameObject.GetComponent<BaseProyectile>().OnCollision += RecicleProyectile;
        instance.gameObject.SetActive(false);
        proyectiles.Add(instance);
    }
    public Rigidbody GetProyectile()
    {
        if (proyectiles.Count == 0)
        {
            AddProyectile();
        }
        return AllocateProyectile();
    }
    public void RecicleProyectile(Rigidbody proyectile)
    {
        proyectile.gameObject.SetActive(false);
        proyectiles.Add(proyectile);
    }
    private Rigidbody AllocateProyectile()
    {
        Rigidbody proyectile = proyectiles[proyectiles.Count - 1];
        proyectiles.RemoveAt(proyectiles.Count - 1);
        proyectile.gameObject.SetActive(true);
        return proyectile;
    }

}
