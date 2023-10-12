using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Player player; // Player °´Ã¼¸¦ °ü¸®
    public int PlayerMana { get; private set; }
    void Start()
    {
        PlayerMana = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
