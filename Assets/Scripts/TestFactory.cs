using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    static class TestFactory
    {
        private static Dictionary<string, GameObject> blockDictionary = new Dictionary<string, GameObject>();

        static TestFactory()
        {
            foreach(var go in Resources.LoadAll<GameObject>("BlockPrefabs/"))
            {
                blockDictionary.Add(go.name, go);
            }
        }
        public static void GenerateBlock(string blockName, Vector3 position, Transform parent = null)
        {
            GameObject go = GameObject.Instantiate(blockDictionary[blockName]);
            go.name = blockName;
            go.transform.position = position;

            if(parent != null)
            {
                go.transform.parent = parent;
            }
        }
    }
}
