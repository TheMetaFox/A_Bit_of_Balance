using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationInteractor : MonoBehaviour
{
    [SerializeField] private GameObject budgetPanel;
    [SerializeField] private GameObject bitcoinPanel;

    private void Start()
    {
        budgetPanel.gameObject.SetActive(false);
        bitcoinPanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            budgetPanel.gameObject.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Bitstop"))
        {
            bitcoinPanel.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            budgetPanel.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Bitstop"))
        {
            bitcoinPanel.gameObject.SetActive(false);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
