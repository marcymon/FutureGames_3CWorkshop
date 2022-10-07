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

    [Header("Format Settings")]
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();

    [SerializeField] GameObject spawnManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        timeFormats.Add(TimerFormats.Whole, "0");
        timeFormats.Add(TimerFormats.TenthDecimal, "0.0");
        timeFormats.Add(TimerFormats.HundrethsDecimal, "0.0.0");
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
            spawnManager.SetActive(false);
            PauseGame();
        }

        SetTimerText();

    }

    private void SetTimerText()
    {
        timerText.text = hasFormat ? currenTime.ToString(timeFormats[format]) : currenTime.ToString();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

}

public enum TimerFormats
{
    Whole,
    TenthDecimal,
    HundrethsDecimal
}