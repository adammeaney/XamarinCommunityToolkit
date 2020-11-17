using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.CommunityToolkit.Sample.Pages.Views.TabView
{
	public partial class ContentChangingTabsPage
	{
		public ContentChangingTabsPage()
		{
			InitializeComponent();
		}

		private void OnChange(object sender, EventArgs e)
		{
			MyTabView.TabItems.First().Content = new Grid
			{
				Children = { new Label { Text = DateTime.Now.ToLongTimeString() } }
			};
		}
	}
}