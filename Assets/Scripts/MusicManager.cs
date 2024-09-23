using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private void Awake()
    {
        // Verifica se j� existe um MusicManager na cena
        if (FindObjectsOfType<MusicManager>().Length > 1)
        {
            Destroy(gameObject); // Destr�i este objeto se j� houver um
        }
        else
        {
            DontDestroyOnLoad(gameObject); // N�o destruir o objeto ao carregar nova cena
        }
    }

    private void Start()
    {
        GetComponent<AudioSource>().Play(); // Toca a m�sica
    }
}
