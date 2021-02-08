using UnityEngine;
using System.Collections;

public class Energizer : MonoBehaviour
{

    private GameManager gm;

    AudioSource audioSource;
    public AudioClip pickupSound;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
        if (gm == null) Debug.Log("Energizer did not find Game Manager!");
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "pacman")
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            gm.ScareGhosts();
            gameObject.SetActive(false);
        }
    }


}
