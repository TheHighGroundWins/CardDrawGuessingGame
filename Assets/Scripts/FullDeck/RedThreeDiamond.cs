using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedThreeDiamond : Card
{
    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.THREE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
