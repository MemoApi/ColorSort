using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    [SerializeField] List<GameObject> balls;
    

    List<Color> colorsToBeUsed;

    private void Start()
    {
        colorsToBeUsed = GameManager.instance.colorsToBeUsed;
        for (int i = 0; i < 4; i++)
        {
        balls.Add(transform.GetChild(i).gameObject);
        }

        if (colorsToBeUsed.Count >= 4) 
        for (int i = 0; i < 4; i++)
        {
            int random = Random.Range(0, colorsToBeUsed.Count);
            balls[i].GetComponent<Renderer>().material.color =colorsToBeUsed[random];
            colorsToBeUsed.RemoveAt(random);

        }

    }

    private void Update()
    {
     // balls[0].GetComponent<MeshRenderer>().enabled = false;
       
     // balls[0].GetComponent<Renderer>().material.color = Color.red;
        

        

    }
    private void OnMouseDown()
    {

        transform.Translate(Vector3.up);

        Color first=Color.white;

        foreach (var ball in balls)
        {
            if(ball.gameObject.GetComponent<MeshRenderer>().enabled)
            {
                first = ball.gameObject.GetComponent<Renderer>().material.color;
                break;
            }
            
        }
        Debug.Log(first);

        foreach (var ball in balls)
        {

        }



    }


}
