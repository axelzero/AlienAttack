using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Animator healthAnim;
    public Image imgHealth;
    public float damage = 10f;

    public float maxHealth = 100;
    private float mHealth;

    void Start()
    {
        mHealth = maxHealth;
    }

    void Update()
    {
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        float ratio = mHealth / maxHealth;
        imgHealth.rectTransform.localScale = new Vector3(ratio, 0.65f, 1f);
    }

    public void TakeDamage()
    {
        mHealth -= damage;
        if (mHealth <= 9f)
        {
            mHealth = 0;
            Debug.Log("Dead");
            Application.LoadLevel(0);
        }
        if (mHealth <= (maxHealth / 3f))
        {
            healthAnim.Play("MinHealth");
        }

        UpdateHealthBar();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        TakeDamage();
        if (other.tag == "Enemy")
        {
            Debug.Log("Player Attacked");
        }
    }
}