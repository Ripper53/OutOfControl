using UnityEngine;

public abstract class Danger : MonoBehaviour {
    public Transform Transform;
    public LayerMask LayerMask;
    public int Damage;

    private void FixedUpdate() {
        IDamageable damageable = GetDamageable();
        if (damageable != null)
            damageable.Damage(Damage);
    }

    protected abstract IDamageable GetDamageable();

}
