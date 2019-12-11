using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTorch2 : MonoBehaviour
{
    public bool isTorchLit = false;
    public PuzzleTorchManager puzzleManager;

    public Sprite unlitSprite;
    public Sprite litSprite;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        puzzleManager = transform.parent.GetComponent<PuzzleTorchManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        SpriteUpdate();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {

            if (isTorchLit)
            {
                isTorchLit = false;
                puzzleManager.RemoveTorch();
                SpriteUpdate();
            }
            else
            {
                isTorchLit = true;
                puzzleManager.AddTorch();
                SpriteUpdate();
            }
        }
    }

    private void SpriteUpdate()
    {
        if (isTorchLit)
        {
            spriteRenderer.sprite = litSprite;
        }
        else
        {
            spriteRenderer.sprite = unlitSprite;
        }
    }
}
