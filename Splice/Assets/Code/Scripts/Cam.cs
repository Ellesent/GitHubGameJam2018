using UnityEngine;

/// <summary>
/// Script that defines behavior for the camera during gameplay
/// </summary>
public class Cam : MonoBehaviour
{

    [SerializeField]
    GameObject playerPos; // TODO: Grab this by finding the game object rather than passing in through field -will break on other scenes

    [SerializeField]
    ScreenUtils screenUtils; // TODO: Grab this by finding game object 

    private float initialY; // The initial y postion of the camera (we never want the camera to go below this)

    private float xPos;

    // Use this for initialization
    void Start()
    {
        initialY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        // Setting the x position of the camera to have player ball on right side of screen
        xPos = playerPos.transform.position.x + (screenUtils.ScreenWidthCoord) - playerPos.GetComponent<Player>().SpriteCenter.x - Constants.PLAYER_PADDING_FROM_SCREEN;

        transform.position = new Vector3(xPos, playerPos.transform.position.y, -10);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, initialY, 500), -10);
    }
}
