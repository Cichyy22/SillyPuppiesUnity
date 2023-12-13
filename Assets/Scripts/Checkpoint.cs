using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public LevelManager levelManager;
    [SerializeField] private AudioSource checkpointSoundEffect;
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
            checkpointSoundEffect.Play();
            levelManager.currCheckpoint = gameObject;
            Debug.Log("Activated chekpoint" + transform.position);
        }
    }
}
