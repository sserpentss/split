using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.name)
        {
            case "Player 1":
                Vector3 P1 = new Vector3(-31.1f, -4.1f, 0);
                other.transform.position = P1;
                break;
            case "Player 2":
                Vector3 P2 = new Vector3(25.1f, -6.4f, 0);
                other.transform.position = P2;
                break;
            case "Player 3":
                Vector3 P3 = new Vector3(-30.58f, 12.98f, 0);
                other.transform.position = P3;
                break;
            case "Player 4":
                Vector3 P4 = new Vector3(29f, 19f, 0);
                other.transform.position = P4;
                break;

        }


    }

}
