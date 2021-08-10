using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKingDiamond : Card
{
    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.KING;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
