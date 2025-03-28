using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TetrisGenerator : MonoBehaviour
{
    [SerializeField] private List<TetrisBlock> blocks;

    private void Start()
    {
        SpawnBlock();
    }

    private void SpawnBlock()
    {
        Instantiate(blocks[Random.Range(0, blocks.Count)], new Vector3(0, 10, 0), Quaternion.identity);
    }
}
