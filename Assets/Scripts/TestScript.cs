using UnityEngine;
using System.Collections;
using Assets.GameData;

public class TestScript : MonoBehaviour {
    float time = 0f;
    int x = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if(time >= 1f)
        {
            time = 0f;
            x++;
            TestFactory.GenerateBlockDirt(x, 0, 0);
            TestFactory.GenerateBlockDirt(x, 1, 0);
            TestFactory.GenerateBlockDirt(x, 2, 0);
            TestFactory.GenerateBlockDirt(x, 3, 0);
            TestFactory.GenerateBlockDirt(x, 4, 0);
            TestFactory.GenerateBlockDirt(x, 5, 0);
            TestFactory.GenerateBlockDirt(x, 6, 0);
            TestFactory.GenerateBlockDirt(x, 7, 0);
            TestFactory.GenerateBlockDirt(x, 8, 0);
            TestFactory.GenerateBlockDirt(x, 9, 0);

        }
    }
}
