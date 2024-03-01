﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Setup.WPF.Views
{
    /// <summary>
    /// Interaction logic for PageTwoView.xaml
    /// </summary>
    public partial class PageTwoView : UserControl
    {

        private IEventAggregator _eventAggregator;
        public PageTwoView(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            _eventAggregator = eventAggregator;
        }
    }
}
