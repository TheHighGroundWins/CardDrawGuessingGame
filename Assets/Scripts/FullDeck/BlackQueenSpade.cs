using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackQueenSpade : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.QUEEN;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
