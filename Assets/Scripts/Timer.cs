using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Referência ao texto do temporizador
    private float timeElapsed; // Tempo decorrido
    private bool isGameActive; // Para controlar o estado do jogo

    // Start is called before the first frame update
    void Start()
    {
        timeElapsed = 0f;
        isGameActive = true; // Começa o jogo como ativo
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            timeElapsed += Time.deltaTime; // Incrementa o tempo
            UpdateTimerText(); // Atualiza o texto do temporizador
        }
    }

    void UpdateTimerText()
    {
        // Converte o tempo em minutos e segundos
        int minutes = Mathf.FloorToInt(timeElapsed / 60);
        int seconds = Mathf.FloorToInt(timeElapsed % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StopTimer()
    {
        isGameActive = false; // Para o temporizador quando o jogo termina
    }
}
