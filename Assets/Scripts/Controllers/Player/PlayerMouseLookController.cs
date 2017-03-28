using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MouseLookProps))]
public class PlayerMouseLookController : MonoBehaviour {

    private Camera _camera;
    private MouseLookProps _mouseLookProps;

    private Vector2 _input = new Vector2();

	// Use this for initialization
	void Start () {
        _camera = transform.parent.GetComponentInChildren<Camera>();
        _mouseLookProps = GetComponent<MouseLookProps>();
	}
	
	// Update is called once per frame
	void Update () {
        _input.x = Input.GetAxis("Mouse X");
        _input.y = Input.GetAxis("Mouse Y");
        //Debug.Log("X: " + _input.x);
        //Debug.Log("Y: " + _input.y);

        _camera.transform.Rotate(new Vector3(-_input.y * _mouseLookProps.RotateSpeed, 0));
        _camera.transform.localRotation = ClampRotationAroundXAxis(_camera.transform.localRotation);

        transform.parent.Rotate(new Vector3(0, _input.x * _mouseLookProps.RotateSpeed));

    }

    Quaternion ClampRotationAroundXAxis(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, _mouseLookProps.MinRotation, _mouseLookProps.MaxRotation);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }
}
