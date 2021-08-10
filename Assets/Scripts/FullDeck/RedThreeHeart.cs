using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedThreeHeart : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.THREE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
