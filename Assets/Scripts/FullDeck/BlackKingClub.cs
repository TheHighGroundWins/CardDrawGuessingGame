using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackKingClub : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.CLUB;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.KING;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
