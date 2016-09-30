using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameData
{
    static class TestFactory
    {
        private static GameObject BlockDirtPrefab = Resources.Load<GameObject>("Prefabs/BlockDirt");
        public static void GenerateBlockDirt(float x, float y, float z)
        {
            IBlock block = new BlockDirt();
            block.GameObject = GameObject.Instantiate(BlockDirtPrefab);
            block.GameObject.transform.position = new Vector3(x, y, z);
        }
    }
}
