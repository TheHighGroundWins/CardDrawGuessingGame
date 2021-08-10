using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardGenerator : MonoBehaviour
{
    bool startGame = false;
    bool gameEnd = false;
    Card playerCard;
    Card randomCard;
    List<GameObject> physicalDeck = new List<GameObject>();

    //UI text for player draw guess and counter
    [SerializeField]
    TextMeshProUGUI playerGuess;

    [SerializeField]
    TextMeshProUGUI cardCounter;

    int drawCounter = 0;
    int playerGuessNumber;

    GameObject endGameScreen;

    Timer cardSwapTimer;
    Timer gamerOverTimer;
    Timer cardDeleteTimer;
    GameObject temporaryCard;

    bool deleteTimerstarted = false;

    // Start is called before the first frame update
    void Start()
    {
        Object[] fullDeckGameObjects=Resources.LoadAll("FullDeck", 
        typeof(GameObject));

        endGameScreen = (GameObject)Resources.Load("EndScreen");

        for (var i = fullDeckGameObjects.Length-1; i > 0; i--)
        {
            var temp = fullDeckGameObjects[i];
            var index = Random.Range(0, i+1);
            fullDeckGameObjects[i] = fullDeckGameObjects[index];
            fullDeckGameObjects[index] = temp;
        }

        for (int i=0; i<fullDeckGameObjects.Length; i++)
        {
            physicalDeck.Add((GameObject)fullDeckGameObjects[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (startGame)
        {

            if (cardSwapTimer.IsFinished() && !deleteTimerstarted)
            {
                if (physicalDeck.Count > 0)
                {
                    temporaryCard = Instantiate<GameObject>(physicalDeck[physicalDeck.Count - 1]);
                    randomCard = temporaryCard.GetComponent<Card>();

                    drawCounter++;
                    cardCounter.text = "Draws: " + drawCounter;
                    if (playerCard.Equals(randomCard))
                    {
                        startGame = false;
                        gameEnd = true;
                        gamerOverTimer.Run();
                    }
                    else
                    {
                        cardDeleteTimer.Run();
                        deleteTimerstarted = true;
                    }
                }
            }

            if (cardDeleteTimer.IsFinished())
            {
                physicalDeck.RemoveAt(physicalDeck.Count - 1);
                Destroy(temporaryCard);

                deleteTimerstarted = false;
                cardSwapTimer.Run();
            }
        }

        if (gameEnd)
        {
            if (gamerOverTimer.IsFinished())
            {
                int playerDifference = Mathf.Abs(playerGuessNumber - drawCounter);
                Transform parentTransform = GameObject.FindWithTag("MainCanvas").GetComponent<Transform>();
                GameObject gameOver = Instantiate<GameObject>(endGameScreen, parentTransform);
                gameOver.GetComponent<EndScreen>().SetScore(playerDifference);
                gameEnd = false;
            }
        }
    }

    public void SetCard(SuiteEnums suiteType, NumberEnums numberType,
        FaceEnums faceType, bool aceSelected, ColorEnums colorType, int drawNumber)
    {
        playerCard = gameObject.AddComponent<Card>();
        playerCard.Init(suiteType, numberType,
        faceType, aceSelected, colorType, drawNumber);
        playerGuessNumber = drawNumber;

        cardCounter.text = "Draws: " + drawCounter;
        playerGuess.text = "Player Guess: " + playerGuessNumber;
        startGame = true;

        cardSwapTimer = gameObject.AddComponent<Timer>();
        cardSwapTimer.SetDuration(1);
        cardSwapTimer.Run();

        gamerOverTimer = gameObject.AddComponent<Timer>();
        gamerOverTimer.SetDuration(1);

        cardDeleteTimer = gameObject.AddComponent<Timer>();
        cardDeleteTimer.SetDuration(1);
    }
}
