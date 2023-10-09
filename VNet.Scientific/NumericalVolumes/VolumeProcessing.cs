using VNet.Scientific.Interpolation;

namespace VNet.Scientific.NumericalVolumes;

public static class VolumeProcessing
{
    private static double GaussianKernel(double distance, double sigma)
    {
        return (1.0 / (Math.Sqrt(2 * Math.PI) * sigma)) * Math.Exp(-0.5 * (distance / sigma) * (distance / sigma));
    }

    public static double[,,] ApplyGaussianSmoothing(double[,,] volume, double sigma)
    {
        var smoothedVolume = new double[volume.GetLength(0), volume.GetLength(1), volume.GetLength(2)];

        var kernelRadius = (int)Math.Ceiling(3 * sigma);

        for (var i = 0; i < volume.GetLength(0); i++)
        {
            for (var j = 0; j < volume.GetLength(1); j++)
            {
                for (var k = 0; k < volume.GetLength(2); k++)
                {
                    double sum = 0;
                    double weightSum = 0;

                    for (var dx = -kernelRadius; dx <= kernelRadius; dx++)
                    {
                        for (var dy = -kernelRadius; dy <= kernelRadius; dy++)
                        {
                            for (var dz = -kernelRadius; dz <= kernelRadius; dz++)
                            {
                                if (i + dx < 0 || i + dx >= volume.GetLength(0) ||
                                    j + dy < 0 || j + dy >= volume.GetLength(1) ||
                                    k + dz < 0 || k + dz >= volume.GetLength(2)) continue;
                                var weight = GaussianKernel(Math.Sqrt(dx * dx + dy * dy + dz * dz), sigma);
                                sum += weight * volume[i + dx, j + dy, k + dz];
                                weightSum += weight;
                            }
                        }
                    }

                    smoothedVolume[i, j, k] = sum / weightSum;
                }
            }
        }

        return smoothedVolume;
    }


    public static void FloodFill(double[,,] structureVolume, int[,,] labels, int x, int y, int z, int label, double threshold)
    {
        var queue = new Queue<(int x, int y, int z)>();
        queue.Enqueue((x, y, z));

        while (queue.Count > 0)
        {
            var voxel = queue.Dequeue();
            if (voxel.x < 0 || voxel.x >= structureVolume.GetLength(0) ||
                voxel.y < 0 || voxel.y >= structureVolume.GetLength(1) ||
                voxel.z < 0 || voxel.z >= structureVolume.GetLength(2))
                continue;

            if (structureVolume[voxel.x, voxel.y, voxel.z] <= threshold || labels[voxel.x, voxel.y, voxel.z] > 0)
                continue;

            labels[voxel.x, voxel.y, voxel.z] = label;

            queue.Enqueue((voxel.x + 1, voxel.y, voxel.z));
            queue.Enqueue((voxel.x - 1, voxel.y, voxel.z));
            queue.Enqueue((voxel.x, voxel.y + 1, voxel.z));
            queue.Enqueue((voxel.x, voxel.y - 1, voxel.z));
            queue.Enqueue((voxel.x, voxel.y, voxel.z + 1));
            queue.Enqueue((voxel.x, voxel.y, voxel.z - 1));
        }
    }

    public static double[,,] InterpolateVolume(double[,,] dataSet, double scaleFactor, IInterpolationAlgorithm algorithm)
    {
        var x = dataSet.GetLength(0);
        var y = dataSet.GetLength(1);
        var z = dataSet.GetLength(2);

        var expandedX = (int)(x * scaleFactor);
        var expandedY = (int)(y * scaleFactor);
        var expandedZ = (int)(z * scaleFactor);

        var expandedVolume = new double[expandedX, expandedY, expandedZ];

        var flatData = new double[x * y * z];
        VolumeFunctions.RunVolumeFunction(x, y, z, (int i, int j, int k) => { flatData[i * y * z + j * z + k] = dataSet[i, j, k]; });

        VolumeFunctions.RunVolumeFunction(x, y, z, (int i, int j, int k) =>
        {
            int[] targetIndices =
            {
                (int) (i / scaleFactor),
                (int) (j / scaleFactor),
                (int) (k / scaleFactor)
            };
            expandedVolume[i, j, k] = algorithm.Interpolate(flatData, null /* or some args instance */, new int[] { x, y, z }, targetIndices);
        });

        return expandedVolume;
    }
}