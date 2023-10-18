namespace Composite_Pattern
{
    using System;
    using System.Collections.Generic;

    public abstract class UIElement
    {
        public abstract string Draw();
    }

    public class Button : UIElement
    {
        public override string Draw()
        {
            return "Button";
        }
    }

    public class TextField : UIElement
    {
        public override string Draw()
        {
            return "Text Field";
        }
    }

    public class Panel : UIElement
    {
        private List<UIElement> elements = new List<UIElement>();

        public void AddElement(UIElement element)
        {
            elements.Add(element);
        }

        public override string Draw()
        {
            string result = "Panel with ";
            foreach (UIElement element in elements)
            {
                result += element.Draw() + " + ";
            }
            return result.Substring(0, result.Length - 3);
        }
    }

    class Program
    {
        static void Main()
        {
            UIElement button = new Button();
            UIElement textField = new TextField();
            Panel panel = new Panel();

            panel.AddElement(button);
            panel.AddElement(textField);

            Console.WriteLine(button.Draw());        // Output: Button
            Console.WriteLine(textField.Draw());     // Output: Text Field
            Console.WriteLine(panel.Draw());          // Output: Panel with Button + Text Field
        }
    }

}