using UnityEngine;

public class RotationOutOfControl : IOutOfControl {
    public float SlerpTime;

    public RotationOutOfControl(float slerpTime) => SlerpTime = slerpTime;

    private Quaternion targetAngle = Quaternion.identity;
    private float timer = 0f;

    public void LoseControl(Transform transform, float deltaTime) {
        if (timer > 0f) {
            timer -= deltaTime;
        } else {
            timer = Random.Range(5f, 10f);
            targetAngle = Quaternion.Euler(0f, 0f, Random.Range(-360f, 360f));
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, targetAngle, SlerpTime * deltaTime);
    }

}
