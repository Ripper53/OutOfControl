using UnityEngine;

public interface IOutOfControl {
    void LoseControl(Transform transform, float deltaTime);
}
