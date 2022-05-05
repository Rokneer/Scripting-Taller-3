using UnityEngine;

public class Client : MonoBehaviour
{
    public static Client instance;
    private int i = 0;
    //[SerializeField] GameObject currentObject;

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

    public void InstantiateObject()
    {
        if (i >= 3) i = 0;
        //if(currentObject != null) Destroy(currentObject);
        if (i == 0) Factory.instance.BuildObjectSphere();
        else if (i == 1) Factory.instance.BuildObjectCube();
        else if(i == 2) Factory.instance.BuildObjectCapsule();
        i++;
    }
}
