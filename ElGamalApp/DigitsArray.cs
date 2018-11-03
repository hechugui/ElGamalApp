using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamalApp
{
    using DType = System.UInt32; // This could be UInt32, UInt16 or Byte; not UInt64.

    #region DigitsArray
    internal class DigitsArray
    {
        internal DigitsArray(int size)
        {
            Allocate(size, 0);
        }

        internal DigitsArray(int size, int used)
        {
            Allocate(size, used);
        }

        internal DigitsArray(DType[] copyFrom)
        {
            Allocate(copyFrom.Length);
            CopyFrom(copyFrom, 0, 0, copyFrom.Length);
            ResetDataUsed();
        }

        internal DigitsArray(DigitsArray copyFrom)
        {
            Allocate(copyFrom.Count, copyFrom.DataUsed);
            Array.Copy(copyFrom.m_data, 0, m_data, 0, copyFrom.Count);
        }

        private DType[] m_data;

        internal static readonly DType AllBits;     // = ~((DType)0);
        internal static readonly DType HiBitSet;    // = 0x80000000;
        internal static int DataSizeOf
        {
            get { return sizeof(DType); }
        }

        internal static int DataSizeBits
        {
            get { return sizeof(DType) * 8; }
        }

        static DigitsArray()
        {
            unchecked
            {
                AllBits = (DType)~((DType)0);
                HiBitSet = (DType)(((DType)1) << (DataSizeBits) - 1);
            }
        }

        public void Allocate(int size)
        {
            Allocate(size, 0);
        }

        public void Allocate(int size, int used)
        {
            m_data = new DType[size + 1];
            m_dataUsed = used;
        }

        internal void CopyFrom(DType[] source, int sourceOffset, int offset, int length)
        {
            Array.Copy(source, sourceOffset, m_data, 0, length);
        }

        internal void CopyTo(DType[] array, int offset, int length)
        {
            Array.Copy(m_data, 0, array, offset, length);
        }

        internal DType this[int index]
        {
            get
            {
                if (index < m_dataUsed) return m_data[index];
                return (IsNegative ? (DType)AllBits : (DType)0);
            }
            set { m_data[index] = value; }
        }

        private int m_dataUsed;
        internal int DataUsed
        {
            get { return m_dataUsed; }
            set { m_dataUsed = value; }
        }

        internal int Count
        {
            get { return m_data.Length; }
        }

        internal bool IsZero
        {
            get { return m_dataUsed == 0 || (m_dataUsed == 1 && m_data[0] == 0); }
        }

        internal bool IsNegative
        {
            get { return (m_data[m_data.Length - 1] & HiBitSet) == HiBitSet; }
        }

        internal void ResetDataUsed()
        {
            m_dataUsed = m_data.Length;
            if (IsNegative)
            {
                while (m_dataUsed > 1 && m_data[m_dataUsed - 1] == AllBits)
                {
                    --m_dataUsed;
                }
                m_dataUsed++;
            }
            else
            {
                while (m_dataUsed > 1 && m_data[m_dataUsed - 1] == 0)
                {
                    --m_dataUsed;
                }
                if (m_dataUsed == 0)
                {
                    m_dataUsed = 1;
                }
            }
        }

        internal int ShiftRight(int shiftCount)
        {
            return ShiftRight(m_data, shiftCount);
        }

        internal static int ShiftRight(DType[] buffer, int shiftCount)
        {
            int shiftAmount = DigitsArray.DataSizeBits;
            int invShift = 0;
            int bufLen = buffer.Length;

            while (bufLen > 1 && buffer[bufLen - 1] == 0)
            {
                bufLen--;
            }

            for (int count = shiftCount; count > 0; count -= shiftAmount)
            {
                if (count < shiftAmount)
                {
                    shiftAmount = count;
                    invShift = DigitsArray.DataSizeBits - shiftAmount;
                }

                ulong carry = 0;
                for (int i = bufLen - 1; i >= 0; i--)
                {
                    ulong val = ((ulong)buffer[i]) >> shiftAmount;
                    val |= carry;

                    carry = ((ulong)buffer[i]) << invShift;
                    buffer[i] = (DType)(val);
                }
            }

            while (bufLen > 1 && buffer[bufLen - 1] == 0)
            {
                bufLen--;
            }

            return bufLen;
        }

        internal int ShiftLeft(int shiftCount)
        {
            return ShiftLeft(m_data, shiftCount);
        }

        internal static int ShiftLeft(DType[] buffer, int shiftCount)
        {
            int shiftAmount = DigitsArray.DataSizeBits;
            int bufLen = buffer.Length;

            while (bufLen > 1 && buffer[bufLen - 1] == 0)
            {
                bufLen--;
            }

            for (int count = shiftCount; count > 0; count -= shiftAmount)
            {
                if (count < shiftAmount)
                {
                    shiftAmount = count;
                }

                ulong carry = 0;
                for (int i = 0; i < bufLen; i++)
                {
                    ulong val = ((ulong)buffer[i]) << shiftAmount;
                    val |= carry;

                    buffer[i] = (DType)(val & DigitsArray.AllBits);
                    carry = (val >> DigitsArray.DataSizeBits);
                }

                if (carry != 0)
                {
                    if (bufLen + 1 <= buffer.Length)
                    {
                        buffer[bufLen] = (DType)carry;
                        bufLen++;
                        carry = 0;
                    }
                    else
                    {
                        throw new OverflowException();
                    }
                }
            }
            return bufLen;
        }

        internal int ShiftLeftWithoutOverflow(int shiftCount)
        {
            List<DType> temporary = new List<DType>(m_data);
            int shiftAmount = DigitsArray.DataSizeBits;

            for (int count = shiftCount; count > 0; count -= shiftAmount)
            {
                if (count < shiftAmount)
                {
                    shiftAmount = count;
                }

                ulong carry = 0;
                for (int i = 0; i < temporary.Count; i++)
                {
                    ulong val = ((ulong)temporary[i]) << shiftAmount;
                    val |= carry;

                    temporary[i] = (DType)(val & DigitsArray.AllBits);
                    carry = (val >> DigitsArray.DataSizeBits);
                }

                if (carry != 0)
                {
                    temporary.Add(0);
                    temporary[temporary.Count - 1] = (DType)carry;
                }
            }
            m_data = new DType[temporary.Count];
            temporary.CopyTo(m_data);
            return m_data.Length;
        }
    }
    #endregion
}
