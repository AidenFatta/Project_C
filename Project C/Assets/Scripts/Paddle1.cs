using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle1 : PaddleMovement
{
    private Vector2 moveInput;

    public void OnP1Move(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    protected override Vector2 GetMoveInput()
    {
        return moveInput;
    }
}