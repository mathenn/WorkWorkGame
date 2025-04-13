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

        if (_currentResource != null)
        {
            if (Time.time > _nextCollectTime)
            {
                _nextCollectTime = Time.time + timeBetweenCollect;
                _currentResource.resourceAmount -= collectAmount;
                ResourceManager.instance.AddResource(_currentResource.resourceType, collectAmount);
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