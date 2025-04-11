using UnityEngine;

public class Worker : MonoBehaviour
{

    bool isSelected;
    public LayerMask resourceLayer;
    public float collectDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            transform.position = mousePos;
        }
    }

    private void OnMouseDown()
    {
        isSelected = true;
    }

    private void OnMouseUp()
    {
        isSelected = false;
    }
}
