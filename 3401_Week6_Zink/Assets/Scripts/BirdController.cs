using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour {

    public AudioClip WhooshAudio;
    public AudioClip PointAudio;
    public GameObject EndBgMusic;
    public Rigidbody2D PlayerRB;
    public float JumpSpeed = 5;
    public GameObject GameOverCanvas;
    public Text ScoreText;

    private AudioSource source;
    private AudioSource source2;
    public int CurrScore;


    void Awake()
    {

        source = GetComponent<AudioSource>();
        source2 = GetComponent<AudioSource>();
    }

    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRB.velocity = new Vector2(PlayerRB.velocity.x, JumpSpeed);
            source.PlayOneShot(WhooshAudio);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("COLLISION");
        GameOverCanvas.SetActive(true);
        EndBgMusic.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CurrScore++;
        ScoreText.text = "Score: " + CurrScore.ToString();
        source2.PlayOneShot(PointAudio);
    }
}
