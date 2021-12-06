using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    static AudioClip coin, win, lose, enemyEaten, playerHit;
    static AudioSource soundManager;
    void Start()
    {
        coin = Resources.Load<AudioClip>("coin");
        win = Resources.Load<AudioClip>("Win");
        lose = Resources.Load<AudioClip>("Lose");
        enemyEaten = Resources.Load<AudioClip>("EnemyEaten");
        playerHit = Resources.Load<AudioClip>("PlayerHit");

        soundManager = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string sound)
    {
        switch (sound)
        {
            case "win":
                soundManager.PlayOneShot(win);
                break;
            case "lose":
                soundManager.PlayOneShot(lose);
                break;
            case "coin":
                soundManager.PlayOneShot(coin);
                break;
            case "enemyEaten":
                soundManager.PlayOneShot(enemyEaten);
                break;
            case "playerHit":
                soundManager.PlayOneShot(playerHit);
                break;

        }
    }
}
