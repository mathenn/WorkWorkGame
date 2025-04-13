using UnityEngine;

public class Resource : MonoBehaviour
{
    public string resourceType;
    public int resourceAmount;

    void Start()
    {
        
    }


    void Update()
    {
        if (resourceAmount <= 0)
        {
            Destroy(gameObject);
        }
    }
}
