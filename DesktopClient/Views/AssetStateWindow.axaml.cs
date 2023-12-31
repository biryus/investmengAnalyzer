using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using InvestmentAnalyzer.DesktopClient.ViewModels;

namespace InvestmentAnalyzer.DesktopClient.Views {
	public partial class AssetStateWindow : ReactiveWindow<AssetStateWindowViewModel> {
		public AssetStateWindow() {
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		void InitializeComponent() {
			AvaloniaXamlLoader.Load(this);
		}
	}
}