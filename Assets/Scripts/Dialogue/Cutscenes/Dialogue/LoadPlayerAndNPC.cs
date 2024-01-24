using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPlayerAndNPC : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    

    private float timeElaspsed;

    public string sceneToLoad;
    public string exitName;

    private void Update()
    {
        timeElaspsed += Time.deltaTime;
        if (timeElaspsed > delayBeforeLoading)
        {
            PlayerPrefs.SetString("LastExitName", exitName);
            SceneManager.LoadScene(sceneToLoad);

        }
    }
}
