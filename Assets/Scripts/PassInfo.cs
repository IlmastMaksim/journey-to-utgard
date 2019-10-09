using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassInfo : MonoBehaviour
{
    public bool viking;
    public string player;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        player = "Player";
    }
}
