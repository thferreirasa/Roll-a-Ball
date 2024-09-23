using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private void Awake()
    {
        // Verifica se já existe um MusicManager na cena
        if (FindObjectsOfType<MusicManager>().Length > 1)
        {
            Destroy(gameObject); // Destrói este objeto se já houver um
        }
        else
        {
            DontDestroyOnLoad(gameObject); // Não destruir o objeto ao carregar nova cena
        }
    }

    private void Start()
    {
        GetComponent<AudioSource>().Play(); // Toca a música
    }
}
