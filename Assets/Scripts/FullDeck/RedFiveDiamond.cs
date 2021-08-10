using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFiveDiamond : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.FIVE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
