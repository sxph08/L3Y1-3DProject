using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer;
    public float timeLimit;
    public TMP_Text timerText;

    public GameObject boat;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R PRESSED");
            GameObject.Find("Sphere").GetComponent<PlayerCollider>().OutOfTime();;
        }

        timerText.text = timer.ToString("F2");
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Debug.Log("Out of time.");
            GameObject.Find("Sphere").GetComponent<PlayerCollider>().OutOfTime();
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
