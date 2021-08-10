using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTwoHeart : Card
{
    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.TWO;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
