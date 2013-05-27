﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topics.Radical.ComponentModel.Messaging;
using Topics.Radical.Messaging;
using Topics.Radical.Windows.Presentation.ComponentModel;
using WpfMvvmUICompositionInAction.Presentation;

namespace WpfMvvmUICompositionInAction.Messaging.Handlers
{
    class OpenCommonAppMessageHandler : AbstractMessageHandler<OpenCommonAppMessage>, INeedSafeSubscription
    {
        readonly IViewResolver viewResolver;
        readonly IRegionService regionService;

        public OpenCommonAppMessageHandler(IViewResolver viewResolver, IRegionService regionService)
        {
            this.viewResolver = viewResolver;
            this.regionService = regionService;
        }

        public override void Handle(object sender, OpenCommonAppMessage message)
        {
            this.regionService.GetKnownRegionManager<MainView>()
                .GetRegion<IContentRegion>(ShellKnownRegions.MainContentRegion)
                .Content = this.viewResolver.GetView<CommonAppView>();
        }
    }
}
