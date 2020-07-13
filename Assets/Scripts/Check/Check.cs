using UnityEngine;

public abstract class Check : MonoBehaviour {
    public Transform Transform;
    public LayerMask LayerMask;

    public abstract bool Evaluate();
}
