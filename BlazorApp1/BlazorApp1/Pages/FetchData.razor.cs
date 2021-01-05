using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    partial class FetchData : ComponentBase
    {
        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {   
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
