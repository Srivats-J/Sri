using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{


    private static GameObject player1;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;

    public static bool gameOver = false;

    // Use this for initialization
    void Start()
    {


        player1 = GameObject.Find("Piece");

        player1.GetComponent<PieceMoving>().moveAllowed = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<PieceMoving>().Index >
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<PieceMoving>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<PieceMoving>().Index - 1;
        }


    }
    
    //For the ladder
   // void Ladders()
    //{

    //}

    //void snakes()
    //{

    //}
   

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<PieceMoving>().moveAllowed = true;
                break;
        }
    }
}

