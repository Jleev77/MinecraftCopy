using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameData
{
    public interface IEntity
    {
        int ID { get; set; }
        GameObject GameObject { get; set; }
    }
}
