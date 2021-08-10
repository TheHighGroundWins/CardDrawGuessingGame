using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFourDiamond : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.FOUR;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
