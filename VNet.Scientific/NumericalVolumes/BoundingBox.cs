using System.Numerics;
// ReSharper disable MemberCanBePrivate.Global

namespace VNet.Scientific.NumericalVolumes
{
    public class BoundingBox<TVal> where TVal : INumber<TVal>
    {
        public float Volume => (float)Math.Pow(SideLength, 3);
        public Vector3 Origin { get; set; }
        public float CellSize { get; set; }
        public int LocalGridLength { get; set; }
        public float SideLength => CellSize * LocalGridLength;
        public Matrix4x4 Rotation { get; set; }
        public TVal[,,] Values { get; set; }

        public BoundingBox(Vector3 origin, float cellSize, Vector3 orientation)
        {
            Origin = origin;
            CellSize = cellSize;

            var sideLength = orientation.Length();
            LocalGridLength = (int)Math.Round(sideLength / CellSize);

            Values = new TVal[LocalGridLength, LocalGridLength, LocalGridLength];

            var forward = Vector3.Normalize(orientation);
            var reference = Math.Abs(Vector3.Dot(forward, Vector3.UnitY)) < 0.9f ? Vector3.UnitY : Vector3.UnitX;
            var right = Vector3.Normalize(Vector3.Cross(forward, reference));
            var up = Vector3.Cross(right, forward);

            Rotation = new Matrix4x4(
                right.X, right.Y, right.Z, 0,
                up.X, up.Y, up.Z, 0,
                forward.X, forward.Y, forward.Z, 0,
                0, 0, 0, 1
            );
        }

        public Vector3 LocalToGlobal(Vector3 localPosition)
        {
            var rotatedPosition = Vector3.Transform(localPosition, Rotation);
            return Origin + rotatedPosition;
        }

        public (int i, int j, int k) GlobalToLocal(Vector3 globalPosition)
        {
            var relativePosition = globalPosition - Origin;

            if (Matrix4x4.Invert(Rotation, out var inverseRotation))
            {
                var localPosition = Vector3.Transform(relativePosition, inverseRotation);
                var i = (int)(localPosition.X / CellSize);
                var j = (int)(localPosition.Y / CellSize);
                var k = (int)(localPosition.Z / CellSize);

                return (i, j, k);
            }
            else
            {
                throw new InvalidOperationException("The rotation matrix is not invertible.");
            }
        }
    }
}