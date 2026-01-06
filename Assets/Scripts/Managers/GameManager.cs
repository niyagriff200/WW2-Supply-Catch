using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    [Header("Game Screens")]
    [SerializeField] private GameObject splashScreen;
    public GameObject SplashScreen => splashScreen;

    [SerializeField] private GameObject mainMenuScreen;
    public GameObject MainMenuScreen => mainMenuScreen;

    [SerializeField] private GameObject gameplayScreen;
    public GameObject GameplayScreen => gameplayScreen;

    [SerializeField] private GameObject settingsScreen;
    public GameObject SettingsScreen => settingsScreen;

    [SerializeField] private GameObject creditsScreen;
    public GameObject CreditsScreen => creditsScreen;

    [SerializeField] private GameObject gameOverScreen;
    public GameObject GameOverScreen => gameOverScreen;

    [Header("Level Data")]
    [SerializeField] private LevelData currentlevelData;
    public LevelData CurrentLevelData
    {
        get { return currentlevelData; }
        set { currentlevelData = value; }
    }

    [Header("Prefabs")]
    [SerializeField] private GameObject playerPawnPrefab;
    public GameObject PlayerPawnPrefab => playerPawnPrefab;

    [SerializeField] private GameObject playerControllerPrefab;
    public GameObject PlayerControllerPrefab => playerControllerPrefab;

    [SerializeField] private GameObject newspaperPrefab;
    public GameObject NewspaperPrefab => newspaperPrefab;

    [SerializeField] private GameObject mailPrefab;
    public GameObject MailPrefab => mailPrefab;

    [SerializeField] private GameObject packagePrefab;
    public GameObject PackagePrefab => packagePrefab;

    [Header("Player Settings")]
    [SerializeField] private float playerMoveSpeed;
    public float PlayerMoveSpeed => playerMoveSpeed;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
