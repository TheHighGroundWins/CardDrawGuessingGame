using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionManager : MonoBehaviour
{
    SuiteEnums suiteType = SuiteEnums.NONE;
    NumberEnums numberType;
    FaceEnums faceType;
    bool aceSelected;
    ColorEnums colorType= ColorEnums.NONE;
    int drawNumber = 4;

    Card playerCard;

    [SerializeField]
    Button[] suitButtons;

    [SerializeField]
    Sprite[] suitSprites;
    /*
     * 0 is spades
     * 1 is black spades    
     * 2 is diamonds
     * 3 is black diamonds
     * 4 is clubs
     * 5 is black clubs   
     * 6 is hearts
     * 7 is black hearts    
     */

    [SerializeField]   
    Button[] numberButtons;

    [SerializeField]
    Sprite[] numberSprites;
    /*
     * 0 is 2 and so forth
     * 1 is black 2
     */   

     [SerializeField]
    Button[] faceButtons;

    [SerializeField]
    Sprite[] faceSprites;
    /*
     * 0 is Queen
     * 1 is BlackQueen    
     * 2 is Jack
     * 3 is blackJack   
     * 4 is King
     * 5 is black King
     */   
     [SerializeField]
    Button aceButton;

    [SerializeField]
    Sprite[] aceSprites;
    // 1 is black ace

    //color selector button
    [SerializeField]
    Button colorButton;

    GameObject drawSelection;


    void Start()
    {
        drawSelection = (GameObject)Resources.Load("DrawEntry");
    }

    public void EnterChoices()
    {
        GameObject drawSelectionInstance= Instantiate<GameObject>(drawSelection,transform);
        drawSelectionInstance.GetComponent<DrawEntry>().SetCardInfo( suiteType,  numberType,
         faceType,  aceSelected,  colorType,  drawNumber);

        Button confirmChoicesButton = drawSelectionInstance.GetComponentInChildren<Button>();
    }

    //suits on click
    public void Spades()
    {

        if (!suiteType.HasFlag(SuiteEnums.SPADE))
        {
            suitButtons[0].image.sprite = suitSprites[1];
            suiteType |= SuiteEnums.SPADE;
        }
        else
        {
            suitButtons[0].image.sprite = suitSprites[0];
            suiteType &= ~SuiteEnums.SPADE;
        }
    }

    public void Diamonds()
    {
        if (!suiteType.HasFlag(SuiteEnums.DIAMOND))
        {
            suitButtons[1].image.sprite = suitSprites[3];
            suiteType |= SuiteEnums.DIAMOND;
        }
        else
        {
            suitButtons[1].image.sprite = suitSprites[2];
            suiteType &= ~SuiteEnums.DIAMOND;
        }
    }

    public void Clubs()
    {
        if (!suiteType.HasFlag(SuiteEnums.CLUB))
        {
            suitButtons[2].image.sprite = suitSprites[5];
            suiteType |= SuiteEnums.CLUB;
        }
        else
        {
            suitButtons[2].image.sprite = suitSprites[4];
            suiteType &= ~SuiteEnums.CLUB;
        }
    }

    public void Hearts()
    {
        if (!suiteType.HasFlag(SuiteEnums.HEART))
        {
            suitButtons[3].image.sprite = suitSprites[7];
            suiteType |= SuiteEnums.HEART;
        }
        else
        {
            suitButtons[3].image.sprite = suitSprites[6];
            suiteType &= ~SuiteEnums.HEART;
        }
    }

    //numbers on click
    public void Two()
    {
        if(!numberType.HasFlag(NumberEnums.TWO))
        {
            numberButtons[0].image.sprite = numberSprites[1];
            numberType |= NumberEnums.TWO;
        }
        else
        {
            numberButtons[0].image.sprite = numberSprites[0];
            numberType &= ~NumberEnums.TWO;
        }
    }

    public void Three()
    {
        if (!numberType.HasFlag(NumberEnums.THREE))
        {
            numberButtons[1].image.sprite = numberSprites[3];
            numberType |= NumberEnums.THREE;
        }
        else
        {
            numberButtons[1].image.sprite = numberSprites[2];
            numberType &= ~NumberEnums.THREE;
        }
    }

    public void Four()
    {
        if (!numberType.HasFlag(NumberEnums.FOUR))
        {
            numberButtons[2].image.sprite = numberSprites[5];
            numberType |= NumberEnums.FOUR;
        }
        else
        {
            numberButtons[2].image.sprite = numberSprites[4];
            numberType &= ~NumberEnums.FOUR;
        }
    }

    public void Five()
    {
        if (!numberType.HasFlag(NumberEnums.FIVE))
        {
            numberButtons[3].image.sprite = numberSprites[7];
            numberType |= NumberEnums.FIVE;
        }
        else
        {
            numberButtons[3].image.sprite = numberSprites[6];
            numberType &= ~NumberEnums.FIVE;
        }
    }

    public void Six()
    {
        if (!numberType.HasFlag(NumberEnums.SIX))
        {
            numberButtons[4].image.sprite = numberSprites[9];
            numberType |= NumberEnums.SIX;
        }
        else
        {
            numberButtons[4].image.sprite = numberSprites[8];
            numberType &= ~NumberEnums.SIX;
        }
    }

    public void Seven()
    {
        if (!numberType.HasFlag(NumberEnums.SEVEN))
        {
            numberButtons[5].image.sprite = numberSprites[11];
            numberType |= NumberEnums.SEVEN;
        }
        else
        {
            numberButtons[5].image.sprite = numberSprites[10];
            numberType &= ~NumberEnums.SEVEN;
        }
    }

    public void Eight()
    {
        if (!numberType.HasFlag(NumberEnums.EIGHT))
        {
            numberButtons[6].image.sprite = numberSprites[13];
            numberType |= NumberEnums.EIGHT;
        }
        else
        {
            numberButtons[6].image.sprite = numberSprites[12];
            numberType &= ~NumberEnums.EIGHT;
        }
    }

    public void Nine()
    {
        if (!numberType.HasFlag(NumberEnums.NINE))
        {
            numberButtons[7].image.sprite = numberSprites[15];
            numberType |= NumberEnums.NINE;
        }
        else
        {
            numberButtons[7].image.sprite = numberSprites[14];
            numberType &= ~NumberEnums.NINE;
        }
    }

    public void Ten()
    {
        if (!numberType.HasFlag(NumberEnums.TEN))
        {
            numberButtons[8].image.sprite = numberSprites[17];
            numberType |= NumberEnums.TEN;
        }
        else
        {
            numberButtons[8].image.sprite = numberSprites[16];
            numberType &= ~NumberEnums.TEN;
        }
    }

    //ace
    public void Ace()
    {
        if(!aceSelected)
        {
            aceSelected = true;
            aceButton.image.sprite = aceSprites[1];
        }
        else
        {
            aceSelected = false;
            aceButton.image.sprite = aceSprites[0];
        }
    }

    //face cards

    public void Queen()
    {
        if(!faceType.HasFlag(FaceEnums.QUEEN))
        {
            faceButtons[0].image.sprite = faceSprites[1];
            faceType |= FaceEnums.QUEEN;
        }
        else
        {
            faceButtons[0].image.sprite = faceSprites[0];
            faceType &= ~FaceEnums.QUEEN;
        }
    }

    public void Jack()
    {
        if (!faceType.HasFlag(FaceEnums.JACK))
        {
            faceButtons[1].image.sprite = faceSprites[3];
            faceType |= FaceEnums.JACK;
        }
        else
        {
            faceButtons[1].image.sprite = faceSprites[2];
            faceType &= ~FaceEnums.JACK;
        }
    }

    public void King()
    {
        if (!faceType.HasFlag(FaceEnums.KING))
        {
            faceButtons[2].image.sprite = faceSprites[5];
            faceType |= FaceEnums.KING;
        }
        else
        {
            faceButtons[2].image.sprite = faceSprites[4];
            faceType &= ~FaceEnums.KING;
        }
    }

    public void ColorOnClick()
    {
        switch(colorType)
        {
            case ColorEnums.NONE:
                colorType = ColorEnums.BLACK;
                colorButton.image.color = Color.black;
                break;
            case ColorEnums.BLACK:
                colorType = ColorEnums.RED;
                colorButton.image.color = Color.red;
                break;
            case ColorEnums.RED:
                colorType = ColorEnums.NONE;
                colorButton.image.color = Color.white;
                break;
        }
    }
}
