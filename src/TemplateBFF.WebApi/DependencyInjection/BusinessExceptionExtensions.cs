﻿using Microsoft.Extensions.DependencyInjection;
using TemplateBFF.Filters;

namespace TemplateBFF.DependencyInjection
{
    public static class BusinessExceptionExtensions
    {
        public static IServiceCollection AddBusinessExceptionFilter(this IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(BusinessExceptionFilter));
            });

            return services;
        }
    }
}