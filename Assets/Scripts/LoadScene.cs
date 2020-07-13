using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public GameObject GameObject;
    public int SceneIndex;

    public void Execute() {
        GameObject.SetActive(false);
        SceneManager.LoadSceneAsync(SceneIndex);
    }

}
