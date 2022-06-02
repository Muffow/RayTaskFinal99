using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeToExplode : MonoBehaviour
{
    private int timeToPlay = 3;
    public TextMeshProUGUI timeToPlayText;
    public bool timeEnded = false;
    public Explosion explosive;

    // Start is called before the first frame update
    void Start()
    {
        timeToPlayText.text = "Time: " + 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (explosive.buttonTriggered)
        {
            InvokeRepeating("TimeDecreasing", 1f, 1f);

        }
    }

    public void TimeDecreasing()
    {
        timeToPlay--;
        timeToPlayText.text = "Time: " + timeToPlay;
        if (timeToPlay == 0)
        {
            timeToPlay = 0;
            timeEnded = true;
        }
    }

}
