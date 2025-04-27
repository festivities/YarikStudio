using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetStudio {
    public struct Double {
        public static double Frexp(double value, out int exponent) {
            if(value == 0.0) {
                exponent = 0;
                return 0.0;
            }

            long bits = BitConverter.DoubleToInt64Bits(value);
            long exp = (bits >> 52) & 0x7FFL;

            if(exp == 0) {
                value *= Math.Pow(2, 54);
                bits = BitConverter.DoubleToInt64Bits(value);
                exp = ((bits >> 52) & 0x7FFL) - 54;
            }

            exponent = (int)(exp - 1022);
            bits = (long)(((ulong)bits & 0x800FFFFFFFFFFFFFL) | 0x3FE0000000000000L);
            return BitConverter.Int64BitsToDouble(bits);
        }

        // https://github.com/MachineCognitis/C.math.NET
        public static double frexp(double number, out int exponent) {
            const long DBL_EXP_MASK = 0x7ff0000000000000L, DBL_MANT_BITS = 52, DBL_SGN_MASK = -1 - 0x7fffffffffffffffL, DBL_MANT_MASK = 0x000fffffffffffffL;
            const long DBL_EXP_CLR_MASK = DBL_SGN_MASK | DBL_MANT_MASK;

            long bits = System.BitConverter.DoubleToInt64Bits(number);
            int exp = (int)((bits & DBL_EXP_MASK) >> (int)DBL_MANT_BITS);
            exponent = 0;

            if(exp == 0x7ff || number == 0D)
                number += number;
            else {
                // Not zero and finite.
                exponent = exp - 1022;
                if(exp == 0) {
                    // Subnormal, scale number so that it is in [1, 2).
                    number *= System.BitConverter.Int64BitsToDouble(0x4350000000000000L); // 2^54
                    bits = System.BitConverter.DoubleToInt64Bits(number);
                    exp = (int)((bits & DBL_EXP_MASK) >> (int)DBL_MANT_BITS);
                    exponent = exp - 1022 - 54;
                }
                // Set exponent to -1 so that number is in [0.5, 1).
                number = System.BitConverter.Int64BitsToDouble((bits & DBL_EXP_CLR_MASK) | 0x3fe0000000000000L);
            }

            return number;
        }
    }
}
