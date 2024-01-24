using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    public GameObject EtoInteract;
    public GameObject Player, NPC;
    public GameObject dialogueBox;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Player.SetActive(false);
            NPC.SetActive(false);
            dialogueBox.SetActive(true);
        }
        else
        {
            Player.SetActive(true);
            NPC.SetActive(true);
            dialogueBox.SetActive(false);
        }
    }
}
