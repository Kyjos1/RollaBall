using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class move1 : MonoBehaviour
{

    private Rigidbody rb;

    public float MoveHorizontal;
    public float MoveVertical;

    public TextMeshProUGUI CountText;
    public GameObject winText;

    public float speed1 = 0.5f;

    public int count;



    void Start()
    {

        rb = GetComponent<Rigidbody>();
        winText.SetActive(false);

    }

    void Update()
    {

        MoveHorizontal = 0;
        MoveVertical = 0;

        if (Input.GetKey(KeyCode.RightArrow))
            MoveHorizontal = 1;

        if (Input.GetKey(KeyCode.LeftArrow))
            MoveHorizontal = -1;

        if (Input.GetKey(KeyCode.UpArrow))
            MoveVertical = 1;

        if (Input.GetKey(KeyCode.DownArrow))
            MoveVertical = -1;




        Vector3 movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);

        rb.AddForce(movement * speed1);

    }


    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        count = count + 1;
        SetCountText();

    }

    void SetCountText()
    {
        CountText.text = "Score: " + count.ToString();

        if (count >= 4)

            winText.SetActive(true);

    }



}