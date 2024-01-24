using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePopUp : MonoBehaviour
{
    public GameObject EtoInteract;


    private void OnTriggerEnter()
    {
        EtoInteract.SetActive(true);
    }

    private void OnTriggerExit()
    {
        EtoInteract.SetActive(false);
    }
}
