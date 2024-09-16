using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidade;
    private int count;
    public TMP_Text countText;
    public TMP_Text winText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");
        Vector3 movimento = new Vector3(movimentoHorizontal, 0.0f, movimentoVertical);
        rb.AddForce(movimento * velocidade);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 1) //Observação: o número é a quantidade de Pickups da cena!
            winText.text = "YOU WIN!!";
    }
}
