using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKingHeart : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.KING;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
