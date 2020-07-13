using UnityEngine;

public class Wobble : MonoBehaviour {
    public Transform Transform;
    public float Angle, Time;

    private float timer = 0f;
    private float direction;

    private void Awake() {
        direction = Random.Range(0, 2) == 0 ? 1f : -1f;
    }

    private void Update() {
        if (timer > 0f) {
            timer -= UnityEngine.Time.deltaTime;
            Transform.Rotate(Vector3.forward, (Angle * direction) * UnityEngine.Time.deltaTime);
        } else {
            timer = Time;
            direction = -direction;
        }
    }

}
