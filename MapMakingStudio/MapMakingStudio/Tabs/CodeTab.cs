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
            IDsStyle = new TextStyle(SunFlower, null, FontStyle.Regular);
            specialWordStyle = new TextStyle(Red, null, FontStyle.Regular);

            fastColoredTextBox1.Size = Size;


        }


        Style SelectorsStyle;
        Style CommandStyle;
        Style NumbersStyle;
        Style AdditionStyle;
        Style BracketsStyle;
        Style IDsStyle;
        Style specialWordStyle;



        Brush DarkGreen = new SolidBrush(Color.FromArgb(255, 39, 174, 96));
        Brush DarkBlue = new SolidBrush(Color.FromArgb(255, 41, 128, 185));
        Brush DarkPurple = new SolidBrush(Color.FromArgb(255, 142, 68, 173));
        Brush DarkOrange = new SolidBrush(Color.FromArgb(255, 211, 84, 0));
        Brush SunFlower = new SolidBrush(Color.FromArgb(255, 241, 196, 15));
        Brush Red = new SolidBrush(Color.FromArgb(255, 231, 76, 60));
        Brush Gray = new SolidBrush(Color.Gray);

        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {

            //clear style of changed range
            e.ChangedRange.ClearStyle(SelectorsStyle);
            e.ChangedRange.ClearStyle(CommandStyle);
            e.ChangedRange.ClearStyle(NumbersStyle);
            e.ChangedRange.ClearStyle(AdditionStyle);
            e.ChangedRange.ClearStyle(BracketsStyle);
            e.ChangedRange.ClearStyle(IDsStyle);
            e.ChangedRange.ClearStyle(specialWordStyle);



            //comment highlighting
            e.ChangedRange.SetStyle(SelectorsStyle, @"(@a)|(@p)|(@e)|(@r)|(@s)|(\,)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(CommandStyle, @"(\/)\w+", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(NumbersStyle, @"((\d)|(\-))", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(AdditionStyle, @"(#.*)|(_region)|(_endregion)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(BracketsStyle, @"(\{)|(\})|(\[)|(\])|(\()|(\)|(\=))", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(IDsStyle, @"(\w+\:\w+)|\w+_\w+", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(specialWordStyle, @"((detect)|(day)|(night)|(set)|(true)|(false)|(replace)|(destroy)|(keep)|(\~)|(\bc)|(\bm)|(\br)|(\brm)|(\brxm)|(\bry)|(\bx)|(\by)|(\bz)|(\bdx)|(\bdy)|(\bdz)|(\bl)|(type)|(tag)|(name)|(team))", RegexOptions.Multiline);



            //clear folding markers of changed range
            e.ChangedRange.ClearFoldingMarkers();
            //set folding markers
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");

        }
    }
}
