using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedQueenDiamond : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.QUEEN;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
