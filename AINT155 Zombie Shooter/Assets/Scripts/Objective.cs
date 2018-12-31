using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objective : MonoBehaviour {

    public int SpawnersToKill = 3;
    public int Count = 0;
    public Text ObjectiveText;
    Scene CurrentOpenScene;
    public void SpawnerDestroyed()
    {
        Count = Count + 1; //increase count by one
        print(Count); //Debug
        ObjectiveText.text = "Your Objective: \n Destroy all the spawners: " + Count.ToString() + "/" + SpawnersToKill.ToString(); //Updates the objective text when the player destroys a spawner
        if (Count >= SpawnersToKill)
        {
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                SceneManager.LoadScene("Level2"); //temporary, will load to next level at this point.
                Count = 0; //Reset the counter for the next level.
                SpawnersToKill = 6;
            }
            else if (SceneManager.GetActiveScene().name == "Level2")
            {
                SceneManager.LoadScene("Boss Instructions");
            }

        }
    }
}
