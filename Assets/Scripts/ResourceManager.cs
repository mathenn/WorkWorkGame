using Mono.Cecil;
using UnityEngine;
using TMPro;

public class ResourceManager : MonoBehaviour
{

    public int wood;
    public int blood;
    public int crystal;

    public TMP_Text woodDisplay;
    public TMP_Text bloodDisplay;
    public TMP_Text crystalDisplay;

    public static ResourceManager instance;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void AddResource(string resourceType, int amount)
    {
        if (resourceType == "wood")
        {
            wood += amount;
            woodDisplay.text = wood.ToString();
        }

        if (resourceType == "blood")
        {
            blood += amount;
            bloodDisplay.text = blood.ToString();
        }

        if (resourceType == "crystal")
        {
            crystal += amount;
            crystalDisplay.text = crystal.ToString();
        }

    }
}
