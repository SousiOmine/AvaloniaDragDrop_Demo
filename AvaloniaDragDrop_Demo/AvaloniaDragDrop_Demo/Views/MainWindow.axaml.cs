using Avalonia.Controls;
using Avalonia.Input;
using AvaloniaDragDrop_Demo.ViewModels;

namespace AvaloniaDragDrop_Demo.Views
{
	public partial class MainWindow : Window
	{
		private MainWindowViewModel VM
		{
			get { return this.DataContext as MainWindowViewModel; }
		}

		public MainWindow()
		{
			InitializeComponent();
			AddHandler(DragDrop.DropEvent, DropFile);
		}

		private void DropFile(object? sender, DragEventArgs e)
		{
			var dropData = e.Data;
			this.VM.DropsFiles(dropData);
		}
	}
}