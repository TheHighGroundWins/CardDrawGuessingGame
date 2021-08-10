using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    float elapsedTime = 0;
    float timeDuration = 0;
    bool startTimer = false;

    public float num()
    {
        return timeDuration;
    }

    public void Run()
    {
        startTimer = true;
        elapsedTime = 0;
    }

    void Update()
    {
        if(startTimer)
        {
            elapsedTime += Time.deltaTime;
        }
    }

    public void SetDuration(float duration)
    {
        timeDuration = duration;
    }

    public bool IsRunning()
    {
        if(startTimer&&!IsFinished())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsFinished()
    {
        if (elapsedTime>=timeDuration&&timeDuration!=0)
        {
            startTimer = false;
            elapsedTime = 0;
            return true;
        }
        else
        {
            return false;
        }
    }

}
