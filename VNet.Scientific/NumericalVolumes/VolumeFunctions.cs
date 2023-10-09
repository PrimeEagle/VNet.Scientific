namespace VNet.Scientific.NumericalVolumes
{
    public static class VolumeFunctions
    {
        public static void RunVolumeFunction(int x, int y, int z, Action<int, int, int> function)
        {
            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        function(i, j, k);
                    }
                }
            }
        }

        public static void RunNeighborFunction(int lowerBound, int upperBound, Action<int, int, int> function)
        {
            for (var dx = lowerBound; dx <= upperBound; dx++)
            {
                for (var dy = lowerBound; dy <= upperBound; dy++)
                {
                    for (var dz = lowerBound; dz <= upperBound; dz++)
                    {
                        function(dx, dy, dz);
                    }
                }
            }
        }
    }
}