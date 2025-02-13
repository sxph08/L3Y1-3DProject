using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapCounter : MonoBehaviour
{
        public TMP_Text lapText;
        private int lapCount = 0;

    void Start()
    {
        UpdateLapText();   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lapCount++;
            UpdateLapText();
        }
    }
    void UpdateLapText()
    {
        lapText.text = "Laps: " + lapCount;//
    }
}
