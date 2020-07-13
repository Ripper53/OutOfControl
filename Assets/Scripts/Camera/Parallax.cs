using UnityEngine;

public class Parallax : MonoBehaviour {
    public Transform Transform, Target;
    public float Speed;
    private float latestPositionX;

    private void Awake() {
        latestPositionX = Transform.position.x;
    }

    private void LateUpdate() {
        Target.position += new Vector3((latestPositionX - Transform.position.x) * Speed, 0f);
        latestPositionX = Transform.position.x;
    }

}
