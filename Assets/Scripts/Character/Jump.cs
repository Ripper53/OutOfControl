using UnityEngine;

public class Jump : MonoBehaviour {
    public Rigidbody2D RB;
    public float Force;

    public void Execute() {
        RB.velocity = new Vector2(0f, Force);
    }

}
