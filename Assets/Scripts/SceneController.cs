using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public SceneAsset scene;

    private void Start()
    {
        gameObject.GetComponent<Button>()?.onClick.AddListener(LoadScene);        
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(scene.name);
    }
}