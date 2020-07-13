using UnityEngine;

public class Poison : MonoBehaviour {
    public float Speed;
    public float MinTimeOut, MaxTimeOut;

    private void OnTriggerEnter2D(Collider2D collision) {
        Character c = collision.GetComponent<Character>();
        if (c) {
            gameObject.SetActive(false);
            c.CameraOutOfControl.TimeOut = Random.Range(MinTimeOut, MaxTimeOut);
            c.CameraOutOfControl.OutOfControl = new SwirlOutOfControl(Random.Range(0, 2) == 0 ? Speed : -Speed);
        }
    }

}
