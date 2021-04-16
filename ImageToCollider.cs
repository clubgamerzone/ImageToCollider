/// this script is meant to make a sprite to get the fill size of its SAME GAMEOBJECT colliders, this can be used to create some minimaps for the metroidvania game.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageToCollider : MonoBehaviour
{
    public SpriteRenderer sprite;
    public BoxCollider2D coll;
    public float xte, yte;

    // Start is called before the first frame update
    void Start()
    {
        var boundrx = sprite.size.x;
        var boundy = sprite.size.y;

        var colbx = coll.size.x;
        var offx = coll.offset.x;
        var colby = coll.size.y;
        var offy = coll.offset.y;

        sprite.size = new Vector2( colbx + offx, colby + offy);
    }

}
