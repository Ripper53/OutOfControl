using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterDelay : MonoBehaviour {
    public float Delay;

    private float timer;

    private void Awake() {
        timer = Delay;
    }

    private void Update() {
        if (timer > 0f)
            timer -= Time.deltaTime;
        else
            SceneManager.LoadSceneAsync(0);
    }

}
