using PlayFab;
using PlayFab.ClientModels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardScriptableObject Template;

    public SpriteRenderer Sprite;

    public void init(CardScriptableObject newCard)
    {
        Template = newCard;
        Sprite.sprite = Template.Image;
        gameObject.AddComponent<BoxCollider2D>();
        transform.localPosition = new Vector3(-1000, -1000, 0);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
