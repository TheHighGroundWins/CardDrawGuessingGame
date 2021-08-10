using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedJackHeart : Card
{
    void Awake()
    {
         suiteType = SuiteEnums.HEART;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.JACK;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
