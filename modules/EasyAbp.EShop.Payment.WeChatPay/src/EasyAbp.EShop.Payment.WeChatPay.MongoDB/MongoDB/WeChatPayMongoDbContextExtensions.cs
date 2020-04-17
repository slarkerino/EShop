﻿using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace EasyAbp.EShop.Payment.WeChatPay.MongoDB
{
    public static class WeChatPayMongoDbContextExtensions
    {
        public static void ConfigureWeChatPay(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new WeChatPayMongoModelBuilderConfigurationOptions(
                WeChatPayDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}