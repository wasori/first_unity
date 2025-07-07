using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }
    void OnEnable()
    {
        Debug.Log("�÷��̾ �α��� �߽��ϴ�.");
    }
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    void Update()
    {
        Debug.Log("���� ���!!");
    }
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��");
    }

    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ� �߽��ϴ�.");
    }

    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
}
