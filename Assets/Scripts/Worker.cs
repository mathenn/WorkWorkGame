using UnityEngine;

public class Worker : MonoBehaviour
{

    bool _isSelected;
    public LayerMask resourceLayer;
    public float collectDistance;
    Resource _currentResource;

    public float timeBetweenCollect;
    float _nextCollectTime;
    public int collectAmount;

    void Start()
    {
        
    }

    void Update()
    {
        if (_isSelected == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            transform.position = mousePos;

            Collider2D col = Physics2D.OverlapCircle(transform.position, collectDistance, resourceLayer);

            if (col != null && _currentResource == null)
            {
                _currentResource = col.GetComponent<Resource>();
            } else
            {
                _currentResource = null;
            }
        }
    }

    private void OnMouseDown()
    { 
        _isSelected = true;
    }

    private void OnMouseUp()
    {
        _isSelected = false;
    }
}