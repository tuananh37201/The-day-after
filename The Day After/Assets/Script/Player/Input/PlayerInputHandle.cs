using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandle : MonoBehaviour
{
    public Vector2 MoveInput {  get; private set; }
    public bool isAttack { get; private set; }

    public void OnAttackInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isAttack = true;
        }
        if (context.canceled)
        {
            isAttack = false;
        }
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }
}
