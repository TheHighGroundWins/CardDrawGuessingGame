using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedNineHeart : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.NINE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
