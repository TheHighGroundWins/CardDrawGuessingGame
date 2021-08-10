using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAceHeart : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.NONE;
         aceSelected = true;
         colorType = ColorEnums.RED;
    }
}
