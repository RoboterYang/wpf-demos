#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainstorming.ViewModel
{
    public class MessageBoxWindowViewModel
    {
        public MessageBoxWindowViewModel(BrainstormingBuilderVM diagramBuilderVM)
        {
            DiagramBuilderVM = diagramBuilderVM;
        }
        /// <summary>
        /// Gets applications diagram builder vm.
        /// </summary>
        public BrainstormingBuilderVM DiagramBuilderVM { get; private set; }
        DelegateCommand<object> okCommand;
        public DelegateCommand<object> OkCommand
        {
            get
            {
                return okCommand ??
                    (okCommand = new DelegateCommand<object>(OkCommandExecute));
            }
        }

        /// <summary>
        /// Method will execute when OkCommand executed
        /// </summary>
        private void OkCommandExecute(object obj)
        {
            DiagramBuilderVM.OpenCloseWindowBehavior.OpenMessageBoxWindow = false;
        }
    }
}
