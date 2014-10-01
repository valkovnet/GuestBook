using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GuestBook.Controls
{
    [TemplatePart(Name = PART_ImagePart, Type = typeof(Image))]
    [TemplatePart(Name = PART_BorderPart, Type = typeof(Border))]    
    public class CaptchaControl : Control
    {
        private const string PART_ImagePart = "PART_ImagePart";

        private const string PART_BorderPart = "PART_BorderPart";

        private static readonly char[] charArray = "ABCEFGHJKLMNPRSTUVWXYZ2346789".ToCharArray();

        private static readonly Random random = new Random();        

        private Image _image;

        public CaptchaControl()
        {
            DefaultStyleKey = typeof(CaptchaControl);
            MouseLeftButtonDown += (sender, e) => GenerateCapta();
        }

        public static readonly DependencyProperty CaptaValueProperty =
            DependencyProperty.Register("CaptaValue", typeof(string), typeof(CaptchaControl), new PropertyMetadata(String.Empty));

        public string CaptaValue
        {
            get { return (string)GetValue(CaptaValueProperty); }
            set { SetValue(CaptaValueProperty, value); }
        }       
 
        private void GenerateCapta()
        {
            var captcha = new char[6];
            for (int i = 0; i < captcha.Length; i++)
            {
                captcha[i] = charArray[random.Next(charArray.Length)];
            }

            CaptaValue = new string(captcha);
            if (this._image != null)
            {
                this._image.Source = GenerateBitmap();
            }
        }

        private WriteableBitmap GenerateBitmap()
        {            
            var textBlock = new TextBlock
                {
                    Height = 25,
                    Width = 60,
                    Text = CaptaValue,
                    FontSize = 12,
                    Padding = new Thickness(5, 5, 5, 5),
                    Foreground = new SolidColorBrush(Colors.White)
                };
            
            var bitmap = new WriteableBitmap(60, 25);
            var tr = new SkewTransform { AngleX = -5, AngleY = -10 };
            bitmap.Render(textBlock, tr);            
            bitmap.Invalidate();
            return bitmap;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this._image = GetTemplateChild(PART_ImagePart) as Image;            
            GenerateCapta();            
        }        
    }
}
