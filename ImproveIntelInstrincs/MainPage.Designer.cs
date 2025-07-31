namespace ImproveIntelInstrincs
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            IntrinsicsList = new DataGridView();
            returnTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intrincNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            instructionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intrincItemBindingSource = new BindingSource(components);
            MMX_box = new CheckBox();
            AVX_box = new CheckBox();
            SSE_ALL_box = new CheckBox();
            SSE_family_items = new TableLayoutPanel();
            SSE4_2_box = new CheckBox();
            SSE4_1_box = new CheckBox();
            SSE_box = new CheckBox();
            SSE3_box = new CheckBox();
            SSSE3_box = new CheckBox();
            SSE2_box = new CheckBox();
            AMX_ALL_box = new CheckBox();
            AVX_ALL_box = new CheckBox();
            searchBox = new TextBox();
            searchPlaceHolder = new Label();
            extentionsPannel = new TableLayoutPanel();
            AVX512_family_items = new TableLayoutPanel();
            AVX512VL_box = new CheckBox();
            AVX512FP16_box = new CheckBox();
            AVX512VP2INTERSECT_box = new CheckBox();
            AVX512VNNI_box = new CheckBox();
            AVX512VBMI2_box = new CheckBox();
            AVX512VBMI_box = new CheckBox();
            AVX512BITALG_box = new CheckBox();
            AVX512BF16_box = new CheckBox();
            AVX512VPOPCNTDQ_box = new CheckBox();
            AVX512DQ_box = new CheckBox();
            AVX512CD_box = new CheckBox();
            AVX512BW_box = new CheckBox();
            AVX512F_box = new CheckBox();
            AVX512IFMA52_box = new CheckBox();
            UNKNOWN_box = new CheckBox();
            AMX_family_items = new TableLayoutPanel();
            AMX_COMPLEX_box = new CheckBox();
            AMX_FP16_box = new CheckBox();
            AMX_TILE_box = new CheckBox();
            AMX_INT8_box = new CheckBox();
            AMX_BF16_box = new CheckBox();
            AVX512_ALL_box = new CheckBox();
            AVX_family_items = new TableLayoutPanel();
            AVX_VNNI_INT16_box = new CheckBox();
            AVX_IFMA_box = new CheckBox();
            AVX_NE_CONVERT_box = new CheckBox();
            AVX_VNNI_INT8_box = new CheckBox();
            AVX_VNNI_box = new CheckBox();
            AVX2_box = new CheckBox();
            FMA_box = new CheckBox();
            F16C_box = new CheckBox();
            SM4_box = new CheckBox();
            SM3_box = new CheckBox();
            SHA512_box = new CheckBox();
            Other_box = new CheckBox();
            baseLayoutPannel = new TableLayoutPanel();
            searchBoxSubPannel = new Panel();
            toolStripMenuItem4 = new ToolStripMenuItem();
            fileMenu = new ToolStripMenuItem();
            browseForDataFile = new ToolStripMenuItem();
            infoDialogMenuCheck = new ToolStripMenuItem();
            optionsMenu = new ToolStripMenuItem();
            searchIncludeInstruction = new ToolStripMenuItem();
            searchIncludeFuncName = new ToolStripMenuItem();
            searchIncludeDescription = new ToolStripMenuItem();
            searchIncludeReturnType = new ToolStripMenuItem();
            searchIncludeArgType = new ToolStripMenuItem();
            searchIncludeMask = new ToolStripMenuItem();
            searchHasSmallDelay = new ToolStripMenuItem();
            sizeOptionsMenu = new ToolStripMenuItem();
            searchSizeNonvec = new ToolStripMenuItem();
            searchSize64 = new ToolStripMenuItem();
            searchSize128 = new ToolStripMenuItem();
            searchSize256 = new ToolStripMenuItem();
            searchSize512 = new ToolStripMenuItem();
            searchSizeTile = new ToolStripMenuItem();
            elementTypesOptionsMenu = new ToolStripMenuItem();
            searchTypeNonVec = new ToolStripMenuItem();
            searchType_GroupInt = new ToolStripMenuItem();
            searchTypeInt8 = new ToolStripMenuItem();
            searchTypeInt16 = new ToolStripMenuItem();
            searchTypeInt32 = new ToolStripMenuItem();
            searchTypeInt64 = new ToolStripMenuItem();
            searchTypeInt128 = new ToolStripMenuItem();
            searchType_GroupUnsigned = new ToolStripMenuItem();
            searchTypeUnsigned8 = new ToolStripMenuItem();
            searchTypeUnsigned16 = new ToolStripMenuItem();
            searchTypeUnsigned32 = new ToolStripMenuItem();
            searchTypeUnsigned64 = new ToolStripMenuItem();
            searchType_GroupFloat = new ToolStripMenuItem();
            searchTypeFloat16 = new ToolStripMenuItem();
            searchTypeBFloat16 = new ToolStripMenuItem();
            searchTypeFloat32 = new ToolStripMenuItem();
            searchTypeFloat64 = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            searchWinMenuStrip = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)IntrinsicsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intrincItemBindingSource).BeginInit();
            SSE_family_items.SuspendLayout();
            extentionsPannel.SuspendLayout();
            AVX512_family_items.SuspendLayout();
            AMX_family_items.SuspendLayout();
            AVX_family_items.SuspendLayout();
            baseLayoutPannel.SuspendLayout();
            searchBoxSubPannel.SuspendLayout();
            searchWinMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // IntrinsicsList
            // 
            IntrinsicsList.AllowUserToAddRows = false;
            IntrinsicsList.AllowUserToDeleteRows = false;
            IntrinsicsList.AllowUserToOrderColumns = true;
            IntrinsicsList.AllowUserToResizeRows = false;
            IntrinsicsList.AutoGenerateColumns = false;
            IntrinsicsList.BorderStyle = BorderStyle.Fixed3D;
            IntrinsicsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IntrinsicsList.Columns.AddRange(new DataGridViewColumn[] { returnTypeDataGridViewTextBoxColumn, intrincNameDataGridViewTextBoxColumn, instructionDataGridViewTextBoxColumn });
            IntrinsicsList.DataSource = intrincItemBindingSource;
            IntrinsicsList.Dock = DockStyle.Fill;
            IntrinsicsList.Location = new Point(135, 73);
            IntrinsicsList.MultiSelect = false;
            IntrinsicsList.Name = "IntrinsicsList";
            IntrinsicsList.ReadOnly = true;
            IntrinsicsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            IntrinsicsList.Size = new Size(1059, 633);
            IntrinsicsList.TabIndex = 0;
            IntrinsicsList.CellClick += IntrinsicsList_CellClick;
            // 
            // returnTypeDataGridViewTextBoxColumn
            // 
            returnTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            returnTypeDataGridViewTextBoxColumn.DataPropertyName = "ReturnType";
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            returnTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            returnTypeDataGridViewTextBoxColumn.HeaderText = "ReturnType";
            returnTypeDataGridViewTextBoxColumn.Name = "returnTypeDataGridViewTextBoxColumn";
            returnTypeDataGridViewTextBoxColumn.ReadOnly = true;
            returnTypeDataGridViewTextBoxColumn.Width = 91;
            // 
            // intrincNameDataGridViewTextBoxColumn
            // 
            intrincNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            intrincNameDataGridViewTextBoxColumn.DataPropertyName = "FuncSignature";
            dataGridViewCellStyle2.Font = new Font("Courier New", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            intrincNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            intrincNameDataGridViewTextBoxColumn.HeaderText = "FunctionSignature";
            intrincNameDataGridViewTextBoxColumn.Name = "intrincNameDataGridViewTextBoxColumn";
            intrincNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instructionDataGridViewTextBoxColumn
            // 
            instructionDataGridViewTextBoxColumn.DataPropertyName = "Instruction";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            instructionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            instructionDataGridViewTextBoxColumn.HeaderText = "Instruction";
            instructionDataGridViewTextBoxColumn.Name = "instructionDataGridViewTextBoxColumn";
            instructionDataGridViewTextBoxColumn.ReadOnly = true;
            instructionDataGridViewTextBoxColumn.Width = 120;
            // 
            // intrincItemBindingSource
            // 
            intrincItemBindingSource.DataSource = typeof(IntrincItem);
            // 
            // MMX_box
            // 
            MMX_box.BackColor = Color.Gold;
            MMX_box.Location = new Point(0, 3);
            MMX_box.Margin = new Padding(0, 3, 3, 0);
            MMX_box.Name = "MMX_box";
            MMX_box.Padding = new Padding(1, 1, 0, 0);
            MMX_box.Size = new Size(114, 19);
            MMX_box.TabIndex = 1;
            MMX_box.Text = "MMX";
            MMX_box.UseVisualStyleBackColor = false;
            MMX_box.CheckedChanged += ExtentionCheckboxChanged;
            // 
            // AVX_box
            // 
            AVX_box.AutoSize = true;
            AVX_box.Location = new Point(6, 6);
            AVX_box.Name = "AVX_box";
            AVX_box.Size = new Size(47, 19);
            AVX_box.TabIndex = 8;
            AVX_box.Text = "AVX";
            AVX_box.TextAlign = ContentAlignment.MiddleCenter;
            AVX_box.UseVisualStyleBackColor = true;
            AVX_box.CheckedChanged += ExtentionCheckboxChanged;
            AVX_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // SSE_ALL_box
            // 
            SSE_ALL_box.BackColor = Color.YellowGreen;
            SSE_ALL_box.Dock = DockStyle.Top;
            SSE_ALL_box.ForeColor = Color.Black;
            SSE_ALL_box.Location = new Point(0, 28);
            SSE_ALL_box.Margin = new Padding(0, 3, 3, 0);
            SSE_ALL_box.Name = "SSE_ALL_box";
            SSE_ALL_box.Padding = new Padding(1, 1, 0, 0);
            SSE_ALL_box.Size = new Size(114, 19);
            SSE_ALL_box.TabIndex = 11;
            SSE_ALL_box.Text = "SSE family";
            SSE_ALL_box.UseVisualStyleBackColor = false;
            SSE_ALL_box.CheckedChanged += SSE_ALL_box_CheckedChanged;
            SSE_ALL_box.MouseLeave += SSE_SubmenuMouseLeave;
            SSE_ALL_box.MouseHover += SSE_family_show;
            // 
            // SSE_family_items
            // 
            SSE_family_items.AllowDrop = true;
            SSE_family_items.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            SSE_family_items.ColumnCount = 1;
            SSE_family_items.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SSE_family_items.Controls.Add(SSE4_2_box, 0, 5);
            SSE_family_items.Controls.Add(SSE4_1_box, 0, 4);
            SSE_family_items.Controls.Add(SSE_box, 0, 0);
            SSE_family_items.Controls.Add(SSE3_box, 0, 2);
            SSE_family_items.Controls.Add(SSSE3_box, 0, 3);
            SSE_family_items.Controls.Add(SSE2_box, 0, 1);
            SSE_family_items.Dock = DockStyle.Fill;
            SSE_family_items.Location = new Point(0, 50);
            SSE_family_items.Margin = new Padding(0);
            SSE_family_items.Name = "SSE_family_items";
            SSE_family_items.RowCount = 6;
            SSE_family_items.RowStyles.Add(new RowStyle());
            SSE_family_items.RowStyles.Add(new RowStyle());
            SSE_family_items.RowStyles.Add(new RowStyle());
            SSE_family_items.RowStyles.Add(new RowStyle());
            SSE_family_items.RowStyles.Add(new RowStyle());
            SSE_family_items.RowStyles.Add(new RowStyle());
            SSE_family_items.Size = new Size(117, 170);
            SSE_family_items.TabIndex = 15;
            SSE_family_items.Visible = false;
            SSE_family_items.MouseLeave += SSE_SubmenuMouseLeave;
            // 
            // SSE4_2_box
            // 
            SSE4_2_box.AutoSize = true;
            SSE4_2_box.Location = new Point(6, 146);
            SSE4_2_box.Name = "SSE4_2_box";
            SSE4_2_box.Size = new Size(59, 19);
            SSE4_2_box.TabIndex = 7;
            SSE4_2_box.Text = "SSE4.2";
            SSE4_2_box.TextAlign = ContentAlignment.MiddleCenter;
            SSE4_2_box.UseVisualStyleBackColor = true;
            SSE4_2_box.CheckedChanged += ExtentionCheckboxChanged;
            SSE4_2_box.MouseLeave += SSE_SubmenuMouseLeave;
            // 
            // SSE4_1_box
            // 
            SSE4_1_box.AutoSize = true;
            SSE4_1_box.Location = new Point(6, 118);
            SSE4_1_box.Name = "SSE4_1_box";
            SSE4_1_box.Size = new Size(59, 19);
            SSE4_1_box.TabIndex = 6;
            SSE4_1_box.Text = "SSE4.1";
            SSE4_1_box.TextAlign = ContentAlignment.MiddleCenter;
            SSE4_1_box.UseVisualStyleBackColor = true;
            SSE4_1_box.CheckedChanged += ExtentionCheckboxChanged;
            SSE4_1_box.MouseLeave += SSE_SubmenuMouseLeave;
            // 
            // SSE_box
            // 
            SSE_box.AutoSize = true;
            SSE_box.Location = new Point(6, 6);
            SSE_box.Name = "SSE_box";
            SSE_box.Size = new Size(44, 19);
            SSE_box.TabIndex = 2;
            SSE_box.Text = "SSE";
            SSE_box.TextAlign = ContentAlignment.MiddleCenter;
            SSE_box.UseVisualStyleBackColor = true;
            SSE_box.CheckedChanged += ExtentionCheckboxChanged;
            SSE_box.MouseLeave += SSE_SubmenuMouseLeave;
            // 
            // SSE3_box
            // 
            SSE3_box.AutoSize = true;
            SSE3_box.Location = new Point(6, 62);
            SSE3_box.Name = "SSE3_box";
            SSE3_box.Size = new Size(50, 19);
            SSE3_box.TabIndex = 4;
            SSE3_box.Text = "SSE3";
            SSE3_box.TextAlign = ContentAlignment.MiddleCenter;
            SSE3_box.UseVisualStyleBackColor = true;
            SSE3_box.CheckedChanged += ExtentionCheckboxChanged;
            SSE3_box.MouseLeave += SSE_SubmenuMouseLeave;
            // 
            // SSSE3_box
            // 
            SSSE3_box.AutoSize = true;
            SSSE3_box.Location = new Point(6, 90);
            SSSE3_box.Name = "SSSE3_box";
            SSSE3_box.Size = new Size(56, 19);
            SSSE3_box.TabIndex = 5;
            SSSE3_box.Text = "SSSE3";
            SSSE3_box.TextAlign = ContentAlignment.MiddleCenter;
            SSSE3_box.UseVisualStyleBackColor = true;
            SSSE3_box.CheckedChanged += ExtentionCheckboxChanged;
            SSSE3_box.MouseLeave += SSE_SubmenuMouseLeave;
            // 
            // SSE2_box
            // 
            SSE2_box.AutoSize = true;
            SSE2_box.Location = new Point(6, 34);
            SSE2_box.Name = "SSE2_box";
            SSE2_box.Size = new Size(50, 19);
            SSE2_box.TabIndex = 3;
            SSE2_box.Text = "SSE2";
            SSE2_box.TextAlign = ContentAlignment.MiddleCenter;
            SSE2_box.UseVisualStyleBackColor = true;
            SSE2_box.CheckedChanged += ExtentionCheckboxChanged;
            SSE2_box.MouseLeave += SSE_SubmenuMouseLeave;
            // 
            // AMX_ALL_box
            // 
            AMX_ALL_box.AutoSize = true;
            AMX_ALL_box.BackColor = Color.DarkMagenta;
            AMX_ALL_box.Dock = DockStyle.Top;
            AMX_ALL_box.Location = new Point(0, 1001);
            AMX_ALL_box.Margin = new Padding(0, 3, 3, 3);
            AMX_ALL_box.Name = "AMX_ALL_box";
            AMX_ALL_box.Padding = new Padding(1, 1, 0, 0);
            AMX_ALL_box.Size = new Size(114, 19);
            AMX_ALL_box.TabIndex = 12;
            AMX_ALL_box.Text = "AMX family";
            AMX_ALL_box.UseVisualStyleBackColor = false;
            AMX_ALL_box.CheckedChanged += AMX_ALL_box_CheckedChanged;
            AMX_ALL_box.MouseLeave += AMX_SubmenuMouseLeave;
            AMX_ALL_box.MouseHover += AMX_family_show;
            // 
            // AVX_ALL_box
            // 
            AVX_ALL_box.BackColor = Color.ForestGreen;
            AVX_ALL_box.Dock = DockStyle.Top;
            AVX_ALL_box.Location = new Point(0, 223);
            AVX_ALL_box.Margin = new Padding(0, 3, 3, 0);
            AVX_ALL_box.Name = "AVX_ALL_box";
            AVX_ALL_box.Padding = new Padding(1, 1, 0, 0);
            AVX_ALL_box.Size = new Size(114, 19);
            AVX_ALL_box.TabIndex = 18;
            AVX_ALL_box.Text = "AVX family";
            AVX_ALL_box.UseVisualStyleBackColor = false;
            AVX_ALL_box.CheckedChanged += AVX_ALL_box_CheckedChanged;
            AVX_ALL_box.MouseLeave += AVX_SubmenuMouseLeave;
            AVX_ALL_box.MouseHover += AVX_family_show;
            // 
            // searchBox
            // 
            searchBox.AcceptsReturn = true;
            searchBox.CharacterCasing = CharacterCasing.Lower;
            searchBox.Dock = DockStyle.Bottom;
            searchBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ImeMode = ImeMode.On;
            searchBox.Location = new Point(0, 11);
            searchBox.MaxLength = 200;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(1032, 22);
            searchBox.TabIndex = 11;
            searchBox.WordWrap = false;
            searchBox.TextChanged += searchBoxChanged;
            searchBox.KeyPress += searchBox_SuppressEnterSound;
            // 
            // searchPlaceHolder
            // 
            searchPlaceHolder.AutoSize = true;
            searchPlaceHolder.BackColor = Color.White;
            searchPlaceHolder.Enabled = false;
            searchPlaceHolder.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPlaceHolder.ForeColor = Color.Black;
            searchPlaceHolder.Location = new Point(4, 14);
            searchPlaceHolder.Margin = new Padding(0);
            searchPlaceHolder.Name = "searchPlaceHolder";
            searchPlaceHolder.Size = new Size(115, 16);
            searchPlaceHolder.TabIndex = 12;
            searchPlaceHolder.Text = "Search for Intrinsic";
            // 
            // extentionsPannel
            // 
            extentionsPannel.ColumnCount = 1;
            extentionsPannel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            extentionsPannel.Controls.Add(AVX512_family_items, 0, 6);
            extentionsPannel.Controls.Add(UNKNOWN_box, 0, 10);
            extentionsPannel.Controls.Add(SSE_ALL_box, 0, 1);
            extentionsPannel.Controls.Add(AMX_family_items, 0, 8);
            extentionsPannel.Controls.Add(SSE_family_items, 0, 2);
            extentionsPannel.Controls.Add(AVX_ALL_box, 0, 3);
            extentionsPannel.Controls.Add(AMX_ALL_box, 0, 7);
            extentionsPannel.Controls.Add(MMX_box, 0, 0);
            extentionsPannel.Controls.Add(AVX512_ALL_box, 0, 5);
            extentionsPannel.Controls.Add(AVX_family_items, 0, 4);
            extentionsPannel.Controls.Add(Other_box, 0, 9);
            extentionsPannel.Dock = DockStyle.Left;
            extentionsPannel.Location = new Point(12, 73);
            extentionsPannel.Name = "extentionsPannel";
            extentionsPannel.RowCount = 11;
            extentionsPannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            extentionsPannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            extentionsPannel.RowStyles.Add(new RowStyle());
            extentionsPannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            extentionsPannel.RowStyles.Add(new RowStyle());
            extentionsPannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            extentionsPannel.RowStyles.Add(new RowStyle());
            extentionsPannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            extentionsPannel.RowStyles.Add(new RowStyle());
            extentionsPannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            extentionsPannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            extentionsPannel.Size = new Size(117, 633);
            extentionsPannel.TabIndex = 19;
            // 
            // AVX512_family_items
            // 
            AVX512_family_items.AllowDrop = true;
            AVX512_family_items.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            AVX512_family_items.ColumnCount = 1;
            AVX512_family_items.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AVX512_family_items.Controls.Add(AVX512VL_box, 0, 5);
            AVX512_family_items.Controls.Add(AVX512FP16_box, 0, 13);
            AVX512_family_items.Controls.Add(AVX512VP2INTERSECT_box, 0, 12);
            AVX512_family_items.Controls.Add(AVX512VNNI_box, 0, 11);
            AVX512_family_items.Controls.Add(AVX512VBMI2_box, 0, 10);
            AVX512_family_items.Controls.Add(AVX512VBMI_box, 0, 9);
            AVX512_family_items.Controls.Add(AVX512BITALG_box, 0, 8);
            AVX512_family_items.Controls.Add(AVX512BF16_box, 0, 7);
            AVX512_family_items.Controls.Add(AVX512VPOPCNTDQ_box, 0, 6);
            AVX512_family_items.Controls.Add(AVX512DQ_box, 0, 3);
            AVX512_family_items.Controls.Add(AVX512CD_box, 0, 2);
            AVX512_family_items.Controls.Add(AVX512BW_box, 0, 1);
            AVX512_family_items.Controls.Add(AVX512F_box, 0, 0);
            AVX512_family_items.Controls.Add(AVX512IFMA52_box, 0, 4);
            AVX512_family_items.Dock = DockStyle.Fill;
            AVX512_family_items.Location = new Point(0, 606);
            AVX512_family_items.Margin = new Padding(0);
            AVX512_family_items.Name = "AVX512_family_items";
            AVX512_family_items.RowCount = 14;
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX512_family_items.Size = new Size(117, 392);
            AVX512_family_items.TabIndex = 25;
            AVX512_family_items.Visible = false;
            AVX512_family_items.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512VL_box
            // 
            AVX512VL_box.AutoSize = true;
            AVX512VL_box.Location = new Point(6, 146);
            AVX512VL_box.Name = "AVX512VL_box";
            AVX512VL_box.Size = new Size(78, 19);
            AVX512VL_box.TabIndex = 21;
            AVX512VL_box.Text = "AVX512VL";
            AVX512VL_box.UseVisualStyleBackColor = true;
            AVX512VL_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512FP16_box
            // 
            AVX512FP16_box.AutoSize = true;
            AVX512FP16_box.Location = new Point(6, 370);
            AVX512FP16_box.Name = "AVX512FP16_box";
            AVX512FP16_box.Size = new Size(95, 19);
            AVX512FP16_box.TabIndex = 21;
            AVX512FP16_box.Text = "AVX512_FP16";
            AVX512FP16_box.UseVisualStyleBackColor = true;
            AVX512FP16_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512VP2INTERSECT_box
            // 
            AVX512VP2INTERSECT_box.AutoSize = true;
            AVX512VP2INTERSECT_box.Location = new Point(6, 342);
            AVX512VP2INTERSECT_box.Name = "AVX512VP2INTERSECT_box";
            AVX512VP2INTERSECT_box.Size = new Size(105, 19);
            AVX512VP2INTERSECT_box.TabIndex = 21;
            AVX512VP2INTERSECT_box.Text = "AVX512_VP2INTERSECT";
            AVX512VP2INTERSECT_box.UseVisualStyleBackColor = true;
            AVX512VP2INTERSECT_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512VNNI_box
            // 
            AVX512VNNI_box.AutoSize = true;
            AVX512VNNI_box.Location = new Point(6, 314);
            AVX512VNNI_box.Name = "AVX512VNNI_box";
            AVX512VNNI_box.Size = new Size(98, 19);
            AVX512VNNI_box.TabIndex = 21;
            AVX512VNNI_box.Text = "AVX512_VNNI";
            AVX512VNNI_box.UseVisualStyleBackColor = true;
            AVX512VNNI_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512VBMI2_box
            // 
            AVX512VBMI2_box.AutoSize = true;
            AVX512VBMI2_box.Location = new Point(6, 286);
            AVX512VBMI2_box.Name = "AVX512VBMI2_box";
            AVX512VBMI2_box.Size = new Size(104, 19);
            AVX512VBMI2_box.TabIndex = 21;
            AVX512VBMI2_box.Text = "AVX512_VBMI2";
            AVX512VBMI2_box.UseVisualStyleBackColor = true;
            AVX512VBMI2_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512VBMI_box
            // 
            AVX512VBMI_box.AutoSize = true;
            AVX512VBMI_box.Location = new Point(6, 258);
            AVX512VBMI_box.Name = "AVX512VBMI_box";
            AVX512VBMI_box.Size = new Size(98, 19);
            AVX512VBMI_box.TabIndex = 21;
            AVX512VBMI_box.Text = "AVX512_VBMI";
            AVX512VBMI_box.UseVisualStyleBackColor = true;
            AVX512VBMI_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512BITALG_box
            // 
            AVX512BITALG_box.AutoSize = true;
            AVX512BITALG_box.Location = new Point(6, 230);
            AVX512BITALG_box.Name = "AVX512BITALG_box";
            AVX512BITALG_box.Size = new Size(105, 19);
            AVX512BITALG_box.TabIndex = 21;
            AVX512BITALG_box.Text = "AVX512_BITALG";
            AVX512BITALG_box.UseVisualStyleBackColor = true;
            AVX512BITALG_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512BF16_box
            // 
            AVX512BF16_box.AutoSize = true;
            AVX512BF16_box.Location = new Point(6, 202);
            AVX512BF16_box.Name = "AVX512BF16_box";
            AVX512BF16_box.Size = new Size(95, 19);
            AVX512BF16_box.TabIndex = 21;
            AVX512BF16_box.Text = "AVX512_BF16";
            AVX512BF16_box.UseVisualStyleBackColor = true;
            AVX512BF16_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512VPOPCNTDQ_box
            // 
            AVX512VPOPCNTDQ_box.AutoSize = true;
            AVX512VPOPCNTDQ_box.Location = new Point(6, 174);
            AVX512VPOPCNTDQ_box.Name = "AVX512VPOPCNTDQ_box";
            AVX512VPOPCNTDQ_box.Size = new Size(105, 19);
            AVX512VPOPCNTDQ_box.TabIndex = 21;
            AVX512VPOPCNTDQ_box.Text = "AVX512VPOPCNTDQ";
            AVX512VPOPCNTDQ_box.UseVisualStyleBackColor = true;
            AVX512VPOPCNTDQ_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512DQ_box
            // 
            AVX512DQ_box.AutoSize = true;
            AVX512DQ_box.Location = new Point(6, 90);
            AVX512DQ_box.Name = "AVX512DQ_box";
            AVX512DQ_box.Size = new Size(82, 19);
            AVX512DQ_box.TabIndex = 21;
            AVX512DQ_box.Text = "AVX512DQ";
            AVX512DQ_box.UseVisualStyleBackColor = true;
            AVX512DQ_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512CD_box
            // 
            AVX512CD_box.AutoSize = true;
            AVX512CD_box.Location = new Point(6, 62);
            AVX512CD_box.Name = "AVX512CD_box";
            AVX512CD_box.Size = new Size(81, 19);
            AVX512CD_box.TabIndex = 21;
            AVX512CD_box.Text = "AVX512CD";
            AVX512CD_box.UseVisualStyleBackColor = true;
            AVX512CD_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512BW_box
            // 
            AVX512BW_box.AutoSize = true;
            AVX512BW_box.Location = new Point(6, 34);
            AVX512BW_box.Name = "AVX512BW_box";
            AVX512BW_box.Size = new Size(83, 19);
            AVX512BW_box.TabIndex = 21;
            AVX512BW_box.Text = "AVX512BW";
            AVX512BW_box.UseVisualStyleBackColor = true;
            AVX512BW_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512F_box
            // 
            AVX512F_box.AutoSize = true;
            AVX512F_box.Location = new Point(6, 6);
            AVX512F_box.Name = "AVX512F_box";
            AVX512F_box.Size = new Size(71, 19);
            AVX512F_box.TabIndex = 20;
            AVX512F_box.Text = "AVX512F";
            AVX512F_box.UseVisualStyleBackColor = true;
            AVX512F_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // AVX512IFMA52_box
            // 
            AVX512IFMA52_box.AutoSize = true;
            AVX512IFMA52_box.Location = new Point(6, 118);
            AVX512IFMA52_box.Name = "AVX512IFMA52_box";
            AVX512IFMA52_box.Size = new Size(105, 19);
            AVX512IFMA52_box.TabIndex = 22;
            AVX512IFMA52_box.Text = "AVX512IFMA52";
            AVX512IFMA52_box.UseVisualStyleBackColor = true;
            AVX512IFMA52_box.MouseLeave += AVX512_SubmenuMouseLeave;
            // 
            // UNKNOWN_box
            // 
            UNKNOWN_box.BackColor = Color.Silver;
            UNKNOWN_box.Dock = DockStyle.Top;
            UNKNOWN_box.Location = new Point(0, 1191);
            UNKNOWN_box.Margin = new Padding(0, 3, 3, 3);
            UNKNOWN_box.Name = "UNKNOWN_box";
            UNKNOWN_box.Padding = new Padding(1, 1, 0, 0);
            UNKNOWN_box.Size = new Size(114, 17);
            UNKNOWN_box.TabIndex = 20;
            UNKNOWN_box.Text = "UNKNOWN";
            UNKNOWN_box.UseVisualStyleBackColor = false;
            UNKNOWN_box.CheckedChanged += ExtentionCheckboxChanged;
            // 
            // AMX_family_items
            // 
            AMX_family_items.AllowDrop = true;
            AMX_family_items.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            AMX_family_items.ColumnCount = 1;
            AMX_family_items.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AMX_family_items.Controls.Add(AMX_COMPLEX_box, 0, 4);
            AMX_family_items.Controls.Add(AMX_FP16_box, 0, 3);
            AMX_family_items.Controls.Add(AMX_TILE_box, 0, 2);
            AMX_family_items.Controls.Add(AMX_INT8_box, 0, 1);
            AMX_family_items.Controls.Add(AMX_BF16_box, 0, 0);
            AMX_family_items.Location = new Point(0, 1023);
            AMX_family_items.Margin = new Padding(0);
            AMX_family_items.Name = "AMX_family_items";
            AMX_family_items.RowCount = 5;
            AMX_family_items.RowStyles.Add(new RowStyle());
            AMX_family_items.RowStyles.Add(new RowStyle());
            AMX_family_items.RowStyles.Add(new RowStyle());
            AMX_family_items.RowStyles.Add(new RowStyle());
            AMX_family_items.RowStyles.Add(new RowStyle());
            AMX_family_items.Size = new Size(117, 140);
            AMX_family_items.TabIndex = 22;
            AMX_family_items.Visible = false;
            AMX_family_items.MouseLeave += AMX_SubmenuMouseLeave;
            // 
            // AMX_COMPLEX_box
            // 
            AMX_COMPLEX_box.AutoSize = true;
            AMX_COMPLEX_box.Location = new Point(6, 118);
            AMX_COMPLEX_box.Name = "AMX_COMPLEX_box";
            AMX_COMPLEX_box.Size = new Size(105, 19);
            AMX_COMPLEX_box.TabIndex = 22;
            AMX_COMPLEX_box.Text = "AMX-COMPLEX";
            AMX_COMPLEX_box.UseVisualStyleBackColor = true;
            AMX_COMPLEX_box.CheckedChanged += ExtentionCheckboxChanged;
            AMX_COMPLEX_box.MouseLeave += AMX_SubmenuMouseLeave;
            // 
            // AMX_FP16_box
            // 
            AMX_FP16_box.AutoSize = true;
            AMX_FP16_box.Location = new Point(6, 90);
            AMX_FP16_box.Name = "AMX_FP16_box";
            AMX_FP16_box.Size = new Size(82, 19);
            AMX_FP16_box.TabIndex = 22;
            AMX_FP16_box.Text = "AMX-FP16";
            AMX_FP16_box.UseVisualStyleBackColor = true;
            AMX_FP16_box.CheckedChanged += ExtentionCheckboxChanged;
            AMX_FP16_box.MouseLeave += AMX_SubmenuMouseLeave;
            // 
            // AMX_TILE_box
            // 
            AMX_TILE_box.AutoSize = true;
            AMX_TILE_box.Location = new Point(6, 62);
            AMX_TILE_box.Name = "AMX_TILE_box";
            AMX_TILE_box.Size = new Size(78, 19);
            AMX_TILE_box.TabIndex = 22;
            AMX_TILE_box.Text = "AMX-TILE";
            AMX_TILE_box.UseVisualStyleBackColor = true;
            AMX_TILE_box.CheckedChanged += ExtentionCheckboxChanged;
            AMX_TILE_box.MouseLeave += AMX_SubmenuMouseLeave;
            // 
            // AMX_INT8_box
            // 
            AMX_INT8_box.AutoSize = true;
            AMX_INT8_box.Location = new Point(6, 34);
            AMX_INT8_box.Name = "AMX_INT8_box";
            AMX_INT8_box.Size = new Size(81, 19);
            AMX_INT8_box.TabIndex = 22;
            AMX_INT8_box.Text = "AMX-INT8";
            AMX_INT8_box.UseVisualStyleBackColor = true;
            AMX_INT8_box.CheckedChanged += ExtentionCheckboxChanged;
            AMX_INT8_box.MouseLeave += AMX_SubmenuMouseLeave;
            // 
            // AMX_BF16_box
            // 
            AMX_BF16_box.AutoSize = true;
            AMX_BF16_box.Location = new Point(6, 6);
            AMX_BF16_box.Name = "AMX_BF16_box";
            AMX_BF16_box.Size = new Size(82, 19);
            AMX_BF16_box.TabIndex = 22;
            AMX_BF16_box.Text = "AMX-BF16";
            AMX_BF16_box.UseVisualStyleBackColor = true;
            AMX_BF16_box.CheckedChanged += ExtentionCheckboxChanged;
            AMX_BF16_box.MouseLeave += AMX_SubmenuMouseLeave;
            // 
            // AVX512_ALL_box
            // 
            AVX512_ALL_box.AutoSize = true;
            AVX512_ALL_box.BackColor = Color.PowderBlue;
            AVX512_ALL_box.Dock = DockStyle.Top;
            AVX512_ALL_box.Location = new Point(0, 584);
            AVX512_ALL_box.Margin = new Padding(0, 3, 3, 0);
            AVX512_ALL_box.Name = "AVX512_ALL_box";
            AVX512_ALL_box.Padding = new Padding(1, 1, 0, 0);
            AVX512_ALL_box.Size = new Size(114, 20);
            AVX512_ALL_box.TabIndex = 20;
            AVX512_ALL_box.Text = "512 family";
            AVX512_ALL_box.UseVisualStyleBackColor = false;
            AVX512_ALL_box.CheckedChanged += AVX512_ALL_box_CheckedChanged;
            AVX512_ALL_box.MouseLeave += AVX512_SubmenuMouseLeave;
            AVX512_ALL_box.MouseHover += AVX512_family_show;
            // 
            // AVX_family_items
            // 
            AVX_family_items.AllowDrop = true;
            AVX_family_items.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            AVX_family_items.ColumnCount = 1;
            AVX_family_items.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AVX_family_items.Controls.Add(AVX_VNNI_INT16_box, 0, 8);
            AVX_family_items.Controls.Add(AVX_IFMA_box, 0, 7);
            AVX_family_items.Controls.Add(AVX_NE_CONVERT_box, 0, 6);
            AVX_family_items.Controls.Add(AVX_VNNI_INT8_box, 0, 5);
            AVX_family_items.Controls.Add(AVX_VNNI_box, 0, 4);
            AVX_family_items.Controls.Add(AVX2_box, 0, 3);
            AVX_family_items.Controls.Add(FMA_box, 0, 2);
            AVX_family_items.Controls.Add(AVX_box, 0, 0);
            AVX_family_items.Controls.Add(F16C_box, 0, 1);
            AVX_family_items.Controls.Add(SM4_box, 0, 11);
            AVX_family_items.Controls.Add(SM3_box, 0, 10);
            AVX_family_items.Controls.Add(SHA512_box, 0, 9);
            AVX_family_items.Dock = DockStyle.Fill;
            AVX_family_items.Location = new Point(0, 245);
            AVX_family_items.Margin = new Padding(0);
            AVX_family_items.Name = "AVX_family_items";
            AVX_family_items.RowCount = 12;
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            AVX_family_items.Size = new Size(117, 336);
            AVX_family_items.TabIndex = 20;
            AVX_family_items.Visible = false;
            AVX_family_items.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // AVX_VNNI_INT16_box
            // 
            AVX_VNNI_INT16_box.AutoSize = true;
            AVX_VNNI_INT16_box.Location = new Point(6, 230);
            AVX_VNNI_INT16_box.Name = "AVX_VNNI_INT16_box";
            AVX_VNNI_INT16_box.Size = new Size(105, 19);
            AVX_VNNI_INT16_box.TabIndex = 20;
            AVX_VNNI_INT16_box.Text = "AVX_VNNI_INT16";
            AVX_VNNI_INT16_box.UseVisualStyleBackColor = true;
            AVX_VNNI_INT16_box.CheckedChanged += ExtentionCheckboxChanged;
            AVX_VNNI_INT16_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // AVX_IFMA_box
            // 
            AVX_IFMA_box.AutoSize = true;
            AVX_IFMA_box.Location = new Point(6, 202);
            AVX_IFMA_box.Name = "AVX_IFMA_box";
            AVX_IFMA_box.Size = new Size(80, 19);
            AVX_IFMA_box.TabIndex = 20;
            AVX_IFMA_box.Text = "AVX_IFMA";
            AVX_IFMA_box.UseVisualStyleBackColor = true;
            AVX_IFMA_box.CheckedChanged += ExtentionCheckboxChanged;
            AVX_IFMA_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // AVX_NE_CONVERT_box
            // 
            AVX_NE_CONVERT_box.AutoSize = true;
            AVX_NE_CONVERT_box.Location = new Point(6, 174);
            AVX_NE_CONVERT_box.Name = "AVX_NE_CONVERT_box";
            AVX_NE_CONVERT_box.Size = new Size(105, 19);
            AVX_NE_CONVERT_box.TabIndex = 20;
            AVX_NE_CONVERT_box.Text = "AVX_NE_CONVERT";
            AVX_NE_CONVERT_box.UseVisualStyleBackColor = true;
            AVX_NE_CONVERT_box.CheckedChanged += ExtentionCheckboxChanged;
            AVX_NE_CONVERT_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // AVX_VNNI_INT8_box
            // 
            AVX_VNNI_INT8_box.AutoSize = true;
            AVX_VNNI_INT8_box.Location = new Point(6, 146);
            AVX_VNNI_INT8_box.Name = "AVX_VNNI_INT8_box";
            AVX_VNNI_INT8_box.Size = new Size(105, 19);
            AVX_VNNI_INT8_box.TabIndex = 20;
            AVX_VNNI_INT8_box.Text = "AVX_VNNI_INT8";
            AVX_VNNI_INT8_box.UseVisualStyleBackColor = true;
            AVX_VNNI_INT8_box.CheckedChanged += ExtentionCheckboxChanged;
            AVX_VNNI_INT8_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // AVX_VNNI_box
            // 
            AVX_VNNI_box.AutoSize = true;
            AVX_VNNI_box.Location = new Point(6, 118);
            AVX_VNNI_box.Name = "AVX_VNNI_box";
            AVX_VNNI_box.Size = new Size(80, 19);
            AVX_VNNI_box.TabIndex = 20;
            AVX_VNNI_box.Text = "AVX_VNNI";
            AVX_VNNI_box.UseVisualStyleBackColor = true;
            AVX_VNNI_box.CheckedChanged += ExtentionCheckboxChanged;
            AVX_VNNI_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // AVX2_box
            // 
            AVX2_box.AutoSize = true;
            AVX2_box.Location = new Point(6, 90);
            AVX2_box.Name = "AVX2_box";
            AVX2_box.Size = new Size(53, 19);
            AVX2_box.TabIndex = 20;
            AVX2_box.Text = "AVX2";
            AVX2_box.UseVisualStyleBackColor = true;
            AVX2_box.CheckedChanged += ExtentionCheckboxChanged;
            AVX2_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // FMA_box
            // 
            FMA_box.AutoSize = true;
            FMA_box.Location = new Point(6, 62);
            FMA_box.Name = "FMA_box";
            FMA_box.Size = new Size(51, 19);
            FMA_box.TabIndex = 20;
            FMA_box.Text = "FMA";
            FMA_box.UseVisualStyleBackColor = true;
            FMA_box.CheckedChanged += ExtentionCheckboxChanged;
            FMA_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // F16C_box
            // 
            F16C_box.AutoSize = true;
            F16C_box.Location = new Point(6, 34);
            F16C_box.Name = "F16C_box";
            F16C_box.Size = new Size(52, 19);
            F16C_box.TabIndex = 20;
            F16C_box.Text = "F16C";
            F16C_box.UseVisualStyleBackColor = true;
            F16C_box.CheckedChanged += ExtentionCheckboxChanged;
            F16C_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // SM4_box
            // 
            SM4_box.AutoSize = true;
            SM4_box.Location = new Point(6, 314);
            SM4_box.Name = "SM4_box";
            SM4_box.Size = new Size(49, 19);
            SM4_box.TabIndex = 20;
            SM4_box.Text = "SM4";
            SM4_box.UseVisualStyleBackColor = true;
            SM4_box.CheckedChanged += ExtentionCheckboxChanged;
            SM4_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // SM3_box
            // 
            SM3_box.AutoSize = true;
            SM3_box.Location = new Point(6, 286);
            SM3_box.Name = "SM3_box";
            SM3_box.Size = new Size(49, 19);
            SM3_box.TabIndex = 20;
            SM3_box.Text = "SM3";
            SM3_box.UseVisualStyleBackColor = true;
            SM3_box.CheckedChanged += ExtentionCheckboxChanged;
            SM3_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // SHA512_box
            // 
            SHA512_box.AutoSize = true;
            SHA512_box.Location = new Point(6, 258);
            SHA512_box.Name = "SHA512_box";
            SHA512_box.Size = new Size(67, 19);
            SHA512_box.TabIndex = 20;
            SHA512_box.Text = "SHA512";
            SHA512_box.UseVisualStyleBackColor = true;
            SHA512_box.CheckedChanged += ExtentionCheckboxChanged;
            SHA512_box.MouseLeave += AVX_SubmenuMouseLeave;
            // 
            // Other_box
            // 
            Other_box.BackColor = Color.Gray;
            Other_box.Dock = DockStyle.Top;
            Other_box.Location = new Point(0, 1166);
            Other_box.Margin = new Padding(0, 3, 3, 0);
            Other_box.Name = "Other_box";
            Other_box.Padding = new Padding(1, 1, 0, 0);
            Other_box.Size = new Size(114, 19);
            Other_box.TabIndex = 23;
            Other_box.Text = "Other";
            Other_box.UseVisualStyleBackColor = false;
            Other_box.CheckedChanged += Other_ALL_box_CheckedChanged;
            // 
            // baseLayoutPannel
            // 
            baseLayoutPannel.AutoScroll = true;
            baseLayoutPannel.AutoSize = true;
            baseLayoutPannel.ColumnCount = 4;
            baseLayoutPannel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            baseLayoutPannel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.39805F));
            baseLayoutPannel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.60195F));
            baseLayoutPannel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            baseLayoutPannel.Controls.Add(IntrinsicsList, 2, 1);
            baseLayoutPannel.Controls.Add(extentionsPannel, 1, 1);
            baseLayoutPannel.Controls.Add(searchBoxSubPannel, 2, 0);
            baseLayoutPannel.Dock = DockStyle.Fill;
            baseLayoutPannel.Location = new Point(0, 0);
            baseLayoutPannel.Name = "baseLayoutPannel";
            baseLayoutPannel.Padding = new Padding(0, 0, 0, 5);
            baseLayoutPannel.RowCount = 2;
            baseLayoutPannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            baseLayoutPannel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            baseLayoutPannel.Size = new Size(1231, 714);
            baseLayoutPannel.TabIndex = 20;
            // 
            // searchBoxSubPannel
            // 
            searchBoxSubPannel.Controls.Add(searchPlaceHolder);
            searchBoxSubPannel.Controls.Add(searchBox);
            searchBoxSubPannel.Dock = DockStyle.Bottom;
            searchBoxSubPannel.Location = new Point(135, 32);
            searchBoxSubPannel.Margin = new Padding(3, 0, 30, 5);
            searchBoxSubPannel.Name = "searchBoxSubPannel";
            searchBoxSubPannel.Size = new Size(1032, 33);
            searchBoxSubPannel.TabIndex = 20;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { browseForDataFile, infoDialogMenuCheck });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(37, 20);
            fileMenu.Text = "File";
            // 
            // browseForDataFile
            // 
            browseForDataFile.Name = "browseForDataFile";
            browseForDataFile.Size = new Size(175, 22);
            browseForDataFile.Text = "Browse for data file";
            browseForDataFile.Click += setNewDataFile;
            // 
            // infoDialogMenuCheck
            // 
            infoDialogMenuCheck.Checked = true;
            infoDialogMenuCheck.CheckOnClick = true;
            infoDialogMenuCheck.CheckState = CheckState.Checked;
            infoDialogMenuCheck.Name = "infoDialogMenuCheck";
            infoDialogMenuCheck.Size = new Size(175, 22);
            infoDialogMenuCheck.Text = "Show info dialog";
            // 
            // optionsMenu
            // 
            optionsMenu.DropDownItems.AddRange(new ToolStripItem[] { searchIncludeInstruction, searchIncludeFuncName, searchIncludeDescription, searchIncludeReturnType, searchIncludeArgType, searchIncludeMask, searchHasSmallDelay });
            optionsMenu.Name = "optionsMenu";
            optionsMenu.Size = new Size(54, 20);
            optionsMenu.Text = "Search";
            // 
            // searchIncludeInstruction
            // 
            searchIncludeInstruction.Checked = true;
            searchIncludeInstruction.CheckOnClick = true;
            searchIncludeInstruction.CheckState = CheckState.Checked;
            searchIncludeInstruction.Name = "searchIncludeInstruction";
            searchIncludeInstruction.Size = new Size(198, 22);
            searchIncludeInstruction.Text = "Include Instruction";
            searchIncludeInstruction.CheckedChanged += SearchMenuChanged;
            // 
            // searchIncludeFuncName
            // 
            searchIncludeFuncName.Checked = true;
            searchIncludeFuncName.CheckOnClick = true;
            searchIncludeFuncName.CheckState = CheckState.Checked;
            searchIncludeFuncName.Name = "searchIncludeFuncName";
            searchIncludeFuncName.Size = new Size(198, 22);
            searchIncludeFuncName.Text = "Include Function Name";
            searchIncludeFuncName.CheckedChanged += SearchMenuChanged;
            // 
            // searchIncludeDescription
            // 
            searchIncludeDescription.Checked = true;
            searchIncludeDescription.CheckOnClick = true;
            searchIncludeDescription.CheckState = CheckState.Checked;
            searchIncludeDescription.Name = "searchIncludeDescription";
            searchIncludeDescription.Size = new Size(198, 22);
            searchIncludeDescription.Text = "Include Description";
            searchIncludeDescription.CheckedChanged += SearchMenuChanged;
            // 
            // searchIncludeReturnType
            // 
            searchIncludeReturnType.Checked = true;
            searchIncludeReturnType.CheckOnClick = true;
            searchIncludeReturnType.CheckState = CheckState.Checked;
            searchIncludeReturnType.Name = "searchIncludeReturnType";
            searchIncludeReturnType.Size = new Size(198, 22);
            searchIncludeReturnType.Text = "Include Return Type";
            searchIncludeReturnType.CheckedChanged += SearchMenuChanged;
            // 
            // searchIncludeArgType
            // 
            searchIncludeArgType.CheckOnClick = true;
            searchIncludeArgType.Enabled = false;
            searchIncludeArgType.Name = "searchIncludeArgType";
            searchIncludeArgType.Size = new Size(198, 22);
            searchIncludeArgType.Text = "Include Arg. Type";
            searchIncludeArgType.CheckedChanged += SearchMenuChanged;
            // 
            // searchIncludeMask
            // 
            searchIncludeMask.CheckOnClick = true;
            searchIncludeMask.Name = "searchIncludeMask";
            searchIncludeMask.Size = new Size(198, 22);
            searchIncludeMask.Text = "Include Mask Versions";
            searchIncludeMask.CheckedChanged += SearchMenuChanged;
            // 
            // searchHasSmallDelay
            // 
            searchHasSmallDelay.CheckOnClick = true;
            searchHasSmallDelay.Name = "searchHasSmallDelay";
            searchHasSmallDelay.Size = new Size(198, 22);
            searchHasSmallDelay.Text = "Delay before search";
            // 
            // sizeOptionsMenu
            // 
            sizeOptionsMenu.DropDownItems.AddRange(new ToolStripItem[] { searchSizeNonvec, searchSize64, searchSize128, searchSize256, searchSize512, searchSizeTile });
            sizeOptionsMenu.Name = "sizeOptionsMenu";
            sizeOptionsMenu.Size = new Size(80, 20);
            sizeOptionsMenu.Text = "Vector Sizes";
            // 
            // searchSizeNonvec
            // 
            searchSizeNonvec.Checked = true;
            searchSizeNonvec.CheckOnClick = true;
            searchSizeNonvec.CheckState = CheckState.Checked;
            searchSizeNonvec.Name = "searchSizeNonvec";
            searchSizeNonvec.Size = new Size(158, 22);
            searchSizeNonvec.Text = "Non-vector";
            searchSizeNonvec.CheckedChanged += SearchSizeChanged;
            // 
            // searchSize64
            // 
            searchSize64.Checked = true;
            searchSize64.CheckOnClick = true;
            searchSize64.CheckState = CheckState.Checked;
            searchSize64.Name = "searchSize64";
            searchSize64.Size = new Size(158, 22);
            searchSize64.Text = "64-bit  (mm)";
            searchSize64.CheckedChanged += SearchSizeChanged;
            // 
            // searchSize128
            // 
            searchSize128.Checked = true;
            searchSize128.CheckOnClick = true;
            searchSize128.CheckState = CheckState.Checked;
            searchSize128.Name = "searchSize128";
            searchSize128.Size = new Size(158, 22);
            searchSize128.Text = "128-bit (xmm)";
            searchSize128.CheckedChanged += SearchSizeChanged;
            // 
            // searchSize256
            // 
            searchSize256.Checked = true;
            searchSize256.CheckOnClick = true;
            searchSize256.CheckState = CheckState.Checked;
            searchSize256.Name = "searchSize256";
            searchSize256.Size = new Size(158, 22);
            searchSize256.Text = "256-bit (ymm)";
            searchSize256.CheckedChanged += SearchSizeChanged;
            // 
            // searchSize512
            // 
            searchSize512.Checked = true;
            searchSize512.CheckOnClick = true;
            searchSize512.CheckState = CheckState.Checked;
            searchSize512.Name = "searchSize512";
            searchSize512.Size = new Size(158, 22);
            searchSize512.Text = "512-bit (zmm)";
            searchSize512.CheckedChanged += SearchSizeChanged;
            // 
            // searchSizeTile
            // 
            searchSizeTile.Checked = true;
            searchSizeTile.CheckOnClick = true;
            searchSizeTile.CheckState = CheckState.Checked;
            searchSizeTile.Name = "searchSizeTile";
            searchSizeTile.Size = new Size(158, 22);
            searchSizeTile.Text = "AMX-tile (tmm)";
            searchSizeTile.CheckedChanged += SearchSizeChanged;
            // 
            // elementTypesOptionsMenu
            // 
            elementTypesOptionsMenu.BackColor = SystemColors.Control;
            elementTypesOptionsMenu.DropDownItems.AddRange(new ToolStripItem[] { searchTypeNonVec, searchType_GroupInt, searchType_GroupUnsigned, searchType_GroupFloat });
            elementTypesOptionsMenu.Name = "elementTypesOptionsMenu";
            elementTypesOptionsMenu.Size = new Size(94, 20);
            elementTypesOptionsMenu.Text = "Element Types";
            // 
            // searchTypeNonVec
            // 
            searchTypeNonVec.Checked = true;
            searchTypeNonVec.CheckOnClick = true;
            searchTypeNonVec.CheckState = CheckState.Checked;
            searchTypeNonVec.Name = "searchTypeNonVec";
            searchTypeNonVec.Size = new Size(171, 22);
            searchTypeNonVec.Text = "Non vector";
            searchTypeNonVec.CheckedChanged += SearchTypeChanged;
            // 
            // searchType_GroupInt
            // 
            searchType_GroupInt.Checked = true;
            searchType_GroupInt.CheckState = CheckState.Indeterminate;
            searchType_GroupInt.DropDownItems.AddRange(new ToolStripItem[] { searchTypeInt8, searchTypeInt16, searchTypeInt32, searchTypeInt64, searchTypeInt128 });
            searchType_GroupInt.Name = "searchType_GroupInt";
            searchType_GroupInt.Size = new Size(171, 22);
            searchType_GroupInt.Text = "Integer (generic)";
            searchType_GroupInt.Click += SearchTypeGroupToggle;
            // 
            // searchTypeInt8
            // 
            searchTypeInt8.Checked = true;
            searchTypeInt8.CheckOnClick = true;
            searchTypeInt8.CheckState = CheckState.Checked;
            searchTypeInt8.Name = "searchTypeInt8";
            searchTypeInt8.Size = new Size(147, 22);
            searchTypeInt8.Text = "8-bit";
            searchTypeInt8.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeInt16
            // 
            searchTypeInt16.Checked = true;
            searchTypeInt16.CheckOnClick = true;
            searchTypeInt16.CheckState = CheckState.Checked;
            searchTypeInt16.Name = "searchTypeInt16";
            searchTypeInt16.Size = new Size(147, 22);
            searchTypeInt16.Text = "16-bit";
            searchTypeInt16.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeInt32
            // 
            searchTypeInt32.Checked = true;
            searchTypeInt32.CheckOnClick = true;
            searchTypeInt32.CheckState = CheckState.Checked;
            searchTypeInt32.Name = "searchTypeInt32";
            searchTypeInt32.Size = new Size(147, 22);
            searchTypeInt32.Text = "32-bit";
            searchTypeInt32.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeInt64
            // 
            searchTypeInt64.Checked = true;
            searchTypeInt64.CheckOnClick = true;
            searchTypeInt64.CheckState = CheckState.Checked;
            searchTypeInt64.Name = "searchTypeInt64";
            searchTypeInt64.Size = new Size(147, 22);
            searchTypeInt64.Text = "64-bit";
            searchTypeInt64.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeInt128
            // 
            searchTypeInt128.Checked = true;
            searchTypeInt128.CheckOnClick = true;
            searchTypeInt128.CheckState = CheckState.Checked;
            searchTypeInt128.Name = "searchTypeInt128";
            searchTypeInt128.Size = new Size(147, 22);
            searchTypeInt128.Text = "128-bit (Lane)";
            searchTypeInt128.CheckedChanged += SearchTypeChanged;
            // 
            // searchType_GroupUnsigned
            // 
            searchType_GroupUnsigned.Checked = true;
            searchType_GroupUnsigned.CheckState = CheckState.Indeterminate;
            searchType_GroupUnsigned.DropDownItems.AddRange(new ToolStripItem[] { searchTypeUnsigned8, searchTypeUnsigned16, searchTypeUnsigned32, searchTypeUnsigned64 });
            searchType_GroupUnsigned.Name = "searchType_GroupUnsigned";
            searchType_GroupUnsigned.Size = new Size(171, 22);
            searchType_GroupUnsigned.Text = "Integer (unsigned)";
            searchType_GroupUnsigned.Click += SearchTypeGroupToggle;
            // 
            // searchTypeUnsigned8
            // 
            searchTypeUnsigned8.Checked = true;
            searchTypeUnsigned8.CheckOnClick = true;
            searchTypeUnsigned8.CheckState = CheckState.Checked;
            searchTypeUnsigned8.Name = "searchTypeUnsigned8";
            searchTypeUnsigned8.Size = new Size(105, 22);
            searchTypeUnsigned8.Text = "8-bit";
            searchTypeUnsigned8.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeUnsigned16
            // 
            searchTypeUnsigned16.Checked = true;
            searchTypeUnsigned16.CheckOnClick = true;
            searchTypeUnsigned16.CheckState = CheckState.Checked;
            searchTypeUnsigned16.Name = "searchTypeUnsigned16";
            searchTypeUnsigned16.Size = new Size(105, 22);
            searchTypeUnsigned16.Text = "16-bit";
            searchTypeUnsigned16.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeUnsigned32
            // 
            searchTypeUnsigned32.Checked = true;
            searchTypeUnsigned32.CheckOnClick = true;
            searchTypeUnsigned32.CheckState = CheckState.Checked;
            searchTypeUnsigned32.Name = "searchTypeUnsigned32";
            searchTypeUnsigned32.Size = new Size(105, 22);
            searchTypeUnsigned32.Text = "32-bit";
            searchTypeUnsigned32.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeUnsigned64
            // 
            searchTypeUnsigned64.Checked = true;
            searchTypeUnsigned64.CheckOnClick = true;
            searchTypeUnsigned64.CheckState = CheckState.Checked;
            searchTypeUnsigned64.Name = "searchTypeUnsigned64";
            searchTypeUnsigned64.Size = new Size(105, 22);
            searchTypeUnsigned64.Text = "64-bit";
            searchTypeUnsigned64.CheckedChanged += SearchTypeChanged;
            // 
            // searchType_GroupFloat
            // 
            searchType_GroupFloat.Checked = true;
            searchType_GroupFloat.CheckState = CheckState.Indeterminate;
            searchType_GroupFloat.DropDownItems.AddRange(new ToolStripItem[] { searchTypeFloat16, searchTypeBFloat16, searchTypeFloat32, searchTypeFloat64 });
            searchType_GroupFloat.Name = "searchType_GroupFloat";
            searchType_GroupFloat.Size = new Size(171, 22);
            searchType_GroupFloat.Text = "Floating-point";
            searchType_GroupFloat.Click += SearchTypeGroupToggle;
            // 
            // searchTypeFloat16
            // 
            searchTypeFloat16.Checked = true;
            searchTypeFloat16.CheckOnClick = true;
            searchTypeFloat16.CheckState = CheckState.Checked;
            searchTypeFloat16.Name = "searchTypeFloat16";
            searchTypeFloat16.Size = new Size(165, 22);
            searchTypeFloat16.Text = "Half-precision";
            searchTypeFloat16.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeBFloat16
            // 
            searchTypeBFloat16.Checked = true;
            searchTypeBFloat16.CheckOnClick = true;
            searchTypeBFloat16.CheckState = CheckState.Checked;
            searchTypeBFloat16.Name = "searchTypeBFloat16";
            searchTypeBFloat16.Size = new Size(165, 22);
            searchTypeBFloat16.Text = "Brain float16";
            searchTypeBFloat16.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeFloat32
            // 
            searchTypeFloat32.Checked = true;
            searchTypeFloat32.CheckOnClick = true;
            searchTypeFloat32.CheckState = CheckState.Checked;
            searchTypeFloat32.Name = "searchTypeFloat32";
            searchTypeFloat32.Size = new Size(165, 22);
            searchTypeFloat32.Text = "Single-precision";
            searchTypeFloat32.CheckedChanged += SearchTypeChanged;
            // 
            // searchTypeFloat64
            // 
            searchTypeFloat64.Checked = true;
            searchTypeFloat64.CheckOnClick = true;
            searchTypeFloat64.CheckState = CheckState.Checked;
            searchTypeFloat64.Name = "searchTypeFloat64";
            searchTypeFloat64.Size = new Size(165, 22);
            searchTypeFloat64.Text = "Double-precision";
            searchTypeFloat64.CheckedChanged += SearchTypeChanged;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // searchWinMenuStrip
            // 
            searchWinMenuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, optionsMenu, sizeOptionsMenu, elementTypesOptionsMenu, viewToolStripMenuItem });
            searchWinMenuStrip.Location = new Point(0, 0);
            searchWinMenuStrip.Name = "searchWinMenuStrip";
            searchWinMenuStrip.Size = new Size(1231, 24);
            searchWinMenuStrip.TabIndex = 13;
            searchWinMenuStrip.Text = "menuStrip1";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1231, 714);
            Controls.Add(searchWinMenuStrip);
            Controls.Add(baseLayoutPannel);
            MainMenuStrip = searchWinMenuStrip;
            Name = "MainPage";
            Text = "Intel Intrinsics";
            ((System.ComponentModel.ISupportInitialize)IntrinsicsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)intrincItemBindingSource).EndInit();
            SSE_family_items.ResumeLayout(false);
            SSE_family_items.PerformLayout();
            extentionsPannel.ResumeLayout(false);
            extentionsPannel.PerformLayout();
            AVX512_family_items.ResumeLayout(false);
            AVX512_family_items.PerformLayout();
            AMX_family_items.ResumeLayout(false);
            AMX_family_items.PerformLayout();
            AVX_family_items.ResumeLayout(false);
            AVX_family_items.PerformLayout();
            baseLayoutPannel.ResumeLayout(false);
            searchBoxSubPannel.ResumeLayout(false);
            searchBoxSubPannel.PerformLayout();
            searchWinMenuStrip.ResumeLayout(false);
            searchWinMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView IntrinsicsList;
        private BindingSource intrincItemBindingSource;
        private CheckBox MMX_box;
        private CheckBox AVX_box;
        private TextBox searchBox;
        private Label searchPlaceHolder;
        private CheckBox AMX_ALL_box;
        private CheckBox AVX_ALL_box;
        private CheckBox SSE_ALL_box;
        private TableLayoutPanel SSE_family_items;
        private CheckBox SSE4_2_box;
        private CheckBox SSE4_1_box;
        private CheckBox SSE_box;
        private CheckBox SSE3_box;
        private CheckBox SSSE3_box;
        private CheckBox SSE2_box;
        private TableLayoutPanel extentionsPannel;
        private TableLayoutPanel AVX_family_items;
        private CheckBox AVX512_ALL_box;
        private CheckBox AVX_IFMA_box;
        private CheckBox AVX_NE_CONVERT_box;
        private CheckBox AVX_VNNI_INT8_box;
        private CheckBox AVX_VNNI_box;
        private CheckBox AVX2_box;
        private CheckBox FMA_box;
        private CheckBox F16C_box;
        private CheckBox AVX_VNNI_INT16_box;
        private CheckBox SM4_box;
        private CheckBox SM3_box;
        private CheckBox SHA512_box;
        private TableLayoutPanel AMX_family_items;
        private CheckBox AMX_BF16_box;
        private CheckBox AMX_COMPLEX_box;
        private CheckBox AMX_FP16_box;
        private CheckBox AMX_TILE_box;
        private CheckBox AMX_INT8_box;
        private CheckBox UNKNOWN_box;
        private DataGridViewTextBoxColumn returnTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intrincNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn instructionDataGridViewTextBoxColumn;
        private TableLayoutPanel baseLayoutPannel;
        private Panel searchBoxSubPannel;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem browseForDataFile;
        private ToolStripMenuItem infoDialogMenuCheck;
        private ToolStripMenuItem optionsMenu;
        private ToolStripMenuItem searchIncludeInstruction;
        private ToolStripMenuItem searchIncludeFuncName;
        private ToolStripMenuItem searchIncludeDescription;
        private ToolStripMenuItem searchIncludeReturnType;
        private ToolStripMenuItem searchIncludeArgType;
        private ToolStripMenuItem searchIncludeMask;
        private ToolStripMenuItem sizeOptionsMenu;
        private ToolStripMenuItem searchSizeNonvec;
        private ToolStripMenuItem searchSize64;
        private ToolStripMenuItem searchSize128;
        private ToolStripMenuItem searchSize256;
        private ToolStripMenuItem searchSize512;
        private ToolStripMenuItem searchSizeTile;
        private ToolStripMenuItem elementTypesOptionsMenu;
        private ToolStripMenuItem searchTypeNonVec;
        private ToolStripMenuItem searchType_GroupInt;
        private ToolStripMenuItem searchTypeInt8;
        private ToolStripMenuItem searchTypeInt16;
        private ToolStripMenuItem searchTypeInt32;
        private ToolStripMenuItem searchTypeInt64;
        private ToolStripMenuItem searchTypeInt128;
        private ToolStripMenuItem searchType_GroupUnsigned;
        private ToolStripMenuItem searchTypeUnsigned8;
        private ToolStripMenuItem searchTypeUnsigned16;
        private ToolStripMenuItem searchTypeUnsigned32;
        private ToolStripMenuItem searchTypeUnsigned64;
        private ToolStripMenuItem searchType_GroupFloat;
        private ToolStripMenuItem searchTypeFloat16;
        private ToolStripMenuItem searchTypeBFloat16;
        private ToolStripMenuItem searchTypeFloat32;
        private ToolStripMenuItem searchTypeFloat64;
        private ToolStripMenuItem viewToolStripMenuItem;
        private MenuStrip searchWinMenuStrip;
        private ToolStripMenuItem searchHasSmallDelay;
        private CheckBox Other_box;
        private TableLayoutPanel AVX512_family_items;
        private CheckBox AVX512VL_box;
        private CheckBox AVX512FP16_box;
        private CheckBox AVX512VP2INTERSECT_box;
        private CheckBox AVX512VNNI_box;
        private CheckBox AVX512VBMI2_box;
        private CheckBox AVX512VBMI_box;
        private CheckBox AVX512BITALG_box;
        private CheckBox AVX512BF16_box;
        private CheckBox AVX512VPOPCNTDQ_box;
        private CheckBox AVX512DQ_box;
        private CheckBox AVX512CD_box;
        private CheckBox AVX512BW_box;
        private CheckBox AVX512F_box;
        private CheckBox AVX512IFMA52_box;
    }
}
