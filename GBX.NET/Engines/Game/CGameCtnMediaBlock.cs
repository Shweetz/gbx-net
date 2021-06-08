﻿using GBX.NET.Engines.MwFoundations;

namespace GBX.NET.Engines.Game
{
    /// <summary>
    /// MediaTracker block (0x03077000)
    /// </summary>
    [Node(0x03077000)]
    public class CGameCtnMediaBlock : CMwNod
    {
        public abstract class Key
        {
            public float Time { get; set; }

            protected Key()
            {

            }

            protected Key(GameBoxReader r)
            {
                Time = r.ReadSingle();
            }
        }
    }
}