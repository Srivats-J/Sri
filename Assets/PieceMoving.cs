using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMoving : MonoBehaviour
{
    public Transform[] points;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int Index = 0;

    public bool moveAllowed = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[Index].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAllowed)
            Move();
    }
    private void Move()
    {
        if (Index <= points.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,points[Index].transform.position,moveSpeed * Time.deltaTime);

            if (transform.position == points[Index].transform.position)
            {
                Index += 1;
            }
        }
    }
}
