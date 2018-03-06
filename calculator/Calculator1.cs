using System;
using Xamarin.Forms;
namespace calculator
{
    public class Calculator1 : ContentPage
    {
        
        public Calculator1()
        {
            
            
            var entry1 = new Entry
            {
                Placeholder = "Enter a number "
            };

            var entry2 = new Entry
            {
                Placeholder = "Enter a number"
            };

            var entry3 = new Entry
            {
                Placeholder = " ",
            };



            var button1 = new Button()
            {
                Text = "addition",
              
                 

            };

            var button2 = new Button
            {
                Text = "subtraction"

            };

            var button3 = new Button
            {
                Text = "Division"

            };
            var button4 = new Button
            {
                Text = "Multiplication"

            };

            button1.Clicked += (sender, e) =>
            {
                double x, y;
                if (double.TryParse(entry1.Text, out x) && double.TryParse(entry2.Text, out y))
                {

                    entry3.Text = "Result: " + (x + y).ToString();

                }
                else
                {
                    entry3.Text = "Enter a number";
                }


            };
          
            button2.Clicked += (sender, e) =>
            {
                double x, y;
                if (double.TryParse(entry1.Text, out x) && double.TryParse(entry2.Text, out y))
                {

                    entry3.Text = "Result: " + (x - y).ToString();

                }
                else
                {
                    entry3.Text = "Enter a number";
                }
            };
            button3.Clicked += (sender, e) =>
            {
                double x, y;
                if (double.TryParse(entry1.Text, out x) && double.TryParse(entry2.Text, out y))
                {
                   if(y == 0)
                    {
                        entry3.Text = "The denominator cannot be 0";

                    }
                    else
                    {
                        entry3.Text = "Result: " + (x / y).ToString();

                    }
                }
                else
                {
                    entry3.Text = "Enter a number";
                }


              
            };
            button4.Clicked += (sender, e) =>
            {
                double x, y;
                if (double.TryParse(entry1.Text, out x) && double.TryParse(entry2.Text, out y))
                {

                    entry3.Text = "Result: " + (x * y).ToString();
                  
                }
                else
                {
                    entry3.Text = "Enter a number";
                }
            };

            Content = new StackLayout
            {
                Padding = 30,
                WidthRequest= 100,
                HeightRequest= 50,
                Spacing = 10,
                Children = { entry1, entry2, entry3, button1, button2, button3, button4 }
            };




        }
    }
}

