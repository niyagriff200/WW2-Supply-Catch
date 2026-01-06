using UnityEngine;

public class PlayerController : Controller
{
    [SerializeField] private PlayerPawn playerPawn;
    public PlayerPawn PlayerPawn
    {
        get { return playerPawn; }
        set
        {
            playerPawn = value;
            if (playerPawn == null)
            {
                Debug.LogWarning("PlayerController.Pawn is being set to null");
            }
        }
    }

    private void Update()
    {
        if (playerPawn != null)
        {
            if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
            {
                playerPawn.Move(Vector3.left);
            }

            if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
            {
                playerPawn.Move(Vector3.right);
            }
        }
    }
}
