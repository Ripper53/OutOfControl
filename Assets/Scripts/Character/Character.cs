using UnityEngine;

public class Character : MonoBehaviour, IDamageable {
    public CameraOutOfControl CameraOutOfControl;
    public Reserve Health;

    private void Awake() {
        Health.ModifiedValue += Health_ModifiedValue;
    }
    private void OnDestroy() {
        Health.ModifiedValue -= Health_ModifiedValue;
    }

    private void Health_ModifiedValue(Reserve source, ref int value) {
        if (value <= source.Min) {
            value = source.Max;
            const float speed = 500f;
            CameraOutOfControl.OutOfControl = new SwirlOutOfControl(Random.Range(0, 2) == 0 ? speed : -speed);
            CameraOutOfControl.TimeOut = Random.Range(2f, 4f);
        }
    }

    public void Damage(int damage) {
        Health.Value -= damage;
    }

}
