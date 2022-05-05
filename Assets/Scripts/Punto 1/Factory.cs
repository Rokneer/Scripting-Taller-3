using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public static Factory instance;
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject cube;
    [SerializeField] GameObject capsule;

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

    public GameObject BuildObjectSphere()
    {
        GameObject instance = Instantiate(sphere, Random.insideUnitSphere * 4 + transform.position, Quaternion.identity);
        return instance;
    }
    public GameObject BuildObjectCube()
    {
        GameObject instance = Instantiate(cube, Random.insideUnitSphere * 4 + transform.position, Quaternion.identity);
        return instance;
    }
    public GameObject BuildObjectCapsule()
    {
        GameObject instance = Instantiate(capsule, Random.insideUnitSphere * 4 + transform.position, Quaternion.identity);
        return instance;
    }
}
