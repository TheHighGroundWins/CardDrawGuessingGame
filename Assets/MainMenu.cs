using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    Button backButton;

    [SerializeField]
    Button resetButton;

    [SerializeField]
    Button exitButton;

    public void Back()
    {
        Destroy(gameObject);
    }

    public void Reset()
    {
        SceneManager.LoadScene("CardGame",LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
