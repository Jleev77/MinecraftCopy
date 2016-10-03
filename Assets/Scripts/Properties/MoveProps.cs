using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class MoveProps : MonoBehaviour {

    public float AirSpeed = 1f;
    public float AirFriction = 1f;
    public float Speed = 5f;
    public float Friction = 5f;
    public float JumpSpeed = 10f;
    public float GravityMultiplier = 1f;
}
