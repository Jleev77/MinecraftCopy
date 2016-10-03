using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class TestBuildPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int x = 0; x < 20; x++)
        {
            for (int z = 0; z < 20; z++)
            {
                TestFactory.GenerateBlock("Dirt", new Vector3(x, 0, z), transform);

                if(z == 0 || z == 19 || x == 0 || x == 19)
                {
                    TestFactory.GenerateBlock("Stone", new Vector3(x, 1, z), transform);
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
