using UnityEngine;

public class Ghost : MonoBehaviour
{
    // to add: object to spawn and etc

    void Start()
    {
        
    }


    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        transform.position = mousePos;
    }
}
