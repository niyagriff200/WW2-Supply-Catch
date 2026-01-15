using UnityEngine;

public class BeginnerLevelData : LevelData
{
    [SerializeField] private int beginnerStartingLives;
    public int BeginnerStartingLives => beginnerStartingLives;

    [SerializeField][Range(0f, 1f)] private float beginnerMailChance;
    public float BeginnerMailChance => beginnerMailChance;

    [SerializeField][Range(0f, 1f)] private float beginnerNewspaperChance;
    public float BeginnerNewspaperChance => beginnerMailChance;
    
    private void Awake()
    {
        StartingLives = beginnerStartingLives;
        MailChance = beginnerMailChance;
        NewspaperChance = beginnerNewspaperChance;
    }
}
