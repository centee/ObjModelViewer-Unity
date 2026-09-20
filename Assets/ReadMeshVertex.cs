using UnityEngine;

public class ReadMeshVertex : MonoBehaviour
{
    void Start()
    {
        // 在自身以及所有子物体中查找MeshFilter
        MeshFilter mf = GetComponentInChildren<MeshFilter>();

        if (mf == null)
        {
            Debug.LogError("子物体里也找不到MeshFilter！");
            return;
        }
        Mesh mesh = mf.mesh;
        if (mesh == null)
        {
            Debug.LogError("Mesh为空！");
            return;
        }

        Vector3[] vertices = mesh.vertices;
        Debug.Log($"兔子模型 顶点总数量 = {vertices.Length}");

        // 打印前20个顶点
        for (int i = 0; i < vertices.Length && i < 20; i++)
        {
            Debug.Log($"顶点{i} : {vertices[i]}");
        }
    }
}
