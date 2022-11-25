using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public partial class MovingSystemBase : SystemBase
{
    protected override void OnUpdate()
    {
        foreach (TransformAspect transformAspect in SystemAPI.Query<TransformAspect>())
        {
            transformAspect.Position += new Unity.Mathematics.float3(SystemAPI.Time.DeltaTime, 0, 0);
        }
        /** Same Code
        Entities.ForEach((TransformAspect transformAspect) =>
        {
            transformAspect.Position += new Unity.Mathematics.float3(SystemAPI.Time.DeltaTime, 0, 0);

        }).Schedule(); /Run(); / ScheduleParallel();
        **/
    }
}
