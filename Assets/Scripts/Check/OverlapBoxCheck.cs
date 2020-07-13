using UnityEngine;

public class OverlapBoxCheck : Check {
    public Vector2 Size;

    public override bool Evaluate() {
        return Physics2D.OverlapBox(Transform.position, Size, 0f, LayerMask);
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected() {
        if (!Transform) return;
        Gizmos.color = Color.green;
        Gizmos.matrix = Transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, Size);
    }
#endif

}
