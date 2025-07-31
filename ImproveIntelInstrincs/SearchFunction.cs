using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace ImproveIntelInstrincs
{
    public partial class MainPage : Form
    {
        private CancellationTokenSource _searchCts;

        private void UpdateIntrinsicsList()
        {
            // Cancel any ongoing filters/DGV updates and declare a new one
            _searchCts?.Cancel();
            _searchCts = new CancellationTokenSource();
            CancellationToken cancelSearchToken = _searchCts.Token;


            string searchText = searchBox.Text.ToLower();


            StringBuilder dgvSourceFilters = new StringBuilder(64*3);

            dgvSourceFilters.AppendFormat(
                _searchInclusions.GetTextCategoriesStringBuilder(),
                searchText
            );

            string sizesToInclude = _searchInclusions.GetVecSizeInclusions();
            string typesToInclude = _searchInclusions.GetVecTypeInclusions();
            string masksToInclude = _searchInclusions.GetMaskInclusions();
            string extentionsToInclude = _searchInclusions.GetExtentionInclusions();

            dgvSourceFilters.AppendFormat(
                " AND ({0}) AND ({1}) AND ({2}) AND ({3})", 
                extentionsToInclude, masksToInclude, sizesToInclude, typesToInclude);


            // Update the DGV on another thread to prevent UI pause during search
            Task.Run(() => ApplyDataSourceFilterWithCancel(dgvSourceFilters.ToString(), cancelSearchToken));
        }

        private async void ApplyDataSourceFilterWithCancel(string dgvSourceFilters, CancellationToken cancelToken)
        {
            try
            {
                // Respect cancellation if another search has started
                cancelToken.ThrowIfCancellationRequested();

                if (searchHasSmallDelay.Checked) await Task.Delay(200, _searchCts.Token);

                this.Invoke((MethodInvoker)(() =>
                {
                    try
                    {
                        intrinsicBindingSource.Filter = dgvSourceFilters;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Filter error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        intrinsicBindingSource.Filter = null; // Clear filter on error
                        searchBox.Text = "";
                    }
                }));
            }
            catch (OperationCanceledException)
            {
                // Another search was started, cancel current
            }
        }




        private void searchBox_SuppressEnterSound(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            e.Handled = true; // Suppress the error sound
        }

        private void searchBoxChanged(object sender, EventArgs e)
        {
            searchPlaceHolder.Visible = (searchBox.Text == "");

            _searchInclusions.SetTextCategoriesStringBuilderUsingMenuItems(
                GetMenuItemToTextCategoryDict()
            );

            UpdateIntrinsicsList();
        }

    }
}
