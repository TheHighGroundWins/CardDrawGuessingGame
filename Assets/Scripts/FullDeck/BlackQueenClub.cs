using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackQueenClub : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.CLUB;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.QUEEN;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
