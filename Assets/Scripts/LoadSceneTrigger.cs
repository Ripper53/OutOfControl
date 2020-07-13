using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneTrigger : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<IDamageable>() != null)
            SceneManager.LoadScene(2);
    }

}
