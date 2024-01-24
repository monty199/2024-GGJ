using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextAfterTime : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private List<string> sceneNames = new List<string>();
    private int currentSceneIndex = 0;

    private float timeElaspsed;

    void Start()
    {
        // Populate the sceneNames list with the names of the scenes from Build Settings
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(i));
            sceneNames.Add(sceneName);
        }
    }

    private void Update()
    {
        timeElaspsed += Time.deltaTime;
        if (timeElaspsed > delayBeforeLoading)
        {

            // Increment the current scene index
            currentSceneIndex = (currentSceneIndex + 1) % sceneNames.Count;

            // Load the next scene
            SceneManager.LoadScene(sceneNames[currentSceneIndex]);

        }
    }
}
