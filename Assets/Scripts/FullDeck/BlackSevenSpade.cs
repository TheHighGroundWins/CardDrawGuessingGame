using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSevenSpade : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.SEVEN;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
