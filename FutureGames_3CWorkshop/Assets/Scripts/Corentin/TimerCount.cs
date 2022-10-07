using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCount : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;


    [Header("Timer Settings")]
    public float currenTime;

    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenTime = countDown ? currenTime -= Time.deltaTime : currenTime += Time.deltaTime;

        if (hasLimit && ((countDown && currenTime <= timerLimit) || (!countDown && currenTime >= timerLimit)))
        {
            currenTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
        }

        SetTimerText();

    }

    private void SetTimerText()
    {
        timerText.text = currenTime.ToString();
    }

}
