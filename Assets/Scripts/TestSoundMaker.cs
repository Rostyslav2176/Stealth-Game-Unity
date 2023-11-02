using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay
{
    public class TestSoundMaker : MonoBehaviour
    {
        [SerializeField] private AudioSource source = null;

        [SerializeField] private float soundRange = 25f;

        [SerializeField] private Sound.SoundType soundType = Sound.SoundType.Dangerous;

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
            if(Input.GetMouseButtonDown(0) && coolDownTimer == 0)
            {
                OnMouseDown();
                coolDownTimer = coolDown;
            }
        }

        private void OnMouseDown()
        {        
                if (source.isPlaying) //If already playing a sound, don't allow overlapping sounds 
                    return;

                source.Play();

                var sound = new Sound(transform.position, soundRange, soundType);

                Sounds.MakeSound(sound);
                Debug.Log("sound");
            
        }
    }
}