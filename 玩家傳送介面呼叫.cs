using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    private TeleportMenu teleportMenu; 
    private bool isPlayerInside = false; 

    private void Update()
    {
        if (isPlayerInside && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("發送");
            ToggleTeleportMenu();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("目標" + other);
            teleportMenu = other.GetComponent<TeleportMenu>();
            isPlayerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DisableTeleportMenu();
            isPlayerInside = false;
        }
    }

    private void DisableTeleportMenu()
    {
        if (teleportMenu != null)
        {
            teleportMenu.CloseTeleportMenu();
        }
    }

    private void ToggleTeleportMenu()
    {
        if (teleportMenu != null)
        {
            Debug.Log("發送目標");
            teleportMenu.ToggleTeleportMenu();
        }
    }
}
