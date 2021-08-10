using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedQueenHeart : Card
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
