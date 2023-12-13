using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Player player;
    public GameObject currCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
        player = FindObjectOfType<Player>();
    }
    

    public void RespawnPlayer()
    {
        Debug.Log("Player respawn");
        player.transform.position = currCheckpoint.transform.position;
    }
}
