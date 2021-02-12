using System.Collections;
using UnityEngine;
public class CheckPointController : MonoBehaviour
{
    public Sprite redFlag;
    public Sprite greenFlag;
    private SpriteRenderer checkpointspriteRenderer;
    public bool checkpointReached;
    void Start()
    {
        checkpointspriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Player")
        {
            checkpointspriteRenderer.sprite = greenFlag;
            checkpointReached = true;
        }
    }
}
