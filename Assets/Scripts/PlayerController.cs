using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public TextMeshProUGUI countText;
    public GameObject instruction1TextObject;
    public GameObject instruction2TextObject;
    public GameObject instruction3TextObject;


    private AudioSource playerAudio;
    public AudioClip pickupSound;
    public ParticleSystem explosionParticle;

    private Rigidbody rb;
    public int count;

    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {

        playerAudio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();


    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
        if (transform.position.y < -1)
        {
            Debug.Log("Game Over!");
            gameObject.SetActive(false);
            SceneManager.LoadScene(2);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(pickupSound, 1.0f);
            other.gameObject.SetActive(false);
            count += 1;
            // Run the 'SetCountText()' function (see below)
            SetCountText();
        }

        if (other.gameObject.CompareTag("RedSquare"))
        {
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Instructiom1"))
        {
            instruction1TextObject.SetActive(true);

        }
        if (other.gameObject.CompareTag("Instruction2"))
        {
            instruction2TextObject.SetActive(true);

        }
        if (other.gameObject.CompareTag("Instruction3"))
        {
            instruction3TextObject.SetActive(true);

        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 10)
        {
            SceneManager.LoadScene(3);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Instructiom1"))
        {
            instruction1TextObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Instruction2"))
        {
            instruction2TextObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Instruction3"))
        {
            instruction3TextObject.SetActive(false);

        }
    }
}
