using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMakingStudio.Tabs
{
    public partial class CodeTab : Form
    {
        public CodeTab()
        {
            InitializeComponent();
            
            CommandStyle = new TextStyle(DarkBlue, null, FontStyle.Italic);
            SelectorsStyle = new TextStyle(DarkGreen, null, FontStyle.Bold);
            NumbersStyle = new TextStyle(DarkPurple, null, FontStyle.Regular);
            AdditionStyle = new TextStyle(Gray, null, FontStyle.Italic);
            BracketsStyle = new TextStyle(DarkOrange, null, FontStyle.Regular);

        }


        Style SelectorsStyle;
        Style CommandStyle;
        Style NumbersStyle;
        Style AdditionStyle;
        Style BracketsStyle;

        Brush DarkGreen = new SolidBrush(Color.FromArgb(255, 39, 174, 96));
        Brush DarkBlue = new SolidBrush(Color.FromArgb(255, 41, 128, 185));
        Brush DarkPurple = new SolidBrush(Color.FromArgb(255, 142, 68, 173));
        Brush DarkOrange = new SolidBrush(Color.FromArgb(255, 211, 84, 0));
        Brush Gray = new SolidBrush(Color.Gray);



        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {

            //clear style of changed range
            e.ChangedRange.ClearStyle(SelectorsStyle);
            e.ChangedRange.ClearStyle(CommandStyle);
            e.ChangedRange.ClearStyle(NumbersStyle);
            e.ChangedRange.ClearStyle(AdditionStyle);
            e.ChangedRange.ClearStyle(BracketsStyle);



            //comment highlighting
            e.ChangedRange.SetStyle(SelectorsStyle, @"(@a)|(@p)|(@e)|(@r)|(@s)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(CommandStyle, @"(\/)\w+", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(NumbersStyle, @"(\d)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(AdditionStyle, @"(#.*)|(_region)|(_endregion)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(BracketsStyle, @"(\{)|(\})|(\[)|(\])|(\()|(\))", RegexOptions.Multiline);



            //clear folding markers of changed range
            e.ChangedRange.ClearFoldingMarkers();
            //set folding markers
            e.ChangedRange.SetFoldingMarkers(@"_region\b", @"_endregion\b");

        }
    }
}
