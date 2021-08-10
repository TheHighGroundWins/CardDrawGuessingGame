using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackJackClub : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.CLUB;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.JACK;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
