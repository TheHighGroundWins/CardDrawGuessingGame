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

    public bool Equals (Card randomCard)
    {
        if (colorType == ColorEnums.NONE || colorType==randomCard.colorType)
        {
            if(suiteType==SuiteEnums.NONE && faceType==FaceEnums.NONE
            &&numberType==NumberEnums.NONE && !aceSelected)
            {
                Debug.Log("1");
                return true;
            }
            if (suiteType!=SuiteEnums.NONE && suiteType.HasFlag(randomCard.suiteType))
            {
                if (numberType!=NumberEnums.NONE && numberType.HasFlag(randomCard.numberType)
                &&randomCard.numberType!=NumberEnums.NONE)
                {
                    Debug.Log("2");
                    return true;
                }
                if (faceType!=FaceEnums.NONE && faceType.HasFlag(randomCard.faceType)
                &&randomCard.faceType!=FaceEnums.NONE)
                {
                    Debug.Log("3");
                    return true;
                }
                if (aceSelected && aceSelected == randomCard.aceSelected)
                {
                    Debug.Log("4");
                    return true;
                }
                return true;
            }

            if(suiteType==SuiteEnums.NONE)
            {
                if (numberType!=NumberEnums.NONE && numberType.HasFlag(randomCard.numberType)
                && randomCard.numberType!=NumberEnums.NONE)
                {
                    Debug.Log("5");
                    return true;
                }
                if (faceType!=FaceEnums.NONE && faceType.HasFlag(randomCard.faceType)
                &&randomCard.numberType!=NumberEnums.NONE)
                {
                    Debug.Log("6");
                    return true;
                }
                if (aceSelected && aceSelected == randomCard.aceSelected)
                {
                    Debug.Log("7");
                    return true;
                }
            }
            Debug.Log("8");
            return false;
        }
        else
        {
            Debug.Log("9");
            return false;
        }
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
        FaceEnums faceType, bool aceSelected, ColorEnums colorType, int drawNumber)
    {
        this.suiteType = suiteType;
        this.numberType = numberType;
        this.faceType = faceType;
        this.aceSelected = aceSelected;
        this.colorType = colorType;
        this.drawNumber = drawNumber;
    }

}
