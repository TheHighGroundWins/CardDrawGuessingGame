using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackFiveClub : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.CLUB;
         numberType = NumberEnums.FIVE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
