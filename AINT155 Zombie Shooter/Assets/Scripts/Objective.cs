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

        }
    }
}
