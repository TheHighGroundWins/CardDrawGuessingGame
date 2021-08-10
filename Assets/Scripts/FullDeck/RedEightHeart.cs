using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEightHeart : Card
{

    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.EIGHT;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
