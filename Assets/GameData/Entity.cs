using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameData
{
    public abstract class Entity : IEntity
    {
        public int ID { get; set; }
        public GameObject GameObject { get; set; }
    }
}
