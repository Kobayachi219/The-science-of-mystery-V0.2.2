
using TMPro;
using UnityEngine;

public class Open_Door : MonoBehaviour
{
    [SerializeField] public Sprite newSprite;
    [SerializeField] private SpriteRenderer spriteRenderer; 
    [SerializeField] public Sprite newdoor;
    [SerializeField] private SpriteRenderer spritedoor;
    public Behaviour ScriptA;

    [SerializeField] private UnityEngine.UI.Image ImageInteract;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
       
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            ChangeSprite();
            ChangeDoor();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            
            ImageInteract.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {



            ImageInteract.gameObject.SetActive(false);

        }
    }
    void ChangeSprite()
    {
        
        if (spriteRenderer != null && newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
    void ChangeDoor()
    {
        if (newdoor != null && newdoor != null) 
        {
            spritedoor.sprite = newdoor;
            ScriptA.enabled = true;
        }
    }
}
