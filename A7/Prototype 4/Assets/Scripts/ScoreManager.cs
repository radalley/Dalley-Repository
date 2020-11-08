using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textbox;
    public int waveTot = 0;
    public bool loss = false;
    public bool stopGame = true;
    // Start is called before the first frame update
    void Start()
    {
        
        textbox.text = "Wave: 0";
    }
    private void RunStartup()
    {
        while(stopGame==true)
        {
            textbox.text = "Knock off enemies to complete each wave. Survive 10 waves to win./n You lose by falling off the edge/nPress Spacebar to resume";

        }
    }
    // Update is called once per frame
    void Update()
    {
        if(loss == false)
        {
            textbox.text = "Wave " + waveTot;
            if (waveTot >= 10)
            {
                textbox.text = "You Win! Press R to try again!";
            }
        }
        else
        {
            textbox.text = "You Lose! Press R To Try Again";
        }
       
        //Press R to restart if game is over
        if (Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }

    }
}
