using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cont : MonoBehaviour
{
    void Update()
    {
        // �������� ������� ������� � ������� �����������
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // ������� ����������� ������� �� ������� ������� �������
        Vector3 direction = cursorPosition - transform.position;

        // ������� ���� ����� ������� ������������ ������� � ������������ � �������
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // ������������ ������ � ����������� � �������
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
