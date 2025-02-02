﻿namespace GBX.NET.Engines.Game;

[Node(0x0303B000)]
public class CGameCtnDecorationSize : CMwNod
{
    private Vec2 editionZoneMin;
    private Vec2 editionZoneMax;
    private int baseHeightBase;
    private Int3 size;
    private CSceneLayout? scene;
    private GameBoxRefTable.File? sceneFile;

    [NodeMember(ExactlyNamed = true)]
    [AppliedWithChunk<Chunk0303B000>]
    public Vec2 EditionZoneMin { get => editionZoneMin; set => editionZoneMin = value; }

    [NodeMember(ExactlyNamed = true)]
    [AppliedWithChunk<Chunk0303B000>]
    public Vec2 EditionZoneMax { get => editionZoneMax; set => editionZoneMax = value; }

    [NodeMember(ExactlyNamed = true)]
    [AppliedWithChunk<Chunk0303B001>]
    public int BaseHeightBase { get => baseHeightBase; set => baseHeightBase = value; }

    [NodeMember]
    [AppliedWithChunk<Chunk0303B001>]
    public Int3 Size { get => size; set => size = value; }

    [NodeMember(ExactlyNamed = true)]
    [AppliedWithChunk<Chunk0303B001>]
    public CSceneLayout? Scene
    {
        get => scene = GetNodeFromRefTable(scene, sceneFile) as CSceneLayout;
        set => scene = value;
    }

    internal CGameCtnDecorationSize()
    {

    }

    #region 0x000 chunk

    /// <summary>
    /// CGameCtnDecorationSize 0x000 chunk
    /// </summary>
    [Chunk(0x0303B000)]
    public class Chunk0303B000 : Chunk<CGameCtnDecorationSize>
    {
        public float U01;

        public override void ReadWrite(CGameCtnDecorationSize n, GameBoxReaderWriter rw)
        {
            rw.Vec2(ref n.editionZoneMin);
            rw.Vec2(ref n.editionZoneMax);
            rw.Single(ref U01);
        }
    }

    #endregion

    #region 0x001 chunk

    /// <summary>
    /// CGameCtnDecorationSize 0x001 chunk
    /// </summary>
    [Chunk(0x0303B001)]
    public class Chunk0303B001 : Chunk<CGameCtnDecorationSize>
    {
        public override void ReadWrite(CGameCtnDecorationSize n, GameBoxReaderWriter rw)
        {
            rw.Int32(ref n.baseHeightBase);
            rw.Int3(ref n.size);
            rw.NodeRef<CSceneLayout>(ref n.scene, ref n.sceneFile);
        }
    }

    #endregion
}
