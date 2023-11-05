using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(gameObject); 
        } 
        else 
        { 
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT GAME");
    }
    
    public void QuitGame(float delay)
    {
        Debug.Log("QUIT GAME");
        StartCoroutine(IEQuitGame(delay));
    }
    
    private IEnumerator IEQuitGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        Application.Quit();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void LoadScene(string sceneName, float delay)
    {
        StartCoroutine(IELoadScene(sceneName, delay));
    }
    
    private IEnumerator IELoadScene(string sceenName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceenName);
    }
    
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
    public void LoadScene(int sceneIndex, float delay)
    {
        StartCoroutine(IELoadScene(sceneIndex, delay));
    }
    
    private IEnumerator IELoadScene(int sceneIndex, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneIndex);
    }
    
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void LoadNextScene(float delay)
    {
        StartCoroutine(IELoadNextScene(delay));
    }
    
    private IEnumerator IELoadNextScene(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void LoadSceneAdditive(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
    
    public void LoadSceneAdditive(string sceneName, float delay)
    {
        StartCoroutine(IELoadSceneAdditive(sceneName, delay));
    }
    
    private IEnumerator IELoadSceneAdditive(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
    
    public void LoadSceneAdditive(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }
    
    public void LoadSceneAdditive(int sceneIndex, float delay)
    {
        StartCoroutine(IELoadSceneAdditive(sceneIndex, delay));
    }
    
    private IEnumerator IELoadSceneAdditive(int sceneIndex, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }
    
    public void UnloadScene(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }
    
    public void UnloadScene(string sceneName, float delay)
    {
        StartCoroutine(IEUnloadScene(sceneName, delay));
    }
    
    private IEnumerator IEUnloadScene(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.UnloadSceneAsync(sceneName);
    }
    
    public void UnloadScene(int sceneIndex)
    {
        SceneManager.UnloadSceneAsync(sceneIndex);
    }
    
    public void UnloadScene(int sceneIndex, float delay)
    {
        StartCoroutine(IEUnloadScene(sceneIndex, delay));
    }
    
    private IEnumerator IEUnloadScene(int sceneIndex, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.UnloadSceneAsync(sceneIndex);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void ReloadScene(float delay)
    {
        StartCoroutine(IEReloadScene(delay));
    }
    
    private IEnumerator IEReloadScene(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
