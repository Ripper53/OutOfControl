using UnityEngine;
using UnityEngine.Events;

public class LerpTo : MonoBehaviour {
    public Transform Transform;
    public Point[] Points;

    private Point currentPoint;
    private int index = 0;
    private float timer = 0f;

    [System.Serializable]
    public struct Point {
        public Vector2 Position;
        public float LerpTime, Delay;
        public UnityEvent Events;
    }

    private void FixedUpdate() {
        if (timer > 0f) {
            timer -= Time.fixedDeltaTime;
        } else {
            currentPoint = Points[index++];
            timer = currentPoint.Delay;
            currentPoint.Events?.Invoke();
            if (index == Points.Length)
                index = 0;
        }
        Vector2 pos = Vector2.Lerp(Transform.position, currentPoint.Position, currentPoint.LerpTime);
        Transform.position = new Vector3(pos.x, pos.y, Transform.position.z);
    }

}
