using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSixHeart : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.SIX;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }

}
