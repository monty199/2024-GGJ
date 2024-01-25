using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int collectibleValue = 1; // Value of each collectible
    public GameObject activationObject; // Object to activate when all collectibles are collected

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }

    void Collect()
    {
        GameManager.instance.CollectCollectible(collectibleValue);
        gameObject.SetActive(false); // Optional: Deactivate the collected collectible
    }
}