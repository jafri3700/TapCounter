using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour

{
    public int tapcount;
    public UIcontroller uIcontroller;
    public float timer;
    public AudioSource tapsound;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (uIcontroller.isGameStart == true)
        {
            
            uIcontroller.timer.text = ((int)timer).ToString();
            if (timer >= 0)
            {
                timer = timer - Time.deltaTime;
                uIcontroller.timeup.text = "";
                if (Input.GetMouseButtonDown(0))
                {
                    tapsound.Play();
                    tapcount++;
                    Debug.Log(tapcount);
                    uIcontroller.score.text = "Score : " + tapcount.ToString();
                    if (tapcount > PlayerPrefs.GetInt("bestscore"))
                    {
                        PlayerPrefs.SetInt("bestscore", tapcount);
                    }

                }
            }
            else
            {
                uIcontroller.timeup.text = "Time Up Your Score is : " + tapcount.ToString();
            }

        }
        if (uIcontroller.isGameStart == false)
        {
            tapcount = 0;
            timer = 20;
            uIcontroller.score.text = "Score : " + tapcount.ToString();
        }


    }
    
}