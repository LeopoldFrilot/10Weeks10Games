using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerSimplified : MonoBehaviour
{
    public void LoadCertainSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void LoadFirstScene()
    {
        LoadCertainSceneByIndex(0);
    }

    public void LoadNextScene(int numScenes = 1 /* Allows you to skip over more than one scene, can be negative */)
    {
        int curScene = SceneManager.GetActiveScene().buildIndex;
        int destinationScene = curScene + numScenes;

        if(destinationScene < 0 || destinationScene > SceneManager.sceneCount - 1)
        {
            Debug.LogError("ERROR: Called scene that doesn't exist");
            return;
        }

        LoadCertainSceneByIndex(destinationScene);
    }
}
