using UnityEngine;

public class CharacterAnimator : MonoBehaviour {
    public SpriteRenderer SR;
    public Movement Movement;

    private void Update() {
        switch (Movement.Dir) {
            case Movement.Direction.Right:
                SR.flipX = false;
                return;
            case Movement.Direction.Left:
                SR.flipX = true;
                return;
        }
    }

}
