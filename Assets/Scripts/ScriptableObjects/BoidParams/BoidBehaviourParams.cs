﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Boid Behaviour Params")]
public class BoidBehaviourParams : ScriptableObject
{
    [Header("Force parameters")]
    public float moveSpeed = 5f;
    [Min(0)] public float mass = 1f;
    [Range(0, 1)] public float friction = 0f;

    [Header("Reaction to other boids")]
    public float neighbourDistance = 10f;
    public float avoidDistance = 1f;
    public float avoidSpeed = 1f;
    public int numClosestToCheck = 5;

    [Header("Cursor/goal following")]
    public bool useCursorFollow;
    public float cursorFollowSpeed = 1f;

    [Tooltip("Distance from the target at which the boid will begin to slow down in anticipation of arriving at the target")]
    public float arrivalSlowStartDist = 10f;
    public bool useRandomGoal;
    public float goalFollowSpeed = 1f;

    [Header("Bounding coordinates")]
    public bool useBoundingCoordinates = true;
    public Vector3 boundsCentre = Vector3.zero;
    public float boundsSize; //size of cube representing boid bounding area (centre is at (0, 0, 0))
    public float boundsReturnSpeed = 1f;

    [Header("Obstacle avoidance")]
    public bool usePreemptiveObstacleAvoidance = true;
    public bool useObstacleRepulsion = true;
    public float obstacleAvoidDistance;
    public float obstacleAvoidSpeed = 5f;

    [Header("Idle behaviour")]
    public bool useIdleMvmt = true;
    public float idleNoiseFrequency = 0.01f;
    public float idleSpeed = 1f;
    public bool useTimeOffset = false;
}
