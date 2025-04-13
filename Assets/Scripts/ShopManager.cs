using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public Ghost worker;
    public Ghost village;
    public Ghost tree;
    public Ghost crystal;
    public Ghost trap;
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnShopClick(string whatItem)
    {
        whatItem = whatItem.ToLower();

        if (whatItem == "worker")
            Instantiate(worker);
        else if (whatItem == "village")
            Instantiate(village);
        else if (whatItem == "tree")
            Instantiate(tree);
        else if (whatItem == "crystal")
            Instantiate(crystal);
        else if (whatItem == "trap")
            Instantiate(trap);
    }
}
