using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Setup.WPF.ViewModels
{
    public class PageTwoViewModel : Screen
    {

        protected override async Task OnDeactivateAsync(bool close, CancellationToken cancellationToken)
        {
            await _eventAggregator.PublishOnUIThreadAsync("Closing");
        }

        protected override async Task OnActivateAsync(CancellationToken cancellationToken)
        {
            await _eventAggregator.PublishOnUIThreadAsync("Loading");
            await Task.Delay(2000);
            await _eventAggregator.PublishOnUIThreadAsync(string.Empty);

        }


    }
}
