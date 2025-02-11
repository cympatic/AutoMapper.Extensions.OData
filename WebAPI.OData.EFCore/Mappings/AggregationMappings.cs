﻿using AutoMapper;
using DAL.EFCore.Aggregation;
using Domain.OData.Aggregation;

namespace WebAPI.OData.EFCore.Mappings
{
    public class AggregationMappings : Profile
    {
        public AggregationMappings()
        {
            RecognizePrefixes("Fld");

            CreateMap<TblCategory, Category>()
                .ForAllMembers(options => options.ExplicitExpansion());

            CreateMap<TblCurrency, Currency>()
                .ForAllMembers(options => options.ExplicitExpansion());

            CreateMap<TblCustomer, Customer>()
                .ForAllMembers(options => options.ExplicitExpansion());

            CreateMap<TblProduct, Product>()
                .ForAllMembers(options => options.ExplicitExpansion());

            CreateMap<TblSales, Sales>()
                .ForAllMembers(options => options.ExplicitExpansion());

            CreateMap<TblSalesOrganization, SalesOrganization>()
                .ForAllMembers(options => options.ExplicitExpansion());

            CreateMap<TblTime, Time>()
                .ForAllMembers(options => options.ExplicitExpansion());
        }
    }
}
