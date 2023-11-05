using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalFunctions : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    
    public void LoadSceneAdditive(string name)
    {
        SceneManager.LoadScene(name, LoadSceneMode.Additive);
    }
    
    public void LoadSceneAdditive(int index)
    {
        SceneManager.LoadScene(index, LoadSceneMode.Additive);
    }
    
    public void UnloadScene(string name)
    {
        SceneManager.UnloadSceneAsync(name);
    }
    
    public void UnloadScene(int index)
    {
        SceneManager.UnloadSceneAsync(index);
    }
    
    public void UnloadSceneAdditive(string name)
    {
        SceneManager.UnloadSceneAsync(name, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
    
    public void UnloadSceneAdditive(int index)
    {
        SceneManager.UnloadSceneAsync(index, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
    
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
