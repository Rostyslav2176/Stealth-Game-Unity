using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class interact : MonoBehaviour, IInteractable
{
    Renderer ren;
    public float coolDown = 1;
    public float coolDownTimer;


    void Update()
    {
        if(coolDownTimer > 0) 
        {
            coolDownTimer -= Time.deltaTime;
        }

        if(coolDownTimer < 0) 
        {
            coolDownTimer = 0;
        }

       
    }
    public void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E) && coolDownTimer == 0)
        {
            ren = GetComponent<Renderer>();
            ren.material.SetColor("_Color", Color.red);
        }
        else
        {
            Debug.Log("Green");
        }
        

    }

}
