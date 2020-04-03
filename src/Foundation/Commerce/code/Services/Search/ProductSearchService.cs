﻿//    Copyright 2020 EPAM Systems, Inc.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

namespace Wooli.Foundation.Commerce.Services.Search
{
    using Base.Models;

    using Builders.Search;

    using Connect.Models.Catalog;
    using Connect.Providers.Search;
    using Connect.Services.Search;

    using DependencyInjection;

    using Mappers.Search;

    using Models.Entities.Search;

    using Sitecore.Diagnostics;

    using Connect = Connect.Models.Search;

    [Service(typeof(IProductSearchService), Lifetime = Lifetime.Singleton)]
    public class ProductSearchService : IProductSearchService
    {
        private readonly ISearchService searchManager;

        private readonly ISearchMapper searchMapper;

        private readonly ISearchOptionsBuilder searchOptionsBuilder;

        private readonly ISearchSettingsProvider searchSettingsProvider;

        public ProductSearchService(
            ISearchSettingsProvider searchSettingsProvider,
            ISearchOptionsBuilder searchOptionsBuilder,
            ISearchService searchManager,
            ISearchMapper searchMapper)
        {
            Assert.ArgumentNotNull(searchSettingsProvider, nameof(searchSettingsProvider));
            Assert.ArgumentNotNull(searchOptionsBuilder, nameof(searchOptionsBuilder));
            Assert.ArgumentNotNull(searchManager, nameof(searchManager));
            Assert.ArgumentNotNull(searchMapper, nameof(searchMapper));

            this.searchSettingsProvider = searchSettingsProvider;
            this.searchOptionsBuilder = searchOptionsBuilder;
            this.searchManager = searchManager;
            this.searchMapper = searchMapper;
        }

        public Result<ProductSearchResults> GetProducts(ProductSearchOptions productSearchOptions)
        {
            Assert.ArgumentNotNull(productSearchOptions, nameof(productSearchOptions));

            var searchSettings = this.searchSettingsProvider.GetSearchSettings();
            var searchOptions = this.searchOptionsBuilder.Build(searchSettings, productSearchOptions);
            var searchResults = this.searchManager.GetProducts(searchOptions);
            var productSearchResults =
                this.searchMapper.Map<Connect.SearchResultsV2<Product>, ProductSearchResults>(searchResults);

            return new Result<ProductSearchResults>(productSearchResults);
        }
    }
}