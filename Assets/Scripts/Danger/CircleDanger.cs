using UnityEngine;

public class CircleDanger : Danger {
    public float Radius;

    protected override IDamageable GetDamageable() {
        Collider2D col = Physics2D.OverlapCircle(Transform.position, Radius, LayerMask);
        if (col)
            return col.GetComponent<IDamageable>();
        return null;
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected() {
        if (!Transform) return;
        Gizmos.color = Color.red;
        Gizmos.matrix = Matrix4x4.identity;
        Gizmos.DrawWireSphere(Transform.position, Radius);
    }
#endif

}
