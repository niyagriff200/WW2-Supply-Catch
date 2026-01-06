using System.Collections.Generic;
using UnityEngine;

public abstract class LevelData : MonoBehaviour
{
    [Header("Player Settings")]
    private Transform playerSpawnPoint;
    public Transform PlayerSpawnPoint
    {
        get { return playerSpawnPoint; }
        protected set { playerSpawnPoint = value; }
    }

    private List<PlayerController> players;
    public List<PlayerController> Players
    {
        get { return players; }
        protected set { players = value; }
    }

    private int startingLives;
    public int StartingLives
    {
        get { return startingLives;  }
        protected set { startingLives = value; }
    }

    [Header("Object Spawn Points")]
    private List<Transform> newspaperSpawnPoints;
    public List<Transform> NewsPaperSpawnPoints
    {
        get { return newspaperSpawnPoints; }
        protected set { newspaperSpawnPoints = value; }
    }

    private List<Transform> mailSpawnPoints;
    public List<Transform> MailSpawnPoints
    {
        get { return mailSpawnPoints; }
        protected set { mailSpawnPoints = value; }
    }

    private List<Transform> packageSpawnPoints;
    public List<Transform> PackageSpawnPoints
    {
        get { return packageSpawnPoints; }
        protected set { packageSpawnPoints = value; }
    }

    [Header("Object Spawn Settings")]
    private List<GameObject> activeObjects = new List<GameObject>();
    public List<GameObject> ActiveObjects
    {
        get { return activeObjects; }
        protected set { activeObjects = value; }
    }

    [Range(0f, 1f)] private float mailChance;
    public float MailChance
    {
        get { return mailChance; }
        protected set { mailChance = value; }
    }

    [Range(0f, 1f)] private float newspaperChance;
    public float NewspaperChance
    {
        get { return newspaperChance; }
        protected set { newspaperChance = value; }
    }
}
