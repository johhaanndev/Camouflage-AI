using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    // gene for colour
    public float r;
    public float g;
    public float b;
    public float s;

    private bool dead = false;
    public float timeToDie = 0f;
    private SpriteRenderer sRenderer;
    private Collider2D sCollider;

    private void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        Debug.Log($"Dead at: {timeToDie}");
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, g, b);
        transform.localScale = new Vector3(s, s, s);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
