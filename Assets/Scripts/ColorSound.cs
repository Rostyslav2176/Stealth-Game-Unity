using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSound : MonoBehaviour
{
    Renderer ren;
    public float coolDown;
    public float coolDownTimer = 0f;
    public AudioSource src;
    public AudioClip sfx;

    void Update()
    {
        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if (coolDownTimer < 0)
        {
            coolDownTimer = 0;
        }
        if (Input.GetMouseButtonDown(0) && coolDownTimer == 0)
        {
            
            coolDownTimer = coolDown;
        }

        if (coolDownTimer == 0)
        {
            ren = GetComponent<Renderer>();
            ren.material.SetColor("_Color", Color.green);
            coolDownTimer = coolDown;
        }
    }

    public void Change()
    {
        src.clip = sfx;
        src.Play();
        ren = GetComponent<Renderer>();
        ren.material.SetColor("_Color", Color.red);
    }
}
