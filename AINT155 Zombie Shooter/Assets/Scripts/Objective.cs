using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objective : MonoBehaviour {

    public int SpawnersToKill = 3;
    public int Count = 0;
    public Text ObjectiveText;
    public void SpawnerDestroyed()
    {
        Count++; //increase count by one
        print(Count); //Debug
        ObjectiveText.text = "Your Objective: \n Destroy all the spawners: " + Count.ToString() + "/3"; //Updates the objective text when the player destroys a spawner
        if (Count >= SpawnersToKill)
        {
            SceneManager.LoadScene("Zombie Shooter Level 2"); //temporary, will load to next level at this point.
            Count = 0; //Reset the counter for the next level.
            SpawnersToKill = 5;
        }
    }
    public void Level2Objective()
    {
        Count++;
        print(Count);
        ObjectiveText.text = "Your Objective: \n Destroy all of the spawners: " + Count.ToString() +  "/" + SpawnersToKill.ToString();
        if (Count >= SpawnersToKill)
        {
            SceneManager.LoadScene("Zombie Shooter Level 2");

        }
    }
}
