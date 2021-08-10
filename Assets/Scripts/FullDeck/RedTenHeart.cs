using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTenHeart : Card
{
    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.TEN;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
