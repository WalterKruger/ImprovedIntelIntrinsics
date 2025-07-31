using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImproveIntelInstrincs
{
    public partial class MainPage : Form
    {
        readonly static private HashSet<IntrincItem.E_MASKED> DEFAUL_MASKS = [ IntrincItem.E_MASKED.UNKNOWN_MASK, IntrincItem.E_MASKED.NO_MASK ];


        private class BindingSourceFilters
        {
            private string textCategoriesStringBuilder { get; set; }
            private string maskInclusions { get; set; }
            private string vectorSizeInclusions { get; set; }
            private string vectorTypeInclusions { get; set; }

            // Since there is so many extentions, a hashset allows to only set one
            private string extentionInclusionsFilter { get; set; }
            public HashSet<IntrincItem.E_Extention> extentionInclusionsSet { get; set; }

            public BindingSourceFilters()
            {
                extentionInclusionsFilter = "true";
                extentionInclusionsSet = [];

                textCategoriesStringBuilder = "true";
                vectorSizeInclusions = "true";
                vectorTypeInclusions = "true";

                maskInclusions = "true"; // Prevent warnings
                SetMaskInclusions(DEFAUL_MASKS);
            }

            public void UpdateExtentionFilterFromSet()
            {
                var selectedExtentionsIntList = extentionInclusionsSet.Select(e => (int)e).ToList();

                extentionInclusionsFilter = (extentionInclusionsSet.Count == 0)
                    ? "true" // Inlude all 
                    : $"Extention IN ({string.Join(",", selectedExtentionsIntList)})";
            }

            public void SetMaskInclusions(HashSet<IntrincItem.E_MASKED> includedMasks)
            {
                maskInclusions = (includedMasks.Count == 0)
                    ? "true"
                    : $"MaskedType IN ({string.Join(",", includedMasks.Select(i => (int)i).ToList())})";
            }

            public void SetVecSizesInclusions(HashSet<IntrincItem.E_VECTORSIZE> includedSizes)
            {
                vectorSizeInclusions = (includedSizes.Count == 0)
                    ? "true"
                    : $"VectorSize IN ({string.Join(",", includedSizes.Select(i => (int)i).ToList())})";
            }

            public void SetVecTypeInclusions(HashSet<IntrincItem.E_ELEMENTTYPE> includedTypes)
            {
                vectorTypeInclusions = (includedTypes.Count == 0)
                    ? "true"
                    : $"ElementType IN ({string.Join(",", includedTypes.Select(i => (int)i).ToList())})";
            }


            public void SetTextCategoriesStringBuilderUsingMenuItems(Dictionary<ToolStripMenuItem, string> menuOptionToCategory) 
            {
                textCategoriesStringBuilder = "(false"; // Makes constructing easier

                foreach (var menuOption in menuOptionToCategory)
                {
                    if (!menuOption.Key.Checked) continue;

                    textCategoriesStringBuilder += $" OR {menuOption.Value} LIKE '%{"{0}"}%'";
                }

                textCategoriesStringBuilder += ")";
            }


            public string GetExtentionInclusions()  { return extentionInclusionsFilter; }
            public string GetMaskInclusions()       { return maskInclusions; }
            public string GetVecSizeInclusions()    { return vectorSizeInclusions; }
            public string GetVecTypeInclusions()    { return vectorTypeInclusions; }
            public string GetTextCategoriesStringBuilder() { return textCategoriesStringBuilder; }

        }






        private HashSet<IntrincItem.E_MASKED> GetSelectedMasksBasedOnMenu()
        {
            return (searchIncludeMask.Checked)
                ? [] // Nothing acts like no exclusions
                : DEFAUL_MASKS;
        }

        private HashSet<IntrincItem.E_VECTORSIZE> GetSelectedSizesBasedOnMenu() 
        {
            Dictionary<ToolStripMenuItem, IntrincItem.E_VECTORSIZE> menuSizesToSearchEnum = new()
            {
                { searchSizeNonvec, IntrincItem.E_VECTORSIZE.NONVECSIZE },
                { searchSize64,  IntrincItem.E_VECTORSIZE.VEC64},
                { searchSize128, IntrincItem.E_VECTORSIZE.VEC128 },
                { searchSize256, IntrincItem.E_VECTORSIZE.VEC256 },
                { searchSize512, IntrincItem.E_VECTORSIZE.VEC512 },
                { searchSizeTile, IntrincItem.E_VECTORSIZE.VECTILE },
            };


            HashSet<IntrincItem.E_VECTORSIZE> includedVectorSizes = [];

            foreach (var sizeMenu in menuSizesToSearchEnum)
            {
                if (sizeMenu.Key.Checked) includedVectorSizes.Add(sizeMenu.Value);
            }

            return includedVectorSizes;
        }

        private HashSet<IntrincItem.E_ELEMENTTYPE> GetSelectedTypesBasedOnMenu()
        {
            Dictionary<ToolStripMenuItem, IntrincItem.E_ELEMENTTYPE> menuTypesToSearchEnum = new()
            {
                { searchTypeNonVec, IntrincItem.E_ELEMENTTYPE.NONVEC },

                { searchTypeInt8,   IntrincItem.E_ELEMENTTYPE.I8 },
                { searchTypeInt16,  IntrincItem.E_ELEMENTTYPE.I16 },
                { searchTypeInt32,  IntrincItem.E_ELEMENTTYPE.I32 },
                { searchTypeInt64,  IntrincItem.E_ELEMENTTYPE.I64 },
                { searchTypeInt128, IntrincItem.E_ELEMENTTYPE.I128 },

                { searchTypeUnsigned8,   IntrincItem.E_ELEMENTTYPE.U8 },
                { searchTypeUnsigned16,  IntrincItem.E_ELEMENTTYPE.U16 },
                { searchTypeUnsigned32,  IntrincItem.E_ELEMENTTYPE.U32 },
                { searchTypeUnsigned64,  IntrincItem.E_ELEMENTTYPE.U64 },

                { searchTypeFloat16,    IntrincItem.E_ELEMENTTYPE.F16 },
                { searchTypeBFloat16,   IntrincItem.E_ELEMENTTYPE.BF16 },
                { searchTypeFloat32,    IntrincItem.E_ELEMENTTYPE.F32 },
                { searchTypeFloat64,    IntrincItem.E_ELEMENTTYPE.F64 },
            };


            HashSet<IntrincItem.E_ELEMENTTYPE> includedTypes = [];

            foreach (var typeMenu in menuTypesToSearchEnum)
            {
                if (typeMenu.Key.Checked) includedTypes.Add(typeMenu.Value);
            }

            return includedTypes;
        }


        private Dictionary<ToolStripMenuItem, string> GetMenuItemToTextCategoryDict() 
        {
            return new()
            {
                { searchIncludeDescription, "Description" },
                { searchIncludeFuncName, "IntrincName" },
                { searchIncludeInstruction, "Instruction" },
                { searchIncludeReturnType, "ReturnType" },
                //{ searchIncludeArgType, "Arguments" }
            };
        }
    }
}
