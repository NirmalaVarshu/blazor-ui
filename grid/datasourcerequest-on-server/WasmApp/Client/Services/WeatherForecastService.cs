﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WasmApp.Shared;
using Microsoft.AspNetCore.Components;
// these two using statements provide the data source operations
using Telerik.DataSource;
using Telerik.DataSource.Extensions;

namespace WasmApp.Services
{
    public class WeatherForecastService
    {
        [Inject]
        private HttpClient Http { get; set; }

        public WeatherForecastService(HttpClient client)
        {
            Http = client;
        }

        public async Task<DataSourceResult> GetForecastListAsync(DataSourceRequest gridRequest)
        {
            DataSourceResult result = await Http.PostJsonAsync<DataSourceResult>("WeatherForecast", gridRequest);

            return result;
        }

        // for brevity, CUD operations are not implemented, only Read
    }
}