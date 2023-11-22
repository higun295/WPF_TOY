using System.Windows;
using System.Windows.Controls;

namespace WPF_Toy.Forms.UI.Units
{
    public class ShakableTextBox : TextBox
    {
        static ShakableTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ShakableTextBox), new FrameworkPropertyMetadata(typeof(ShakableTextBox)));
        }
    }
}