using UnityEngine;

public class HardLevelData : LevelData
{
    [SerializeField] private int hardStartingLives;
    public int HardStartingLives => hardStartingLives;

    [SerializeField][Range(0f, 1f)] private float hardMailChance;
    public float HardMailChance => hardMailChance;

    [SerializeField][Range(0f, 1f)] private float hardNewspaperChance;
    public float HardNewspaperChance;

    private void Awake()
    {
        StartingLives = hardStartingLives;
        MailChance = hardMailChance;
        NewspaperChance = hardNewspaperChance;
    }
}
