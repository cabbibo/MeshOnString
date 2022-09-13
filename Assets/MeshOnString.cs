using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Mathematics.math;

public class MeshOnString : MonoBehaviour
{

    public Vector3 dimension;
    public float length;
    public ComputeBuffer _RopePoints;
    public ComputeBuffer _VertBuffer;
    public ComputeBuffer _TriBuffer;
    public int numPointsInRope;
    public Transform[] ropeAnchors;

    public Mesh mesh;
    public ComputeShader shader;
    

    int numVerts;
    int numTris;

    int ropeBufferStructSize;
    int vertBufferStructSize;


    // Start is called before the first frame update
    void  OnEnable()
    {

        numVerts = mesh.verts.Length;
        numTris = mesh.tris.Length;
    
        _RopeBuffer = new ComputeBuffer[ numPointsInRope * numInstances  * ropeBufferStructSize];
        _VertBuffer = new ComputeBuffer[ numVerts *  numInstances * vertBufferStructSize ];
        
    }

    void  OnEnable()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
