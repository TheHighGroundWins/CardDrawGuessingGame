using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackKingSpade : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.KING;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
