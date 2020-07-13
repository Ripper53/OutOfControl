using UnityEngine;

public class SwirlOutOfControl : IOutOfControl {
    public float Speed;

    public SwirlOutOfControl(float speed) => Speed = speed;

    public void LoseControl(Transform transform, float deltaTime) {
        transform.Rotate(Vector3.forward, Speed * deltaTime);
    }

}
