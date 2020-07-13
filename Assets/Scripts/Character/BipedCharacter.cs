using UnityEngine;

public class BipedCharacter : MonoBehaviour {
    public Rigidbody2D RB;
    public Jump Jump;
    public Fly Fly;
    public Check GroundCheck;

    [Header("Animator")]
    public SpriteRenderer SR;
    public Sprite GlideSprite, JumpSprite;
    public SpriteAnimator FlyAnimator;

    private void FixedUpdate() {
        FlyAnimator.enabled = false;

        if (GroundCheck.Evaluate()) {
            FlyAnimator.Restart();
            SR.sprite = JumpSprite;
            Jump.Execute();
            SR.sprite = JumpSprite;
        } else if (Fly.Execute()) {
            FlyAnimator.enabled = true;
        } else if (RB.velocity.y > 0f) {
            SR.sprite = JumpSprite;
        } else {
            SR.sprite = GlideSprite;
        }
    }

}
