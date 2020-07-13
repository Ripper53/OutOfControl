using UnityEngine;

public class SpriteAnimator : MonoBehaviour {
    public SpriteRenderer SR;
    public Sprite[] Sprites;
    public float Interval;

    private int index = 0;
    private float timer = 0f;

    private void Update() {
        if (timer <= 0f) {
            timer = Interval;
            SR.sprite = Sprites[index++];
            if (index == Sprites.Length)
                Restart();
        } else {
            timer -= Time.deltaTime;
        }
    }

    public void Restart() => index = 0;

}
