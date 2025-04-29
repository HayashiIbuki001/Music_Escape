using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary> 上下に移動する時のYの間隔 </summary>
    [SerializeField] float distanceY;

    /// <summary> プレイヤーの最初の座標 </summary>
    Vector3 startPos;

    /// <summary> プレイヤーがいる列(-2 ~ 2) </summary>
    int lanePos;

    void Start()
    {
        startPos = transform.position;
        lanePos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ///上
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && lanePos < 2)
        {
            lanePos++;
            Debug.Log(lanePos);
        }
        ///下
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && lanePos > -2)
        {
            lanePos--;
            Debug.Log(lanePos);
        }
        transform.position = new Vector3(transform.position.x, lanePos * distanceY, transform.position.z);
    }
}
