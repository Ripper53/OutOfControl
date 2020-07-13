using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D RB;

    public enum Direction { None, Right, Left };
    [System.NonSerialized]
    public Direction Dir = Direction.None;
}
