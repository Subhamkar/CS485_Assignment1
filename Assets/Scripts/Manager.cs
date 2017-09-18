using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public static int currentScore;
    public static int highScore;

    public static int currentLevel = 0;
    public static int unlockedLevel;

    public static void CompleteLevel()
    {
        if (currentLevel < 2)
        {
            print(currentLevel);
            currentLevel += 1;
            //Application.LoadLevel(currentLevel);
            SceneManager.LoadScene(currentLevel);
        }
        else
        {
            print("You Win");
        }
    }
}
