using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;

namespace YGCLib
{
    public class Tester
    {
        public byte[] buffer;

        public Tester()
        {
            buffer = new byte[] {188, 0, 0, 0, 52, 33, 0, 48 };
            buffer = buffer.Reverse().ToArray();
            
        }

        public ref TesterData Data
        {
            get
            {
                Span<byte> span = buffer.AsSpan()[0..^1];
                ref TesterData data = ref Unsafe.As<byte, TesterData>(ref span[0]);
                return ref data;
            }
        }

    }

    [StructLayout(LayoutKind.Sequential,Pack =1)]
    public struct TesterData
    {
        public short Data3;
        public byte Data2;
        public int Data1;
    }
}
