using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIcontroller : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject game;
    public bool isGameStart;
    public TMP_Text score;
    public TMP_Text bestscore;
    public TMP_Text bestscoremainmenu;
    public TMP_Text timer;
    public TMP_Text timeup;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bestscore.text = "Best Score : "+PlayerPrefs.GetInt("bestscore").ToString();
        bestscoremainmenu.text = "Best Score : " + PlayerPrefs.GetInt("bestscore").ToString();
    }
    public void playbutton()
    {
        isGameStart = true;
        mainmenu.SetActive(false);
        game.SetActive(true);

    }
    public void exitbutton()
    {
        
        Application.Quit();
    }
    public void leavegame()
    {
        
        mainmenu.SetActive(true);
        game.SetActive(false);
        isGameStart = false;

    }

}
