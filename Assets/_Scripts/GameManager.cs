using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Transform mugLayout;
    [SerializeField] GameObject Mug;

    int colorCount;
    public List<Color> colorsToBeUsed;
    public List<Color> basicColors;

    int level=1;

    private void Awake()
    {
        instance = this;
        CreateColors(5);
    }

    void CreateColors(int count)
    {
        colorCount = count;

        while (colorCount > 0)
        {
            for (int i = 0; i < 4; i++)
            {
                colorsToBeUsed.Add(basicColors[colorCount - 1]);
            }
            colorCount--;
        }
    }

    private void Start()
    {
        CreateMugs(level);
    }

    void CreateMugs(int count)
    {
        Instantiate(Mug, mugLayout);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)) CreateMugs(1);
    }



}
