using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ImproveIntelInstrincs
{
    public class Argument
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }

    // Class to store parsed data
    public class IntrincItem
    {
        public enum E_MASKED
        {
            UNKNOWN_MASK, NO_MASK, MERGE_MASK, ZERO_MASK,
        }

        public enum E_VECTORSIZE 
        {
            NONVECSIZE, VEC64, VEC128, VEC256, VEC512, VECTILE
        }

        public enum E_ELEMENTTYPE 
        {
            UNKNOWN, NONVEC,
            U8, I8, U16, I16, U32, I32, U64, I64, I128,
            F16, BF16, F32, F64
        }

        public enum E_Extention
        {
            UNKNOWN,

            MMX,
            SSE, SSE2, SSE3, SSSE3, SSE4_1, SSE4_2,

            AVX, F16C, FMA, AVX2, AVX_VNNI, AVX_VNNI_INT8, AVX_NE_CONVERT, AVX_IFMA, AVX_VNNI_INT16, SHA512, SM3, SM4,

            AVX512F, AVX512BW, AVX512CD, AVX512DQ, AVX512IFMA52, AVX512VL, AVX512VPOPCNTDQ, AVX512BF16,
            AVX512BITALG, AVX512VBMI, AVX512VBMI2, AVX512VNNI, AVX512VP2INTERSECT, AVX512FP16,

            AMX_BF16, AMX_COMPLEX, AMX_FP16, AMX_INT8, AMX_TILE,
            
            ADX, AES, BMI1, BMI2, CET_SS, CLDEMOTE, CLFLUSHOPT, CLWB, CMPCCXADD, CRC32, ENQCM, FSGSBASE, FXSR,
            GFNI, HRESET, INVPCID, KEYLOCKER, KEYLOCKER_WIDE, LZCNT, MONITOR, MOVBE, MOVDIR64B, MOVDIRI,
            MPX, PCLMULQDQ, PCONFIG, POPCNT, PREFETCHI, PRFCHW, RAO_INT, RDPID, RDRAND, RDSEED, RDTSCP,
            RTM, SERIALIZE, SHA, TSC, TSXLDTRK, UINTR, USER_MSR, VAES, VPCLMULQDQ, WAITPKG, WBNOINVD,
            XSAVE, XSAVEC, XSAVEOPT, XSS,

            Other,
        }

        //public int Id { get; set; }
        public string IntrincName { get; set; }
        public string Instruction { get; set; }

        public string ReturnType { get; set; }

        public string Description { get; set; }
        public string Pseudocode { get; set; }

        public E_Extention Extention { get; set; }
        public E_MASKED MaskedType { get; set; }
        public E_VECTORSIZE VectorSize { get; set; }
        public E_ELEMENTTYPE ElementType { get; set; }

        public IEnumerable<Argument> Arguments { get; set; }

        public string FuncSignature => $"{IntrincName} ({
                string.Join(", ", Arguments.Select(x => $"{x.Type} {x.Name}"))
            })";
    }
}
