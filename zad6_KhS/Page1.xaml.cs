using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad6_KhS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 :CarouselPage
    {
        public Page1 ()
        {
            InitializeComponent();
        }
        void Button_Clicked (System.Object sender, System.EventArgs e)
        {
            try
            {
                string text = "Выбран " + vid.Items[vid.SelectedIndex];
                itog.Text = text;
            } catch
            {
            }
            try
            {
                double[] array = new double[7];
                array[0] = sl1.Value;
                array[1] = sl2.Value;
                array[2] = sl3.Value;
                array[3] = sl4.Value;
                array[4] = sl5.Value;
                array[5] = sl6.Value;
                array[6] = sl7.Value;

                slider.Text = "Максимальное значение из слайдера:" + Convert.ToString(array.Max());

            } catch
            {
                itog.Text = "Здесь будет показываться, какой вариант списка выбран";
                slider.Text = "Здесь будет показываться, максимальное значение из слайдера";
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}