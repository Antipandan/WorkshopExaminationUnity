using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string sceneName;

    public void LoadScene()
    {
        if (int.TryParse(sceneName, out int sceneIndex))
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
