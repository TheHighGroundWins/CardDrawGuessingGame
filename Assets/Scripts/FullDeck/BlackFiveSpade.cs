using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackFiveSpade : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.FIVE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
