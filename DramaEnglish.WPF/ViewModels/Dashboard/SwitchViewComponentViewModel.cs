﻿using DramaEnglish.WPF.ViewModels;
using Prism.Events;
using Prism.Ioc;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace DramaEnglish.UserInterface.ViewModels.Dashboard
{
    public class SwitchViewComponentViewModel : ViewModelBase
    {

        #region 字段属性

        #endregion

        #region 构造函数
        public SwitchViewComponentViewModel(IContainerExtension container, IRegionManager regionManager, IDialogService dialogService, IEventAggregator ea)
        : base(container, regionManager, dialogService, ea)
        {

        }
        #endregion

        #region 命令

        #endregion

        #region 方法函数

        #endregion

    }
}
