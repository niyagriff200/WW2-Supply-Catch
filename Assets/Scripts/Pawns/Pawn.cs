using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    private Health health;
    public Health Health
    {
        get { return health; }
        set { health = value; }
    }

    public abstract void Move(Vector3 moveVector);
    protected virtual void Start()
    {
        Health = GetComponentInChildren<Health>();
    }
}
