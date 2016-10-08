using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController)), RequireComponent(typeof(IMoveController))]
public class Mover : MonoBehaviour {

    public float AirSpeed = 1f;
    public float AirFriction = 1f;
    public float Speed = 5f;
    public float Friction = 5f;
    public float JumpSpeed = 10f;
    public float GravityMultiplier = 1f;

    private Vector3 _desiredMove = new Vector3();

    private IMoveController _moveController;
    private CharacterController _characterController;

    public void Start()
    {
        _moveController = GetComponent<IMoveController>();
        _characterController = GetComponent<CharacterController>();
    }


    public void Update()
    {
        Vector3 input = _moveController.GetInput();
        Vector3 horizontalMove = (transform.forward * input.z) + (transform.right * input.x);
        horizontalMove *= Speed;

        _desiredMove.z = horizontalMove.z;
        _desiredMove.x = horizontalMove.x;

        if (_characterController.isGrounded)
        {
            _desiredMove.y = input.y * JumpSpeed;
        }

        //Debug.Log(_currentMove.x + ", " + _currentMove.y + ", " + _currentMove.z);
        //Debug.Log(_characterController.isGrounded);
        _desiredMove.y += (Physics.gravity * GravityMultiplier * Time.deltaTime).y;
        _characterController.Move(_desiredMove * Time.deltaTime);
    }
}
