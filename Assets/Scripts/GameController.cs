using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    void Start()
    {
        switch (DataHolder.Sex)
        {
            case 2:
                Instantiate(p1);
                Instantiate(p2);
                break;
            case 4:
                Instantiate(p1);
                Instantiate(p2);
                Instantiate(p3);
                Instantiate(p4);
                break;
        }
    }
}
