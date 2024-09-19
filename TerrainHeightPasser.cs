using UnityEngine;

[ExecuteAlways]
public class TerrainHeightPasser : MonoBehaviour
{
    public Renderer rockRenderer;
    public float BlendDistance = 1.5f;
    public float Opacity = 1f;

    private MaterialPropertyBlock propertyBlock;

    void Awake()
    {
        rockRenderer = gameObject.GetComponent<Renderer>();

        if (rockRenderer == null)
        {
            return;
        }

        propertyBlock = new MaterialPropertyBlock();

        if (propertyBlock == null)
        {
            return;
        }
    }

    void Update()
    {
        if (Terrain.activeTerrain == null)
        {
            return;
        }

        if (propertyBlock == null)
        {
            propertyBlock = new MaterialPropertyBlock();
        }

        float terrainHeight = Terrain.activeTerrain.SampleHeight(transform.position);

        propertyBlock.SetFloat("_TerrainHeight", terrainHeight);
        propertyBlock.SetFloat("_SmoothMax", BlendDistance * Opacity);
        propertyBlock.SetFloat("_Opacity", Opacity);
        rockRenderer.SetPropertyBlock(propertyBlock);
    }
}