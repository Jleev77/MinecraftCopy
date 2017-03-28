using System;
using UnityEngine;

class PlayerAttackController : MonoBehaviour, IAttackController
{
    public bool IsAttacking()
    {
        return Input.GetKeyDown(KeyCode.Mouse0);
    }
}