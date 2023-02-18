using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EnumToComboboxExample
{
	public class ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		public void OnPropertyChanged([CallerMemberName]string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}


		private TestEnum _selectedValue;

		public TestEnum SelectedValue
		{
			get { return _selectedValue; }
			set { _selectedValue = value; OnPropertyChanged(nameof(SelectedValue)); }
		}


		public ViewModel()
		{
			_selectedValue = TestEnum.Value01;
		}








	}
}
