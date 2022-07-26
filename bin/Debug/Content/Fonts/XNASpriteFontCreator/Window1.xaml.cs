using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Threading;

namespace XNASpriteFontCreator
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DispatcherTimer ticker;
        FileStream stream;
        StreamWriter writer;

        public Window1()
        {
            InitializeComponent();

            stream = new FileStream("spritefont.spritefont", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            writer = new StreamWriter(stream);

            foreach (FontFamily font in Fonts.SystemFontFamilies)
            {
                comboBox1.Items.Add(font);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ticker = new DispatcherTimer();
            ticker.Interval = TimeSpan.FromMilliseconds(1);
            ticker.Tick += ticker1_Tick;
            ticker.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            writer.Close();
            File.Delete("spritefont.spritefont");
            stream = new FileStream("spritefont.spritefont", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            writer = new StreamWriter(stream);
            writer.WriteLine("<?xml version='1.0' encoding='utf-8'?>");
            writer.WriteLine("<XnaContent xmlns:Graphics='Microsoft.Xna.Framework.Content.Pipeline.Graphics'>");
            writer.WriteLine("<Asset Type='Graphics:FontDescription'>");
            writer.WriteLine("<FontName>" + comboBox1.SelectedValue + "</FontName>");
            writer.WriteLine("<Size>" + textBox1.Text + "</Size>");
            writer.WriteLine("<Spacing>" + textBox2.Text + "</Spacing>");
            if (comboBox2.SelectedIndex == 0)
            {
                writer.WriteLine("<UseKerning>true</UseKerning>");
            }
            else
            {
                writer.WriteLine("<UseKerning>false</UseKerning>");
            }
            //Set the style element based on the check box input
            if (checkBox1.IsChecked == true)
            {
                if (checkBox2.IsChecked == true)
                {
                    writer.WriteLine("<Style>Bold, Italic</Style>");
                }
                else
                {
                    writer.WriteLine("<Style>Bold</Style>");
                }
            }
            else if (checkBox2.IsChecked == true)
            {
                writer.WriteLine("<Style>Italic</Style>");
            }
            else
            {
                writer.WriteLine("<Style>Regular</Style>");
            }
            writer.WriteLine("<CharacterRegions>");
            writer.WriteLine("<CharacterRegion>");
            writer.WriteLine("<Start>&#32;</Start>");
            writer.WriteLine("<End>&#126;</End>");
            writer.WriteLine("</CharacterRegion>");
            writer.WriteLine("</CharacterRegions>");
            writer.WriteLine("</Asset>");
            writer.WriteLine("</XnaContent>");
            writer.Flush();
            stream.Flush();
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        void updateText()
        {
            label5.FontFamily = (FontFamily)comboBox1.SelectedValue;
            try
            {
                label5.FontSize = double.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
            }
            if (checkBox1.IsChecked == true)
            {
                label5.FontWeight = FontWeights.Bold;
            }
            else
            {
                label5.FontWeight = FontWeights.Normal;
            }
            if (checkBox2.IsChecked == true)
            {
                label5.FontStyle = FontStyles.Italic;
            }
            else
            {
                label5.FontStyle = FontStyles.Normal;
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ticker1_Tick(object sender, EventArgs e)
        {
            updateText();
        }
    }
}
