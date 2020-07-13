using UnityEngine;

public abstract class PlayerControls : MonoBehaviour {
    private PlayerInput input;

    private void Awake() {
        input = new PlayerInput();
        AddEvents(input);
    }
    private void OnEnable() => input.Enable();
    private void OnDisable() => input.Disable();

    private void OnDestroy() => RemoveEvents(input);

    protected abstract void AddEvents(PlayerInput input);
    protected abstract void RemoveEvents(PlayerInput input);

}
