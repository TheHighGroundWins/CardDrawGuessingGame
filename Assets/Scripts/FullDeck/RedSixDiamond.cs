using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSixDiamond : Card
{
    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.SIX;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
