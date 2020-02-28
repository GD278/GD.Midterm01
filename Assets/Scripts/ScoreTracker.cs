using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text ScoreTextBox;
    
    int i;
    
    void Start()
    {
        i = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Player" && other.gameObject.tag == "Hoop")
        {
            Debug.Log("You have entered the trigger.");
            i++;
            Debug.Log("Score added.");
            Destroy(other.gameObject);
            Debug.Log("Trigger destroyed.");
            ScoreTextBox.text = $"Score: {i}";
        }
    }
}
