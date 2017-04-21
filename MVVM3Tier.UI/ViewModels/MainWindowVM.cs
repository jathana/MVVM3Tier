using MVVM3Tier.UI.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM3Tier.UI.ViewModels
{
   public class MainWindowVM : NotifyUIBase
   {
      private ICommand _changePageCommand;
      private IPageViewModel _currentPageViewModel;
      private List<IPageViewModel> _pageViewModels;


      public MainWindowVM()
      {
         PageViewModels.Add(new CustomersVM());
         PageViewModels.Add(new CountriesVM());
         CurrentPageViewModel = PageViewModels[0];
      }

      #region properties
      public List<IPageViewModel> PageViewModels
      {
         get
         {
            if (_pageViewModels == null)
               _pageViewModels = new List<IPageViewModel>();
            return _pageViewModels;
         }
      }

      public IPageViewModel CurrentPageViewModel
      {
         get
         {
            return _currentPageViewModel;
         }
         set
         {
            if(_currentPageViewModel != value)
            {
               _currentPageViewModel = value;
               RaisePropertyChanged();
            }
         }
      }
      #endregion

      #region Commands
      public ICommand ChangePageCommand
      {
         get
         {
            if(_changePageCommand == null)
            {
               _changePageCommand = new RelayCommand(p => ChangeViewModel((IPageViewModel)p), p => p is IPageViewModel);
            }
            return _changePageCommand;
         }
      }
      #endregion

      #region Methods
      private void ChangeViewModel(IPageViewModel viewModel)
      {
         if (!PageViewModels.Contains(viewModel))
         {
            PageViewModels.Add(viewModel);
         }
         CurrentPageViewModel = PageViewModels.FirstOrDefault(vm => vm == viewModel);
      }
      #endregion


   }
}
