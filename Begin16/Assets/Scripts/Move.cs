using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
            return; // No gamepad connected.

        if (gamepad.rightTrigger.wasPressedThisFrame)
        {
            // 'Use' code here
        }

        Vector2 move = gamepad.leftStick.ReadValue();
        // 'Move' code here
        float h = Input.GetAxisRaw("vertical");
        float v = Input.GetAxisRaw("horizontal");
                gameObject.transform.position = new Vector2(transform.position.x + (h * speed),
               transform.position.y + (v * speed));
      
    }
}




