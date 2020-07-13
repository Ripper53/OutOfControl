using UnityEngine.InputSystem;

public class MovementPlayerControls : PlayerControls {
    public Movement Movement;

    protected override void AddEvents(PlayerInput input) {
        input.Movement.Horizontal.performed += Horizontal_performed;
        input.Movement.Horizontal.canceled += Horizontal_canceled;
    }

    protected override void RemoveEvents(PlayerInput input) {
        input.Movement.Horizontal.performed -= Horizontal_performed;
        input.Movement.Horizontal.canceled -= Horizontal_canceled;
    }

    private void Horizontal_performed(InputAction.CallbackContext obj) {
        if (obj.ReadValue<float>() > 0f)
            Movement.Dir = Movement.Direction.Right;
        else
            Movement.Dir = Movement.Direction.Left;
    }

    private void Horizontal_canceled(InputAction.CallbackContext obj) {
        Movement.Dir = Movement.Direction.None;
    }

}
