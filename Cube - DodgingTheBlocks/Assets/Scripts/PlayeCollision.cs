using UnityEngine;

public class PlayeCollision : MonoBehaviour {

    public SpawnBlocks spawner;
    public Blocks block;
    public GameManager manager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Block")
        {
            spawner.enabled = false;
            manager.EndGame();
             
        }
    }


}
