using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImproveIntelInstrincs
{
    public partial class MainPage : Form
    {

        private List<IntrincItem> intrincData;

        private readonly BindingSourceFilters _searchInclusions = new BindingSourceFilters();

        private DataTable intrinsicDataTable;
        private BindingSource intrinsicBindingSource;


        public MainPage()
        {
            InitializeComponent();

            intrincData = GetIntrincsAsAList();
            intrinsicDataTable = ConvertClassListToDataTable(intrincData);

            // Set up BindingSource
            intrinsicBindingSource = new BindingSource
            {
                DataSource = intrinsicDataTable
            };

            // Bind to DataGridView
            IntrinsicsList.DataSource = intrinsicBindingSource;

        }

        private static IntrincItem.E_Extention GetExtenionEnumFromStr(string extentionString)
        {
            return extentionString switch
            {

                "MMX" => IntrincItem.E_Extention.MMX,

                "SSE" => IntrincItem.E_Extention.SSE,
                "SSE2" => IntrincItem.E_Extention.SSE2,
                "SSE3" => IntrincItem.E_Extention.SSE3,
                "SSSE3" => IntrincItem.E_Extention.SSSE3,
                "SSE4.1" => IntrincItem.E_Extention.SSE4_1,
                "SSE4.2" => IntrincItem.E_Extention.SSE4_2,

                // AVX
                "AVX" => IntrincItem.E_Extention.AVX,
                "F16C" => IntrincItem.E_Extention.F16C,
                "FMA" => IntrincItem.E_Extention.FMA,
                "AVX2" => IntrincItem.E_Extention.AVX2,
                "AVX_VNNI" => IntrincItem.E_Extention.AVX_VNNI,
                "AVX_VNNI_INT8" => IntrincItem.E_Extention.AVX_VNNI_INT8,
                "AVX_VNNI_INT16" => IntrincItem.E_Extention.AVX_VNNI_INT16,
                "AVX_NE_CONVERT" => IntrincItem.E_Extention.AVX_NE_CONVERT,
                "AVX_IFMA" => IntrincItem.E_Extention.AVX_IFMA,
                "SHA512" => IntrincItem.E_Extention.SHA512,
                "SM3" => IntrincItem.E_Extention.SM3,
                "SM4" => IntrincItem.E_Extention.SM4,

                // AVX512
                "AVX512F" => IntrincItem.E_Extention.AVX512F,
                "AVX512BW" => IntrincItem.E_Extention.AVX512BW,
                "AVX512CD" => IntrincItem.E_Extention.AVX512CD,
                "AVX512DQ" => IntrincItem.E_Extention.AVX512DQ,
                "AVX512IFMA52" => IntrincItem.E_Extention.AVX512IFMA52,
                "AVX512VL" => IntrincItem.E_Extention.AVX512VL,
                "AVX512VPOPCNTDQ" => IntrincItem.E_Extention.AVX512VPOPCNTDQ,
                // For some reason, these have a '_' in the name...
                "AVX512_BF16" => IntrincItem.E_Extention.AVX512BF16,
                "AVX512_BITALG" => IntrincItem.E_Extention.AVX512BITALG,
                "AVX512_VBMI" => IntrincItem.E_Extention.AVX512VBMI,
                "AVX512_VBMI2" => IntrincItem.E_Extention.AVX512VBMI2,
                "AVX512_VNNI" => IntrincItem.E_Extention.AVX512VNNI,
                "AVX512_VP2INTERSECT" => IntrincItem.E_Extention.AVX512VP2INTERSECT,
                "AVX512_FP16" => IntrincItem.E_Extention.AVX512FP16,

                // AMX
                "AMX-BF16" => IntrincItem.E_Extention.AMX_BF16,
                "AMX-COMPLEX" => IntrincItem.E_Extention.AMX_COMPLEX,
                "AMX-FP16" => IntrincItem.E_Extention.AMX_FP16,
                "AMX-INT8" => IntrincItem.E_Extention.AMX_INT8,
                "AMX-TILE" => IntrincItem.E_Extention.AMX_TILE,

                "ADX" => IntrincItem.E_Extention.ADX,
                "AES" => IntrincItem.E_Extention.AES,
                "BMI1" => IntrincItem.E_Extention.BMI1,
                "BMI2" => IntrincItem.E_Extention.BMI2,
                "CET_SS" => IntrincItem.E_Extention.CET_SS,
                "CLDEMOTE" => IntrincItem.E_Extention.CLDEMOTE,
                "CLFLUSHOPT" => IntrincItem.E_Extention.CLFLUSHOPT,
                "CLWB" => IntrincItem.E_Extention.CLWB,
                "CMPCCXADD" => IntrincItem.E_Extention.CMPCCXADD,
                "CRC32" => IntrincItem.E_Extention.CRC32,
                "ENQCM" => IntrincItem.E_Extention.ENQCM,
                "FSGSBASE" => IntrincItem.E_Extention.FSGSBASE,
                "FXSR" => IntrincItem.E_Extention.FXSR,
                "GFNI" => IntrincItem.E_Extention.GFNI,
                "HRESET" => IntrincItem.E_Extention.HRESET,
                "INVPCID" => IntrincItem.E_Extention.INVPCID,
                "KEYLOCKER" => IntrincItem.E_Extention.KEYLOCKER,
                "KEYLOCKER_WIDE" => IntrincItem.E_Extention.KEYLOCKER_WIDE,
                "LZCNT" => IntrincItem.E_Extention.LZCNT,
                "MONITOR" => IntrincItem.E_Extention.MONITOR,
                "MOVEBE" => IntrincItem.E_Extention.MOVBE,
                "MOVDIR64B" => IntrincItem.E_Extention.MOVDIR64B,
                "MOVDIRI" => IntrincItem.E_Extention.MOVDIRI,
                "MPX" => IntrincItem.E_Extention.MPX,
                "PCLMULQDQ" => IntrincItem.E_Extention.PCLMULQDQ,
                "PCONFIG" => IntrincItem.E_Extention.PCONFIG,
                "POPCNT" => IntrincItem.E_Extention.POPCNT,
                "PREFETCHI" => IntrincItem.E_Extention.PREFETCHI,
                "PRFCHW" => IntrincItem.E_Extention.PRFCHW,
                "RAO_INT" => IntrincItem.E_Extention.RAO_INT,
                "RDPID" => IntrincItem.E_Extention.RDPID,
                "RDRAND" => IntrincItem.E_Extention.RDRAND,
                "RDSEED" => IntrincItem.E_Extention.RDSEED,
                "RDTSCP" => IntrincItem.E_Extention.RDTSCP,
                "RTM" => IntrincItem.E_Extention.RTM,
                "SERIALIZE" => IntrincItem.E_Extention.SERIALIZE,
                "SHA" => IntrincItem.E_Extention.SHA,
                "TSC" => IntrincItem.E_Extention.TSC,
                "TSXLDTRK" => IntrincItem.E_Extention.TSXLDTRK,
                "UINTR" => IntrincItem.E_Extention.UINTR,
                "USER_MSR" => IntrincItem.E_Extention.USER_MSR,
                "VAES" => IntrincItem.E_Extention.VAES,
                "VPCLMULQDQ" => IntrincItem.E_Extention.VPCLMULQDQ,
                "WAITPKG" => IntrincItem.E_Extention.WAITPKG,
                "WBNOINVD" => IntrincItem.E_Extention.WBNOINVD,
                "XSAVE" => IntrincItem.E_Extention.XSAVE,
                "XSAVEC" => IntrincItem.E_Extention.XSAVEC,
                "XSAVEOPT" => IntrincItem.E_Extention.XSAVEOPT,
                "XSS" => IntrincItem.E_Extention.XSS,


                _ => IntrincItem.E_Extention.UNKNOWN,
            };
        }

        private static IntrincItem.E_MASKED GetMaskedStatusFromName(XElement intrinsic)
        {
            string intrinsicName = intrinsic.Attribute("name")?.Value ?? "";

            // Filter out all without a mask
            bool hasMaskInput = intrinsic
                .Elements("parameter")
                .Any(
                    args => args.Attribute("type").Value.StartsWith("__mmask")
            );

            if (!hasMaskInput) return IntrincItem.E_MASKED.NO_MASK;


            // All zeroing intrinsics use the same prefix
            if (intrinsicName.Contains("_maskz_")) return IntrincItem.E_MASKED.ZERO_MASK;


            // Allow intrinsics that only work with a mask
            string[] allowedMaskedThatContain = { "_blend_", "_compress", "_expand", "_mov_" };

            foreach (string allowedMasked in allowedMaskedThatContain)
            {
                if (intrinsicName.Contains(allowedMasked)) return IntrincItem.E_MASKED.NO_MASK;
            }

            // Merge mask intrinsics

            string[] mergeMaskPrefixes = { "_mask_", "_mask2_", "_mask3_", "_mmask_" };
            foreach (string mergeMaskPrefix in mergeMaskPrefixes)
            {
                if (intrinsicName.Contains(mergeMaskPrefix)) return IntrincItem.E_MASKED.MERGE_MASK;
            }


            return IntrincItem.E_MASKED.UNKNOWN_MASK;
        }


        private static string TruncateStringIfAbove(string x, Int32 length)
        {
            return x[..Math.Min(x.Length, length)];
        }

        private static IntrincItem.E_VECTORSIZE GetVectorsizeEnum(XElement intrinsic)
        {
            string intrinsicName = intrinsic.Attribute("name")?.Value ?? "";
            int TYPE_DIGIT_LENGTH = "__m128".Length;

            HashSet<string> asmArgs = new();

            foreach (XElement parameter in intrinsic.Elements("parameter"))
            {
                asmArgs.Add(TruncateStringIfAbove(parameter.Attribute("type").Value, TYPE_DIGIT_LENGTH));
            }
            // Return type
            asmArgs.Add(TruncateStringIfAbove(intrinsic.Element("return").Attribute("type").Value, TYPE_DIGIT_LENGTH));



            // All tile intrinsics have this prefix
            // Doesn't work with others as MMX uses the same prefix as SSE (but args "pi" vs "epi")
            if (intrinsicName.Contains("_tile_")) return IntrincItem.E_VECTORSIZE.VECTILE;


            // Some instructions use both, so prioritise the largest first
            Dictionary<string, IntrincItem.E_VECTORSIZE> asmRegToEnum = new()
            {
                { "__m512",  IntrincItem.E_VECTORSIZE.VEC512 },
                { "__m256",  IntrincItem.E_VECTORSIZE.VEC256 },
                { "__m128",  IntrincItem.E_VECTORSIZE.VEC128 },
                { "__m64",    IntrincItem.E_VECTORSIZE.VEC64 }
            };

            foreach (var regToEnum in asmRegToEnum)
            {
                if (asmArgs.Contains(regToEnum.Key)) return regToEnum.Value;
            }

            // No vector arguments?
            // Maybe some only use a memory operand... but then false positives like "fxrstor m512"
            return IntrincItem.E_VECTORSIZE.NONVECSIZE;
        }

        private static IntrincItem.E_ELEMENTTYPE GetEnumFromStrTypeSuffix(string typeSuffix)
        {
            return typeSuffix switch
            {
                "pbh" or "sbh" => IntrincItem.E_ELEMENTTYPE.BF16,
                "ph" or "sh" or "pch" or "sch" => IntrincItem.E_ELEMENTTYPE.F16,
                "ps" or "ss" => IntrincItem.E_ELEMENTTYPE.F32,
                "pd" or "sd" => IntrincItem.E_ELEMENTTYPE.F64,


                "epi8" or "pi8" => IntrincItem.E_ELEMENTTYPE.I8,
                "epu8" or "pu8" => IntrincItem.E_ELEMENTTYPE.U8,
                "epi16" or "pi16" => IntrincItem.E_ELEMENTTYPE.I16,
                "epu16" or "pu16" => IntrincItem.E_ELEMENTTYPE.U16,
                "epi32" or "pi32" => IntrincItem.E_ELEMENTTYPE.I32,
                "epu32" or "pu32" => IntrincItem.E_ELEMENTTYPE.U32,
                "epi64" or "pi64" => IntrincItem.E_ELEMENTTYPE.I64,
                "epu64" or "pu64" => IntrincItem.E_ELEMENTTYPE.U64,

                "epi128" => IntrincItem.E_ELEMENTTYPE.I128,

                _ => IntrincItem.E_ELEMENTTYPE.UNKNOWN,
            };
        }

        private static IntrincItem.E_ELEMENTTYPE GetElementTypeEnum(XElement intrinsic, Regex regexTypeSuffix)
        {

            string intrinsicName = intrinsic.Attribute("name")?.Value ?? "";

            // Some AVX-512 intrinsics have a mask suffix to indicate they either return a mask
            // or the operation only functions with one
            if (intrinsicName.EndsWith("_mask"))
                intrinsicName = intrinsicName[..(intrinsicName.Length - "_mask".Length)];


            Match regexSuffixMatch = regexTypeSuffix.Match(intrinsicName);

            // All SIMD functions have a type suffix
            if (!regexSuffixMatch.Success) return IntrincItem.E_ELEMENTTYPE.NONVEC;


            string firstTypeSuffix = regexSuffixMatch.Value;


            // Some have two types, like the ones that convert from one type to another, and we want to input type
            // E.g. `_mm_cvtps_epi32`: Take a packed single and convert it to a signed 32-bit integer
            string noFirstSuffix = intrinsicName[..(intrinsicName.Length - $"_{firstTypeSuffix}".Length)];

            Match regexSecondMatch = regexTypeSuffix.Match(noFirstSuffix);

            // No second type
            if (!regexSecondMatch.Success) return GetEnumFromStrTypeSuffix(firstTypeSuffix);

            return GetEnumFromStrTypeSuffix(regexSecondMatch.Value);
        }


        private static List<IntrincItem> GetIntrincsAsAList(string? filePath = null)
        {
            filePath ??= Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.js");

            try
            {
                string dataFileRaw = File.ReadAllText(filePath);
                string dataFileClean = CleanDataFile(dataFileRaw);


                var dataParse = XDocument.Parse(dataFileClean);

                var intrincItems = new List<IntrincItem>();

                var elementsToIterateThrough = dataParse
                    .Descendants("intrinsic")
                    .Where(x => x.Attribute("tech")?.Value != "SVML");


                // Create the regex here, so it doesn't need to be recompiled in a loop
                const string regex_fltSuffix = "[ps]([dsh]|ch|bh)";
                const string regex_intSuffix = "e?p[iu](8|16|32|64|128)";

                Regex regexTypeSuffix = new(pattern: $"(({regex_fltSuffix})|({regex_intSuffix}))$", options: RegexOptions.Compiled);


                foreach (var intrinc in elementsToIterateThrough)
                {
                    if (intrinc == null) continue;

                    var tag = new IntrincItem
                    {
                        IntrincName = intrinc.Attribute("name")?.Value ?? "ERROR NOT FOUND",
                        Instruction = intrinc.Element("instruction")?.Attribute("name")?.Value ?? "",
                        Description = intrinc.Element("description")?.Value ?? "",
                        Pseudocode = intrinc.Element("operation")?.Value ?? "",
                        ReturnType = intrinc.Element("return")?.Attribute("type")?.Value ?? "",
                        // ==========================
                        // TODO: Some AVX512 instructions have two extentions at once...
                        // ==========================
                        Extention = GetExtenionEnumFromStr(intrinc.Element("CPUID")?.Value ?? ""),
                        MaskedType = GetMaskedStatusFromName(intrinc),
                        VectorSize = GetVectorsizeEnum(intrinc),
                        ElementType = GetElementTypeEnum(intrinc, regexTypeSuffix),

                        Arguments = intrinc.Elements("parameter").Select(arg => new Argument
                        {
                            Type = arg.Attribute("type")?.Value ?? "",
                            Name = arg.Attribute("varname")?.Value ?? ""
                        }).ToList()
                    };
                    intrincItems.Add(tag);
                }

                return intrincItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
                return new List<IntrincItem>();
            }
        }


        private static string CleanDataFile(string rawContent)
        {
            string noEscapeChar = rawContent
                .Replace("\\n\\", "")   // Remove new line characters at end of each line
                .Replace("\\\"", "\""); // Unescape quotes

            // Remove up until `var data_js = " & character at the end
            string lineStartClean = noEscapeChar.Substring(rawContent.IndexOf("\"") + 1);
            string lineEndClean = lineStartClean.TrimEnd('"', ';', '\n');

            return "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + lineEndClean;
        }



        public static DataTable ConvertClassListToDataTable<T>(List<T> data)
        {
            DataTable table = new DataTable();

            var properties = typeof(T).GetProperties();

            // Create columns
            table.Columns.Add("TableIndex", typeof(int));

            foreach (var prop in properties)
            {
                Type propType = prop.PropertyType;
                if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    propType = Nullable.GetUnderlyingType(propType);
                }
                table.Columns.Add(prop.Name, propType);
            }

            // Add rows
            for (int i = 0; i < data.Count(); i++)
            {
                DataRow row = table.NewRow();
                row["TableIndex"] = i;

                foreach (var prop in properties)
                {
                    object value = prop.GetValue(data[i]) ?? DBNull.Value;
                    row[prop.Name] = value;
                }
                table.Rows.Add(row);
            }

            return table;
        }




        private void setNewDataFile(object sender, EventArgs e)
        {
            if (infoDialogMenuCheck.Checked)
            {
                MessageBox.Show(
                    "Expects a javascript file in which a variable is set to XML data containing the intrinsic data." +
                    "\n\nIt can be obtained by downloading the `Offline Intel® Intrinsics Guide` from intel.com"
                    ,
                    "Data file information"
                );
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set properties to filter specific file types
                openFileDialog.Filter = "Expected format|data.js|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Load the new data file
                    intrincData = GetIntrincsAsAList(filePath);
                    intrinsicDataTable = ConvertClassListToDataTable(intrincData);


                    intrinsicBindingSource.DataSource = intrinsicDataTable;
                }
            }
        }

        private void IntrinsicsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Ignore header clicks

            //var selectedIntrinsic = IntrinsicsList.Rows[e.RowIndex].DataBoundItem as IntrincItem;
            var DGV_dataRow = intrinsicBindingSource[e.RowIndex] as DataRowView;

            int intrinsicTableIndex = int.Parse(DGV_dataRow.Row["TableIndex"].ToString());

            // Open the intrinsic info window
            var dialog = new CreateIntrinsicInfoWindow(intrinsic: intrincData[intrinsicTableIndex]);
            dialog.ShowDialog();
        }

        private void SearchMenuChanged(object sender, EventArgs e)
        {
            // That menu controls both text categories and whether masked operations are included
            _searchInclusions.SetMaskInclusions(GetSelectedMasksBasedOnMenu());
            _searchInclusions.SetTextCategoriesStringBuilderUsingMenuItems(GetMenuItemToTextCategoryDict());

            UpdateIntrinsicsList();
        }

        private void SearchSizeChanged(object sender, EventArgs e)
        {

            _searchInclusions.SetVecSizesInclusions(GetSelectedSizesBasedOnMenu());

            UpdateIntrinsicsList();
        }

        private void SearchTypeChanged(object sender, EventArgs e)
        {
            elementTypesOptionsMenu.ShowDropDown();
            _searchInclusions.SetVecTypeInclusions(GetSelectedTypesBasedOnMenu());

            UpdateIntrinsicsList();
        }

        private void SearchTypeGroupToggle(object sender, EventArgs e)
        {
            var thisMenuGroup = (sender as ToolStripMenuItem);

            thisMenuGroup.CheckState = (thisMenuGroup.Checked) ? CheckState.Unchecked : CheckState.Indeterminate;

            foreach (var item in thisMenuGroup.DropDownItems)
            {
                var menuItem = item as ToolStripMenuItem;
                if (menuItem == null) continue;

                menuItem.CheckedChanged -= SearchTypeChanged;
                menuItem.Checked = thisMenuGroup.Checked;
                menuItem.CheckedChanged += SearchTypeChanged;
            }

            _searchInclusions.SetVecTypeInclusions(GetSelectedTypesBasedOnMenu());

            UpdateIntrinsicsList();
        }

    }


}
