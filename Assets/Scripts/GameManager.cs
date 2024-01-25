using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int totalCollectibles = 5; // Set the total number of collectibles in your scene
    private int collectedCollectibles = 0;

    public Text collectiblesCountText;
    public GameObject activationObject;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectCollectible(int value)
    {
        collectedCollectibles += value;
        UpdateCollectiblesCount();

        if (collectedCollectibles >= totalCollectibles)
        {
            ActivateObject();
        }
    }

    void UpdateCollectiblesCount()
    {
        collectiblesCountText.text = "Collectibles: " + collectedCollectibles.ToString() + " / " + totalCollectibles.ToString();
    }

    void ActivateObject()
    {
        activationObject.SetActive(true);
    }
}