using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform Transform, Target;
    public float SmoothTime;
    private Vector2 currentVelocity = new Vector2(0f, 0f);

    private void LateUpdate() {
        Vector2 target = Vector2.SmoothDamp(Transform.position, Target.position, ref currentVelocity, SmoothTime * Time.deltaTime);
        Transform.position = new Vector3(target.x, target.y, Transform.position.z);
    }

}
