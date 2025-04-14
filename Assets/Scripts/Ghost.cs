using UnityEngine;

public class Ghost : MonoBehaviour
{

    public GameObject objectToSpawn;

    void Start()
    {
        
    }


    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        transform.position = mousePos;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
