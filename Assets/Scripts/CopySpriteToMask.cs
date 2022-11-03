using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopySpriteToMask : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _source;
    [SerializeField]
    private SpriteMask _target;
    
    public void CopySprite()
    {
        _target.sprite = _source.sprite;
    }
}
