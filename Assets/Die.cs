using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour

{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];

    }
    private void OnMouseDown()
    {
        if (coroutineAllowed)
            StartCoroutine("RollTheDice");
    }
    private IEnumerator RollTheDice()
    {
        coroutineAllowed = true;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        }
        coroutineAllowed = true;
    }


}
