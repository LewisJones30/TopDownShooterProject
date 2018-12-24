using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class EnemySpawnedEvent : UnityEvent<Transform> { }
public class Enemy : MonoBehaviour {
    public EnemySpawnedEvent onSpawn;
    private void Start()
    {
        GameObject player = GameObject.FindWithTag("PlayerControl");
        onSpawn.Invoke(player.transform);
    }
}
