using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoleScript : Clickable
{
    public bool isHurt = false;
    public Animator moleAnim;
    public GameObject explosion;
    public float timeOnScreen;
    public int pointValue;
    public int livesValue;

    protected override void Start()
    {
        base.Start();
        moleAnim = GetComponent<Animator>();
    }

    public void Update()
    {
        StartCoroutine(DestroyIfNotClicked(timeOnScreen));
    }

    protected override void GotClicked()
    {
        if (!isHurt)
        {
            base.GotClicked();
            moleAnim.SetBool("isHurt", isHurt);
            GameObject thisExplosion =  Instantiate(explosion, transform.position, explosion.transform.rotation);
            Destroy(gameObject, 1);
            Destroy(thisExplosion, 1.1f);
            isHurt = true;
            gm.UpdateScore(pointValue);
        }
    }

    IEnumerator DestroyIfNotClicked(float timeOnScreen)
    {
        if (!isHurt)
        {
            yield return new WaitForSeconds(timeOnScreen);
            Destroy(gameObject);
            gm.UpdateLives(livesValue);
        }
    }

}
