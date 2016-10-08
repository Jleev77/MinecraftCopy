using UnityEngine;
using System.Collections;
using System;

public class PlayerMoveController : MonoBehaviour, IMoveController
{
    public Vector3 GetInput()
    {
        Vector3 input = new Vector3();
        input.z = Input.GetAxisRaw("Vertical");
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetKeyDown(KeyCode.Space) ? 1 : 0;

        return input;
    }
}
