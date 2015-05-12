using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace _05_64BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        private const byte BITS = 64;

        public BitArray64(ulong value)
        {
            this.Value = value;
        }

        public ulong Value { get; set; }

        public byte this[int index]
        {
            get
            {
                return (byte)((this.Value >> index) & 1);
            }
            set
            {
                if (((int)(this.Value >> index) & 1) != value)
                {
                    this.Value ^= (1ul << index);
                }
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public override bool Equals(object bitArray)
        {
            var second = bitArray as BitArray64;
            return this.Value.Equals(second.Value);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < BITS; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.Value.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int index = 0; index < 64; index++)
            {
                result.Insert(0, ((this.Value >> index) & 1));
            }

            return result.ToString();
        }
    }
}
