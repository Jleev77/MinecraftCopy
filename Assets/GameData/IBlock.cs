using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameData
{
    public interface IBlock : IEntity
    {
        float BreakTime { get; }
    }
}
