using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayTargetInfo : MonoBehaviour {

    public Target target;
    private Text text;

	// Use this for initialization
	void Start () {
        target.TargetChanged += updateTargetInfo;
        text = GetComponent<Text>();
	}

    private void updateTargetInfo(object sender, Target.TargetChangedEventArgs args)
    {
        string targetInfo;
        if(args.NewTarget == null)
        {
            targetInfo = "";
        }
        else
        {
            Vector3 tarPos = args.NewTarget.transform.position;
            targetInfo = string.Format("{0}({1}, {2}, {3})", args.NewTarget.gameObject.name, tarPos.x, tarPos.y, tarPos.z);
        }
        text.text = targetInfo;
    }
	
}
