using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackJackSpade : Card
{

    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.JACK;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
