using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float startTime;
    public MoveBall player;
    float currentTime;
    bool timerStarted = false;

    //TextMesh
    [SerializeField] TMP_Text timerText;
    void Start()
    {
        currentTime = startTime;
        timerText.text = currentTime.ToString();
        timerStarted = true;
        player = GameObject.Find("Ball").GetComponent<MoveBall>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerStarted) {
            currentTime -= Time.deltaTime;
            if(currentTime <= 0) {
                timerStarted = false;
                currentTime = 0;
                Debug.Log("Timer llego a cero");
                player.enabled = false;
            }
            //Control de la salida de Text
            timerText.text = "Time: "+currentTime.ToString("f1");
        }
    }
}
