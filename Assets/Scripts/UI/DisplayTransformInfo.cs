using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayTransformInfo : MonoBehaviour {

    public Transform transformInfo;
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (transformInfo.hasChanged)
        {
            Vector3 pos = transformInfo.position;
            text.text = string.Format("{0}({1}, {2}, {3})", transformInfo.gameObject.name, pos.x, pos.y, pos.z);
            transformInfo.hasChanged = false;
        }
	}
}
