using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImproveIntelInstrincs
{
    public class CreateIntrinsicInfoWindow : Form
    {
        private static readonly Font headerFont = new("Courier New", 8);
        private static readonly Font signatureFont = new("intel-clear", 11);
        private static readonly Font descriptionFont = new("Arial", 10);
        private static readonly Font subTitleFont = new("Arial", 12, FontStyle.Bold);
        private static readonly Font operationFont = new("Courier New", 10);

        private static readonly Padding textBoxMargin = new(15, 0, 150, 10);

        private RichTextBox GetFunctionSignature(IntrincItem intrinsic, Font fontStyle)
        {
            RichTextBox rtbFunctionSignature = new RichTextBox
            {
                Location = new Point(10, 30),
                Size = new Size(800, 20),
                Font = fontStyle,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor // Match form background
            };

            var typeColor = Color.DarkBlue;
            var normalColor = Color.Black;
            var variableColor = Color.DarkGreen;

            // Add text with different colors
            string nonArgFull = $"{intrinsic.ReturnType} {intrinsic.IntrincName} ";
            rtbFunctionSignature.AppendText(nonArgFull);

            rtbFunctionSignature.Select(nonArgFull.IndexOf(intrinsic.ReturnType), intrinsic.ReturnType.Length);
            rtbFunctionSignature.SelectionColor = typeColor;

            rtbFunctionSignature.Select(nonArgFull.IndexOf(intrinsic.IntrincName), intrinsic.IntrincName.Length);
            rtbFunctionSignature.SelectionColor = normalColor;


            rtbFunctionSignature.AppendText("(");
            int curSelectPos = nonArgFull.Length + 1;

            foreach (var funcArg in intrinsic.Arguments)
            {

                rtbFunctionSignature.AppendText(funcArg.Type + " ");
                rtbFunctionSignature.Select(curSelectPos, funcArg.Type.Length);
                rtbFunctionSignature.SelectionColor = typeColor;
                curSelectPos += funcArg.Type.Length + 1;

                rtbFunctionSignature.AppendText(funcArg.Name + ", ");
                rtbFunctionSignature.Select(curSelectPos, funcArg.Name.Length);
                rtbFunctionSignature.SelectionColor = variableColor;
                curSelectPos += funcArg.Name.Length + 2;
            }

            if (intrinsic.Arguments.Any())
            {
                rtbFunctionSignature.Select(curSelectPos - 2, 2);
                rtbFunctionSignature.SelectionColor = normalColor;
                rtbFunctionSignature.SelectedText = ")"; // Remove the last comma and space
            }
            else
            {
                rtbFunctionSignature.AppendText(")");
            }
            rtbFunctionSignature.Select(0, 0); // Deselect text

            return rtbFunctionSignature;
        }

        private Label GetSubTitle(string titleText)
        {
            return new Label
            {
                Text = titleText,
                Font = subTitleFont,
                AutoSize = true
            };
        }



        private RichTextBox GetTextBox(string textBoxText, Font fontStyle, Color backGroundColor)
        {
            return new RichTextBox
            {
                Text = textBoxText,
                Size = new Size(this.Width - 50, 130),
                WordWrap = true,
                ReadOnly = true,
                Font = fontStyle,
                Margin = textBoxMargin,
                BorderStyle = BorderStyle.None,
                BackColor = backGroundColor
            };
        }

        private Label GetHeaderText(string headerText)
        {
            return new Label
            {
                Text = headerText,
                Font = headerFont,
                Padding = new Padding(10, 0, 0, 10),
                AutoSize = true
            };
        }

        public CreateIntrinsicInfoWindow(IntrincItem intrinsic)
        {
            // Window properties
            this.Text = intrinsic.IntrincName;
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;




            List<Control> controls =
            [
                GetSubTitle("Intrinsic"),
                GetFunctionSignature(intrinsic, signatureFont),
                GetHeaderText($"Instruction: {intrinsic.Instruction}"),
                GetHeaderText($"Extention: {intrinsic.Extention.ToString()}"),
                //GetHeaderText($"Element type: {intrinsic.ElementType}"),

                GetSubTitle("Description"),
                GetTextBox(intrinsic.Description, descriptionFont, this.BackColor),

                GetSubTitle("Operation"),
                GetTextBox(intrinsic.Pseudocode, operationFont, Color.Gainsboro),

                new Button {  Text = "OK",  DialogResult = DialogResult.OK  }
            ];



            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = controls.Count,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Fill // Fill the form
            };

            for (int i = 0; i < tableLayout.RowCount; i++)
            {
                tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            tableLayout.Controls.AddRange(controls.ToArray());
            this.Controls.AddRange(new Control[] { tableLayout });
        }
    }
}
