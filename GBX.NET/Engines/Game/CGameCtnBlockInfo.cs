﻿using GBX.NET.Engines.GameData;
using GBX.NET.Engines.Scene;

namespace GBX.NET.Engines.Game
{
    [Node(0x0304E000)]
    public class CGameCtnBlockInfo : CGameCtnCollector
    {
        public string Name { get; set; }

        [Chunk(0x0304E005)]
        public class Chunk0304E005 : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                n.Name = rw.LookbackString(n.Name);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Reader.ReadArray(i => rw.Reader.ReadNodeRef<CGameCtnBlockUnitInfo>());
                rw.Reader.ReadArray(i => rw.Reader.ReadNodeRef<CGameCtnBlockUnitInfo>());
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Reader.ReadNodeRef<CSceneMobil>();
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Reader.ReadNodeRef<CSceneMobil>();
                rw.Byte(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0304E009)]
        public class Chunk0304E009 : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0304E00C)]
        public class Chunk0304E00C : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                rw.Array<float>(Unknown, 24);
            }
        }

        [Chunk(0x0304E00D)]
        public class Chunk0304E00D : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0304E00E)]
        public class Chunk0304E00E : Chunk<CGameCtnBlockInfo>
        {
            public Node[] Unknown1 { get; set; }

            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                Unknown1 = rw.Array(Unknown1, i => rw.Reader.ReadNodeRef(), x => rw.Writer.Write(x));
            }
        }

        [Chunk(0x0304E00F)]
        public class Chunk0304E00F : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0304E013)]
        public class Chunk0304E013 : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0304E015)]
        public class Chunk0304E015 : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
                rw.Single(Unknown);
            }
        }

        [Chunk(0x0304E017)]
        public class Chunk0304E017 : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0304E020)]
        public class Chunk0304E020 : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                var waypoint = rw.Reader.ReadNodeRef<CGameWaypointSpecialProperty>();
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0304E023)]
        public class Chunk0304E023 : Chunk<CGameCtnBlockInfo>
        {
            public override void ReadWrite(CGameCtnBlockInfo n, GameBoxReaderWriter rw)
            {
                var variantGround = Parse<CGameCtnBlockInfoVariantGround>(rw.Reader, 0x0315C000);
                var variantAir = Parse<CGameCtnBlockInfoVariantAir>(rw.Reader, 0x0315D000);
            }
        }
    }
}