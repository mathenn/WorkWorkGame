using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{

    public int bloodCost;
    public int woodCost;
    public int crystalCost;

    Button button;

    void Start()
    {
        button = GetComponent<Button>();
    }



    void Update()
    {
        if (ResourceManager.instance.blood < bloodCost || ResourceManager.instance.wood < woodCost || ResourceManager.instance.crystal < crystalCost)
        {
            button.interactable = false;
        } else
        {
            button.interactable = true;
        }
    }

    public void RemoveResource()
    {
        ResourceManager.instance.AddResource("blood", -bloodCost);
        ResourceManager.instance.AddResource("wood", -woodCost);
        ResourceManager.instance.AddResource("crystal", -crystalCost);
    }
}
