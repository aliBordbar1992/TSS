using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using FluentAssertions;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using RentApi.Api;
using RentApi.Api.Extensions;
using RentApi.Shared.Dto;
using RentApi.Shared.Request;
using RentApi.Shared.Response;
using Xunit;

namespace RentApi.Tests
{
    public class UnitTest1 : IClassFixture<Fixtures>
    {
        private Fixtures _fixtures;
        public UnitTest1(Fixtures fixtures)
        {
            _fixtures = fixtures;
        }

        [Fact]
        public void getting_list_of_stations_should_not_return_null_or_empty()
        {
            var stationRequest = new StationsRequest("All");
            stationRequest.Country = "france";
            stationRequest.AreaType = AreaType.City;
            var response = _fixtures.CarRent.GetStations(stationRequest).Result;
            response.Errors.Should().BeNullOrEmpty();
        }

        [Fact]
        public void searching_for_two_valid_destinations()
        {
            var req = new SearchRequest("CDGT01", DateTime.Now.AddDays(1), "CDGT01", DateTime.Now.AddDays(2));
            var response = _fixtures.CarRent.Search(req).Result;

            response.Results.Should().NotBeNullOrEmpty();


            //adding result to cache, to avoid sending additional requests in other tests.
            MemoryCacheEntryOptions opt = new MemoryCacheEntryOptions();
            opt.AbsoluteExpiration = DateTime.Now.AddMinutes(10);

            _fixtures.Cache.Set("_searchResults_test", response, opt);
        }

        [Fact]
        public void getting_extra_information()
        {
            //get search result from cache if exits, to avoid sending redundant search request, if not, get it
            if (!_fixtures.Cache.TryGetValue("_searchResults_test", out SearchResponse searchResult))
            {
                searching_for_two_valid_destinations();
                _fixtures.Cache.TryGetValue("_searchResults_test", out searchResult);
            }

            var searchResultItem = searchResult.Results.First();

            var req = new ExtraRequest(
                "CDGT01",
                DateTime.Now.AddDays(1),
                "CDGT01",
                DateTime.Now.AddDays(2),
                searchResultItem.ContractId,
                searchResultItem.CarCategoryCode);

            var response = _fixtures.CarRent.GetExtra(req).Result;

            response.Results.Should().NotBeNull();
        }

        [Fact]
        public void reserve_a_product()
        {
            //get search result from cache if exits, to avoid sending redundant search request, if not, get it
            if (!_fixtures.Cache.TryGetValue("_searchResults_test", out SearchResponse searchResult))
            {
                searching_for_two_valid_destinations();
                _fixtures.Cache.TryGetValue("_searchResults_test", out searchResult);
            }

            var searchResultItem = searchResult.Results.First();

            var req = new ReserveRequest(
                "CDGT01",
                DateTime.Now.AddDays(1),
                "CDGT01",
                DateTime.Now.AddDays(2),
                searchResultItem.ContractId,
                searchResultItem.CarCategoryCode,
                searchResultItem.RateId,
                "example@test.com",
                new Driver("+989372346281", "MR", "Ali", "Bordbar", "2281206696", "Tehran"));
            var response = _fixtures.CarRent.Reserve(req).Result;

            response.Errors.Should().BeNullOrEmpty();
        }

        [Fact]
        public void confirming_a_reserve()
        {
            //get search result from cache if exits, to avoid sending redundant search request, if not, get it
            if (!_fixtures.Cache.TryGetValue("_searchResults_test", out SearchResponse searchResult))
            {
                searching_for_two_valid_destinations();
                _fixtures.Cache.TryGetValue("_searchResults_test", out searchResult);
            }

            var searchResultItem = searchResult.Results.First();

            var reqReserve = new ReserveRequest(
                "CDGT01",
                DateTime.Now.AddDays(1),
                "CDGT01",
                DateTime.Now.AddDays(2),
                searchResultItem.ContractId,
                searchResultItem.CarCategoryCode,
                searchResultItem.RateId,
                "example@test.com",
                new Driver("+989372346281", "MR", "Ali", "Bordbar", "2281206696", "Tehran"));
            var reserveResponse = _fixtures.CarRent.Reserve(reqReserve).Result;

            var confirmRequest = new ConfirmRequest(reserveResponse.Results.ReserveId);
            var confirmResponse = _fixtures.CarRent.Confirm(confirmRequest).Result;

            confirmResponse.Errors.Should().BeNullOrEmpty();
        }
    }

    public class Fixtures : IDisposable
    {
        public readonly ICarRentApi CarRent;
        public IMemoryCache Cache;

        public Fixtures()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddCarRentApi("SairoS0ft", "@224466");
            var provider = serviceCollection.BuildServiceProvider();

            CarRent = provider.GetService<ICarRentApi>();
            Cache = provider.GetService<IMemoryCache>();
        }

        public void Dispose()
        {
        }
    }
}
