using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

    public class interact : MonoBehaviour, IInteractable
    {
        Renderer ren;
        public float coolDown;
        public float coolDownTimer = 0f;


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
                Interact();
                coolDownTimer = coolDown;
            }

            if (coolDownTimer == 0)
            {
                ren = GetComponent<Renderer>();
                ren.material.SetColor("_Color", Color.green);
                coolDownTimer = coolDown;
            }

        }
        public void Interact()
        {
            ren = GetComponent<Renderer>();
            ren.material.SetColor("_Color", Color.red);
            Debug.Log("active");

        }



    }