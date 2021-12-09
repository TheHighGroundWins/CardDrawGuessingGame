using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Card : MonoBehaviour, IEquatable<Card>
{
    protected SuiteEnums suiteType;
    protected NumberEnums numberType;
    protected FaceEnums faceType;
    protected bool aceSelected;
    protected ColorEnums colorType;
    protected int drawNumber;
    private bool and;

    public bool Equals (Card randomCard)
    {
        if (and)
        {
            if (aceSelected && suiteType.Equals(randomCard.suiteType) && numberType.Equals(randomCard.numberType)
                && faceType.Equals(randomCard.faceType) && colorType.Equals(randomCard.colorType))
                return true;
        }
        else if (aceSelected || suiteType.Equals(randomCard.suiteType) || numberType.Equals(randomCard.numberType)
                 || faceType.Equals(randomCard.faceType) || colorType.Equals(randomCard.colorType))
            return true;

        return false;
    }

    public ColorEnums GetColor()
    {
        return colorType;
    }

    public int GetDrawNumber()
    {
        return drawNumber;
    }

    public void Init (SuiteEnums suiteType, NumberEnums numberType, 
        FaceEnums faceType, bool aceSelected, ColorEnums colorType, int drawNumber, bool and)
    {
        this.suiteType = suiteType;
        this.numberType = numberType;
        this.faceType = faceType;
        this.aceSelected = aceSelected;
        this.colorType = colorType;
        this.drawNumber = drawNumber;
        this.and = and;
    }

}
