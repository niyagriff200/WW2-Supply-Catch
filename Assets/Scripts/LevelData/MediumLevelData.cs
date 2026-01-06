using UnityEngine;

public class MediumLevelData : LevelData
{
    [SerializeField] private int mediumStartingLives;
    public int MediumStartingLives => mediumStartingLives;

    [SerializeField][Range(0f, 1f)] private float mediumMailChance;
    public float MediumMailChance => mediumMailChance;

    [SerializeField] private float mediumNewspaperChance;
    public float MediumNewspaperChance => mediumMailChance;

    private void Awake()
    {
        StartingLives = mediumStartingLives;
        MailChance = mediumMailChance;
        NewspaperChance = mediumNewspaperChance;
    }
}
