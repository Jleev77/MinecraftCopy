using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController), typeof(MoveProps))]
public class PlayerMoveController : MonoBehaviour {
    
    private MoveProps _moveProps;
    private CharacterController _characterController;
    private Vector3 _input = new Vector3();
    private Vector3 _currentMove = new Vector3();
    

	// Use this for initialization
	void Start () {
        _moveProps = GetComponent<MoveProps>();
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update () {
        updateMovement();
    }

    private void updateMovement()
    {
        _input.z = Input.GetAxisRaw("Vertical");
        _input.x = Input.GetAxisRaw("Horizontal");
        _input.y = Input.GetKeyDown(KeyCode.Space) ? 1 : 0;

        Vector3 horizontalMove = (transform.forward * _input.z) + (transform.right * _input.x);
        horizontalMove *= _moveProps.Speed;

        _currentMove.z = horizontalMove.z;
        _currentMove.x = horizontalMove.x;

        if (_characterController.isGrounded)
        {
            _currentMove.y = _input.y * _moveProps.JumpSpeed;
        }

        //Debug.Log(_currentMove.x + ", " + _currentMove.y + ", " + _currentMove.z);
        //Debug.Log(_characterController.isGrounded);
        _currentMove.y += (Physics.gravity * _moveProps.GravityMultiplier * Time.deltaTime).y;
        _characterController.Move(_currentMove * Time.deltaTime);
    }
}
