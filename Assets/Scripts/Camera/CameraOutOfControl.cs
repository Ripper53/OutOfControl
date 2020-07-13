using UnityEngine;

public class CameraOutOfControl : MonoBehaviour {
    public Transform Transform;
    [System.NonSerialized]
    public float TimeOut = 0f;
    public IOutOfControl OutOfControl = null;

    private void LateUpdate() {
        if (OutOfControl != null)
            OutOfControl.LoseControl(Transform, Time.deltaTime);

        if (TimeOut > 0f) {
            TimeOut -= Time.deltaTime;
            if (TimeOut <= 0f)
                OutOfControl = null;
        }
    }

}
