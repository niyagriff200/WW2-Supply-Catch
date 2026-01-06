using UnityEngine;

public class PlayerPawn : Pawn
{
    private float moveSpeed;

    protected override void Start()
    {
        base.Start();
        moveSpeed = GameManager.Instance.PlayerMoveSpeed;
    }

    public override void Move(Vector3 moveVector)
    {
        transform.position += moveVector * moveSpeed * Time.deltaTime;
    }
}
