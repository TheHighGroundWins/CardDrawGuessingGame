using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSevenHeart : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.SEVEN;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
