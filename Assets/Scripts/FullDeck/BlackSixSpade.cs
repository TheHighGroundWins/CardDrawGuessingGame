using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSixSpade : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.SIX;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
