using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    [SerializeField] private float loadDelay;

    // Changes the scene to the supplied scene
    public void GoToTheScene(string newSceneName)
    {
        StartCoroutine(GoToTheSceneCoroutine(newSceneName));
    }

    IEnumerator GoToTheSceneCoroutine(string newSceneName)
    {
        yield return new WaitForSeconds(loadDelay);
        SceneManager.LoadSceneAsync(newSceneName);
    }
}
