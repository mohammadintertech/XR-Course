using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TimedTrigger : MonoBehaviour
{
    [SerializeField] private GameObject box;
    private float counter = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(counter);
        counter += Time.deltaTime;
        if (counter > 2.9f && counter < 3f)
        {
            box.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            counter = 0f;

        }
    }
}
