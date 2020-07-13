using UnityEngine;

public class HeartBeat : MonoBehaviour {
    public Transform Transform;
    public float MinScale, MaxScale, Offset;
    public float Speed;

    private bool shrinking = false;

    private void Update() {
        float scale;
        if (shrinking) {
            scale = Mathf.Lerp(Transform.localScale.x, MinScale, Speed * Time.deltaTime);
            if (scale <= MinScale + Offset) {
                scale = MinScale;
                shrinking = false;
            }
        } else {
            scale = Mathf.Lerp(Transform.localScale.x, MaxScale, Speed * Time.deltaTime);
            if (scale >= MaxScale - Offset) {
                scale = MaxScale;
                shrinking = true;
            }
        }
        Transform.localScale = new Vector3(scale, scale, Transform.localScale.z);
    }

}
