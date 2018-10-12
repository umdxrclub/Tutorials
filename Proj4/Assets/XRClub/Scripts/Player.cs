using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float maxHealth = 50;
    float health;

    private void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

		if (Physics.Raycast(ray, out hit, 100))
        {
            Vector3 pos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            Vector3 targetDir = pos - transform.position;

            transform.rotation = Quaternion.LookRotation(targetDir, Vector3.up);

            GetComponent<Animator>().SetFloat("Speed", Mathf.Pow(targetDir.magnitude, 2));
        }
        else
        {
            GetComponent<Animator>().SetFloat("Speed", 0);
        }
    }

    public void Damage(float damage)
    {
        health -= damage;
        Image healthBar = FindObjectsOfType<Image>()[2];

        healthBar.fillAmount = health / maxHealth;

        if (health <= 0)
        {
            GameObject item = CharacterSelect.FindRecursive(transform, CharacterData.leftHand.name + "(Clone)").gameObject;
            item.transform.parent = null;
            item.transform.position = CharacterSelect.FindRecursive(transform, GetComponent<LeftHand>().handName).position;
            item.AddComponent<Rigidbody>();

            GetComponent<Ragdoll>().SpawnRagdoll();
        }
    }
}
