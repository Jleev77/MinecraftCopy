using UnityEngine;
using System.Collections;
using System;

public class Target : MonoBehaviour {

    public float MaxTargetDistance = 5f;
    public Transform CurrentTarget { get; private set; }

    private Camera _camera;

	// Use this for initialization
	void Start () {
        _camera = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 cameraCenter = _camera.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, _camera.nearClipPlane));
        Ray ray = new Ray(cameraCenter, _camera.transform.forward);
        RaycastHit hit = new RaycastHit();
        Transform newTarget = Physics.Raycast(ray, out hit, MaxTargetDistance) ? hit.transform : null;

        if(CurrentTarget != newTarget)
        {
            CurrentTarget = newTarget;

            if(TargetChanged != null)
            {
                TargetChanged(this, new TargetChangedEventArgs(newTarget));
            }
        }
	}

    public delegate void TargetChangedEvent(object sender, TargetChangedEventArgs targetChangedEventArgs);
    public event TargetChangedEvent TargetChanged;

    public class TargetChangedEventArgs : EventArgs
    {
        public TargetChangedEventArgs(Transform newTarget)
        {
            NewTarget = newTarget;
        }
        public Transform NewTarget { get; protected set; }
    }
}
