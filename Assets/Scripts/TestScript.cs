using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System.Collections.Generic;

public class TestScript : MonoBehaviour {

    List<string> blockNames = new List<string>() { "Dirt", "Stone", "Gravel" };

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
            for (int y = 0; y < 10; y++)
            {
                TestFactory.GenerateBlock(blockNames[Random.Range(0, blockNames.Count)], new Vector3(x, y), this.transform);
            }

        }
    }
}
