using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ImproveIntelInstrincs.IntrincItem.E_Extention; // Makes collection declearation less verbose


namespace ImproveIntelInstrincs
{
    public partial class MainPage : Form
    {
        private void ExtentionCheckboxChanged(object sender, EventArgs e)
        {
            var thisCheckbox = sender as CheckBox;

            IncludedExtentionsCheckSetRange([thisCheckbox]);

            UpdateIntrinsicsList();
        }

        private IEnumerable<CheckBox> GetSSECheckBoxes()
        {
            return [
                SSE_box,
                SSE2_box,
                SSE3_box,
                SSSE3_box,
                SSE4_1_box,
                SSE4_2_box
            ];
        }

        private IEnumerable<CheckBox> GetAVXCheckBoxes() 
        {
            return [
                AVX_box,
                F16C_box,
                FMA_box,
                AVX2_box,
                AVX_VNNI_box,
                AVX_VNNI_INT8_box,
                AVX_VNNI_INT16_box,
                AVX_NE_CONVERT_box,
                AVX_IFMA_box,
                SHA512_box,
                SM3_box,
                SM4_box
            ];
        }

        private IEnumerable<CheckBox> GetAVX512CheckBoxes()
        {
            return [
                AVX512F_box,
                AVX512BW_box,
                AVX512CD_box,
                AVX512DQ_box,
                AVX512IFMA52_box,
                AVX512VL_box,
                AVX512VPOPCNTDQ_box,
                AVX512BF16_box,
                AVX512BITALG_box,
                AVX512VBMI_box,
                AVX512VBMI2_box,
                AVX512VNNI_box,
                AVX512VP2INTERSECT_box,
                AVX512FP16_box
            ];
        }

        private IEnumerable<CheckBox> GetAMXCheckBoxes()
        {
            return [
                AMX_BF16_box,
                AMX_INT8_box,
                AMX_TILE_box,
                AMX_FP16_box,
                AMX_COMPLEX_box
            ];
        }




        private void IncludedExtentionsCheckSetRange(IEnumerable<CheckBox> checkBoxesThatChanged)
        {

            foreach (var checkBox in checkBoxesThatChanged)
            {
                var checkBoxEnum = GetExtenionEnumFromStr(checkBox.Text);


                if (checkBox.Checked)
                {
                    _searchInclusions.extentionInclusionsSet.Add(checkBoxEnum);
                }
                else
                {
                    _searchInclusions.extentionInclusionsSet.Remove(checkBoxEnum);
                }
            }

            _searchInclusions.UpdateExtentionFilterFromSet();
        }

        private void SetRangeCheckBoxState(IEnumerable<CheckBox> checkBoxes, bool stateToSetAs, EventHandler boxChangeEvent)
        {
            
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.CheckedChanged -= boxChangeEvent;
                checkBox.Checked = stateToSetAs;
                checkBox.CheckedChanged += boxChangeEvent;
            }
            
        }

        private static void HideFamilySubmenuIfOutOfBounds(TableLayoutPanel familyContainer, CheckBox familyCheckbox)
        {
            // Only minimize family menu if leave both sub-menu and the checkbox that opened it
            Point containerPoint = familyContainer.PointToScreen(Point.Empty);
            Point checkboxPoint = familyCheckbox.PointToScreen(Point.Empty);

            Rectangle familyBounds = new Rectangle(
                x:      checkboxPoint.X,
                y:      checkboxPoint.Y,
                width:  familyCheckbox.Width,
                height: Math.Abs(checkboxPoint.Y - containerPoint.Y) + familyContainer.Height
            );


            if (familyBounds.Contains(Cursor.Position)) return;

            familyContainer.Visible = false;
        }

        private void ChangedALLFamilyCheckbox(object sender, EventArgs e)
        {
            var thisCheckbox = sender as CheckBox;

            //FuncShowCheckboxFamily showFamilyFunc;

            // TODO: Map the checkbox to the correct family show and `getCheckboxes` functions
            SSE_family_items.Visible = true;
            //SSE_family_show(sender, e);

            var sseCheckBoxes = GetSSECheckBoxes();
            SetRangeCheckBoxState(sseCheckBoxes, SSE_ALL_box.Checked, boxChangeEvent: ExtentionCheckboxChanged);
            IncludedExtentionsCheckSetRange(sseCheckBoxes);


            UpdateIntrinsicsList();
        }

        private void SSE_SubmenuMouseLeave(object sender, EventArgs e) { HideFamilySubmenuIfOutOfBounds(SSE_family_items, SSE_ALL_box); }
        private void AVX_SubmenuMouseLeave(object sender, EventArgs e) { HideFamilySubmenuIfOutOfBounds(AVX_family_items, AVX_ALL_box); }
        private void AVX512_SubmenuMouseLeave(object sender, EventArgs e) { HideFamilySubmenuIfOutOfBounds(AVX512_family_items, AVX512_ALL_box); }
        private void AMX_SubmenuMouseLeave(object sender, EventArgs e) { HideFamilySubmenuIfOutOfBounds(AMX_family_items, AMX_ALL_box); }


        private void SSE_ALL_box_CheckedChanged(object sender, EventArgs e)
        {
            SSE_family_show(sender, e);

            var sseCheckBoxes = GetSSECheckBoxes();
            SetRangeCheckBoxState(sseCheckBoxes, SSE_ALL_box.Checked, boxChangeEvent: ExtentionCheckboxChanged);
            IncludedExtentionsCheckSetRange(sseCheckBoxes);


            UpdateIntrinsicsList();
        }

        private void SSE_family_toggleVis(object sender, EventArgs e) {  SSE_family_items.Visible = !SSE_family_items.Visible;  }
        private void SSE_family_show(object sender, EventArgs e) {  SSE_family_items.Visible = true;  }



        private void AVX_ALL_box_CheckedChanged(object sender, EventArgs e)
        {
            AVX_family_show(sender, e);

            var AVXCheckBoxes = GetAVXCheckBoxes();
            SetRangeCheckBoxState(AVXCheckBoxes, AVX_ALL_box.Checked, ExtentionCheckboxChanged);
            IncludedExtentionsCheckSetRange(AVXCheckBoxes);

            UpdateIntrinsicsList();
        }

        private void AVX_family_toggleVis(object sender, EventArgs e) {  AVX_family_items.Visible = !AVX_family_items.Visible;  }
        private void AVX_family_show(object sender, EventArgs e) {  AVX_family_items.Visible = true;  }



        private void AVX512_ALL_box_CheckedChanged(object sender, EventArgs e)
        {
            AVX512_family_show(sender, e);

            var AVX512CheckBoxes = GetAVX512CheckBoxes();
            SetRangeCheckBoxState(AVX512CheckBoxes, AVX512_ALL_box.Checked, ExtentionCheckboxChanged);
            IncludedExtentionsCheckSetRange(AVX512CheckBoxes);

            UpdateIntrinsicsList();
        }

        private void AVX512_family_toggleVis(object sender, EventArgs e) {  AVX512_family_items.Visible = !AVX512_family_items.Visible;  }
        private void AVX512_family_show(object sender, EventArgs e) {  AVX512_family_items.Visible = true;  }


        private void AMX_family_toggleVis(object sender, EventArgs e) { AMX_family_items.Visible = !AMX_family_items.Visible; }
        private void AMX_family_show(object sender, EventArgs e) { AMX_family_items.Visible = true; }

        private void AMX_ALL_box_CheckedChanged(object sender, EventArgs e)
        {
            AMX_family_show(sender, e);

            var AMXCheckBoxes = GetAMXCheckBoxes();
            SetRangeCheckBoxState(AMXCheckBoxes, AMX_ALL_box.Checked, ExtentionCheckboxChanged);
            IncludedExtentionsCheckSetRange(AMXCheckBoxes);

            UpdateIntrinsicsList();
        }

        private void Other_ALL_box_CheckedChanged(object sender, EventArgs e) 
        {
            HashSet<IntrincItem.E_Extention> OtherExtentionsEnum = 
            [
                ADX, AES, BMI1, BMI2, CET_SS, CLDEMOTE, CLFLUSHOPT, CLWB, CMPCCXADD, CRC32, ENQCM, FSGSBASE, FXSR, GFNI,
                HRESET, INVPCID, KEYLOCKER, KEYLOCKER_WIDE, LZCNT, MONITOR, MOVBE, MOVDIR64B, MOVDIRI, MPX, PCLMULQDQ,
                PCONFIG, POPCNT, PREFETCHI, PRFCHW, RAO_INT, RDPID, RDSEED, RDTSCP, RTM, SERIALIZE, SHA, TSC, TSXLDTRK,
                UINTR, USER_MSR, VAES, VPCLMULQDQ, WAITPKG, XSAVE, XSAVEC, XSAVEOPT, XSS
            ];


            if (Other_box.Checked)
            {
                _searchInclusions.extentionInclusionsSet.UnionWith(OtherExtentionsEnum);
            }
            else 
            {
                _searchInclusions.extentionInclusionsSet.ExceptWith(OtherExtentionsEnum);
            }

            _searchInclusions.UpdateExtentionFilterFromSet();
            UpdateIntrinsicsList();
        }
    }
}