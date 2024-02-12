using Avalonia.Input;
using ReactiveUI;
using System.Collections.Generic;

namespace AvaloniaDragDrop_Demo.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
		private string? _centerText;

		public string? CenterText
		{
			get => _centerText;
			set => this.RaiseAndSetIfChanged(ref _centerText, value);
		}

		public MainWindowViewModel()
		{
			CenterText = "Please drag and drop here";
		}

		public void DropsFiles(IDataObject data)
		{
			if(data.GetText() != null)
			{
				CenterText = data.GetText();
				return;
			}
			else
			{
				if(data.GetFiles != null)
				{
					List<string> path = new();
					foreach (var item in data.GetFiles())
					{
						path.Add(item.Path.ToString());
					}
					if(path.Count > 0)
					{
						CenterText = string.Join("\n", path);
					}
				}
					
            }

		}
	}
}
