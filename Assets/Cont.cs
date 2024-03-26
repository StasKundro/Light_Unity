using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cont : MonoBehaviour
{
    void Update()
    {
        // Получаем позицию курсора в мировых координатах
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Находим направление курсора от текущей позиции объекта
        Vector3 direction = cursorPosition - transform.position;

        // Находим угол между текущим направлением объекта и направлением к курсору
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Поворачиваем объект в направлении к курсору
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
