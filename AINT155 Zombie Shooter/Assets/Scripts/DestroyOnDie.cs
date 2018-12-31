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
        Destroy(gameObject);
        FindObjectOfType<Objective>().SpawnerDestroyed(); //Updates the Objective script as a spawner has been destroyed.

    }
    public void Spawn()
    {
        Rollednumber = Random.Range(1, 10);
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
        

    }
    public void BossDie()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Victory Screen");
    }
    public void Injured()
    {
        if (GetComponent<Animation>() != null) //Check if there is an animation present
        {
            //Plays the animation if present.
            GetComponent<Animation>().Play(); //Although not destroyed, the enemies will flash with this code.
        }  
        
    }
}
