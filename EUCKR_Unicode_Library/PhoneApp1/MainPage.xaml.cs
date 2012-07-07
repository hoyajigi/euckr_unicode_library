using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Text;
using System.Windows.Shapes;
using EUCKR_Unicode_Library;
using Microsoft.Phone.Controls;

namespace PhoneApp1
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();
		}

		private void button1_Click(Object sender, RoutedEventArgs e)
		{
			Byte[] euckrBytes = EUCKR_Unicode_Converter.GetEucKRString(textBox1.Text);

			StringBuilder stringBuilder = new StringBuilder();

			foreach (Byte b in euckrBytes)
			{
				stringBuilder.Append(b.ToString() + ",");
			}

			textBox1.Text = stringBuilder.ToString();
		}
	}
}