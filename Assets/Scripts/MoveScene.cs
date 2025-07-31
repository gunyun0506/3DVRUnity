using System;
using UnityEngine;

public class MoveScene : MonoBehaviour
{
    public String sceneName;
    public void MoveToScene()
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogError("Scene name is not set.");
            return;
        }
        try
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
        catch (Exception ex)
        {
            Debug.LogError("Error occurred while loading scene: " + ex.Message);
        }
    }
    
}
