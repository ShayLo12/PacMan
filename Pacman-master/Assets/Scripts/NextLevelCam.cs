using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.currentScore == 330)
        {
            transform.position = new Vector3(-50.5f, 16f, -10f);
        }
    }
}
