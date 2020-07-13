using UnityEngine;

public class BoxDanger : Danger {
    public Vector2 Size;

    protected override IDamageable GetDamageable() {
        Collider2D col = Physics2D.OverlapBox(Transform.position, Size, 0f, LayerMask);
        if (col)
            return col.GetComponent<IDamageable>();
        return null;
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected() {
        if (!Transform) return;
        Gizmos.color = Color.red;
        Gizmos.matrix = Matrix4x4.identity;
        Gizmos.DrawWireCube(Transform.position, Size);
    }
#endif

}
