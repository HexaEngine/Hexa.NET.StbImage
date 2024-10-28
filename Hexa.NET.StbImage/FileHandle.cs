namespace Hexa.NET.StbImage
{
    public struct FileHandle : IEquatable<FileHandle>
    {
        public unsafe void* Handle;

        public unsafe FileHandle(void* handle)
        {
            Handle = handle;
        }

        public unsafe FileHandle(nint handle)
        {
            Handle = (void*)handle;
        }

        public unsafe static implicit operator void*(FileHandle handle) => handle.Handle;

        public unsafe static implicit operator nint(FileHandle handle) => (nint)handle.Handle;

        public unsafe static implicit operator FileHandle(void* handle) => new(handle);

        public unsafe static implicit operator FileHandle(nint handle) => new(handle);

        public readonly override bool Equals(object? obj) => obj is FileHandle handle && Equals(handle);

        public readonly unsafe bool Equals(FileHandle other) => Handle == other.Handle;

        public readonly unsafe override int GetHashCode() => ((nint)Handle).GetHashCode();

        public static bool operator ==(FileHandle left, FileHandle right) => left.Equals(right);

        public static bool operator !=(FileHandle left, FileHandle right) => !(left == right);
    }
}
