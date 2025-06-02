using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReceiver : MonoBehaviour
{
    public Vector2 move;
    public Vector2 look;
    public bool isSprinting;
    public bool cursorLocked = true;
    
    public void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
    
    public void OnLook(InputValue value)
    {
        look = value.Get<Vector2>();
    }
    
    public void OnSprint(InputValue value)
    {
        isSprinting = value.isPressed;
    }
    
    private void OnApplicationFocus(bool hasFocus)
    {
        SetCursorState(cursorLocked);
    }

    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }
}
