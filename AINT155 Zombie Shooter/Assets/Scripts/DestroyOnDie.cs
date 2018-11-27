/*******************************************************
 * 
 * 
 * DestroyOnDie.cs
 * - Destroys the GameObject when the Die method is run
 * - we can call this from other Components when a condition is met, like if we run out of health
 * 
 * 
 * public variables: none
 * 
 * 
 * public custom methods
 * - Die
 *   - Calls the Destroy method to remove the GameObject from the scene
 *   - see link: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
 * 
 * 
 *******************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;




/*
 * The DestroyOnDie class inherits from Monobehaviour, which lets us add it as a component to a GameObject
 * see link: https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
 */
public class DestroyOnDie : MonoBehaviour
{
    public int playerScore = 0;
    public delegate void SendScore(int theScore);
    public int SpawnerCount = 0;
    public Text SpawnersTextL1;
    public int HealthSpawnCounter = 10;
    public int Rollednumber = 0;
    public GameObject prefab = null;
    /*
     * Die
     * We call the Destroy method to remove our bullet GameObject from the scene
     * see link: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
     */
    public void Die()
    {
        /*
         * DESTROY THE GAMEOBJECT
         * The Destroy method requires a GameObject to destroy.
         * We give it the GameObject this script is on (in the editor), which is "gameObject" - note the lower case "g"
         * see link: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
         */
        Destroy(gameObject);
        
    }
    public void SpawnerDie()
    {
        SpawnerCount = SpawnerCount + 1;
        print(SpawnerCount);
        if (SpawnerCount == 3)
        {
            SceneManager.LoadScene("Game Over");
        }
        else
        {
            Destroy(gameObject);
            //Objective Text
            SpawnersTextL1.text = "your objective: \n Destroy all the spawners: " + SpawnerCount.ToString() + "/3";

        }
    }
    public void Spawn()
    {
        Rollednumber = Random.Range(10, 10);
        print("Number Rolled: " + Rollednumber);
        if (Rollednumber == HealthSpawnCounter)
        {
            Instantiate(this.prefab, this.transform.position, Quaternion.identity);
        }
    }
    public void PlayerDie()
    {
        print("game over");
        SceneManager.LoadScene("Game Over");
        //playerScore = theScore;
        //StreamWriter highScores = new StreamWriter("Highscores.txt");
        //highScores.WriteLine(playerScore);
        //highScores.Close();
        

    }
}
