using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary> �㉺�Ɉړ����鎞��Y�̊Ԋu </summary>
    [SerializeField] float distanceY;

    /// <summary> �v���C���[�̍ŏ��̍��W </summary>
    Vector3 startPos;

    /// <summary> �v���C���[�������(-2 ~ 2) </summary>
    int lanePos;

    void Start()
    {
        startPos = transform.position;
        lanePos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ///��
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && lanePos < 2)
        {
            lanePos++;
            Debug.Log(lanePos);
        }
        ///��
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && lanePos > -2)
        {
            lanePos--;
            Debug.Log(lanePos);
        }
        transform.position = new Vector3(transform.position.x, lanePos * distanceY, transform.position.z);
    }
}
