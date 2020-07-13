using UnityEngine;

public class Fly : MonoBehaviour {
    public Rigidbody2D RB;
    public Movement Movement;
    public Vector2 Force;

    public bool Execute() {
        switch (Movement.Dir) {
            case Movement.Direction.Right:
                RB.velocity = Force;
                return true;
            case Movement.Direction.Left:
                RB.velocity = new Vector2(-Force.x, Force.y);
                return true;
        }
        return false;
    }

}
