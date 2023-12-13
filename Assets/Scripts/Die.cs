using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public LevelManager levelManager;
    [SerializeField] private AudioSource dieSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Dog")
        {
            dieSoundEffect.Play();
            levelManager.RespawnPlayer();
        }
    }
}
