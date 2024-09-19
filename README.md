
# Height Blending Shader

This project contains a simple height blending shader created using Shader Graph and an accompanying script. These files help seamlessly integrate objects with the terrain based on their height.

## How to Use

1. **Material Setup**:  
   Set the material for the object to `HolyZone/ObjectBlending`. This material is designed to blend objects with the terrain according to their height.

2. **Attach the Script**:  
   Attach the `TerrainHeightPasser` script to the object. This script passes height data from the terrain to the shader, enabling the blending process.

3. **Performance Benefits**:  
   The `TerrainHeightPasser` script utilizes **MaterialPropertyBlock**, which updates material properties efficiently. This allows you to avoid creating new material instances, improving performance when using the same material on multiple objects.

## Files

- **Shader**: The shader that performs the height blending.
- **Script**: The script that passes the height data to the shader and uses **MaterialPropertyBlock** for optimized performance.
