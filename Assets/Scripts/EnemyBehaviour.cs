using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyBehaviour : MonoBehaviour
{

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.transform.position;
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Player")
            SceneManager.LoadScene("lose", LoadSceneMode.Additive);
    }
}
