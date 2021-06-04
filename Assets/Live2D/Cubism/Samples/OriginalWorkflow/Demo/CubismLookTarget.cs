/*
 * Copyright(c) Live2D Inc. All rights reserved.
 * 
 * Use of this source code is governed by the Live2D Open Software license
 * that can be found at http://live2d.com/eula/live2d-open-software-license-agreement_en.html.
 */


using Live2D.Cubism.Framework.LookAt;
using UnityEngine;


public class CubismLookTarget : MonoBehaviour, ICubismLookTarget
{
    public Vector3 GetPosition()
    {
        if (!Input.GetMouseButton(0)) return Vector3.zero;

        var targetPosition = Input.mousePosition;

        targetPosition = (Camera.main.ScreenToViewportPoint(targetPosition) * 7) - Vector3.one;

        return targetPosition;
    }


    public bool IsActive()
    {
        return true;
    }
}
