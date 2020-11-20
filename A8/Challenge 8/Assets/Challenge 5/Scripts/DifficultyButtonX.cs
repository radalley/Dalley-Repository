using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */

    //300 300
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        if(difficulty==1)
        {
            gameManagerX.spawnRate = 3f;
        }
        if(difficulty==2)
        {
            gameManagerX.spawnRate = 2f;
        }
        if(difficulty == 3)
        {
            gameManagerX.spawnRate = 1f;
        }
        gameManagerX.StartGame();
    }



}
