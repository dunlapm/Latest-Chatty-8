﻿using Latest_Chatty_8.Shared;
using Latest_Chatty_8.Shared.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Latest_Chatty_8.Shared.Converters
{
	public class PostCategoryConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			PostCategory pc = (PostCategory)value;
			switch (pc)
			{
				case PostCategory.offtopic:
					return new SolidColorBrush(Color.FromArgb(0xff, 244, 244, 3));
				case PostCategory.stupid:
					return new SolidColorBrush(Color.FromArgb(0xff, 137, 190, 64));
				case PostCategory.nws:
					return new SolidColorBrush(Color.FromArgb(0xff, 255, 0, 0));
				case PostCategory.political:
					return new SolidColorBrush(Color.FromArgb(0xff, 238, 147, 36));
				case PostCategory.informative:
				case PostCategory.newsarticle:
					return new SolidColorBrush(Color.FromArgb(0xff, 71, 169, 215));

				//return new SolidColorBrush(Color.FromArgb(0xff, 0, 68, 255));
				default:
					return new SolidColorBrush(Color.FromArgb(0xff, 0xB0, 0xB0, 0xB0));
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}