using AdventureWorks.DAL;
using AdventureWorks.Web.Models;
using AutoMapper;

namespace AdventureWorks.Web.MappingProfiles
{
    public class ProductMappingProfile : Profile
    {
        protected override void Configure()
        {
            base.Configure();

            CreateMap<Product, ProductViewModel>()
                .MapFrom(x => x.ProductID, d => d.ProductID)
                .MapFrom(x => x.ProductNumber, d => d.ProductNumber)
                .MapFrom(x => x.ProductName, d => d.Name)
                .MapFrom(x => x.ProductModel, d => d.ProductModel.Name)
                .MapFrom(x => x.ProductCategory, d => (d.ProductSubcategory != null ? (d.ProductSubcategory.ProductCategory != null ? d.ProductSubcategory.ProductCategory.Name : "") : ""))
                .MapFrom(x => x.ProductSubcategory, d => (d.ProductSubcategory != null ? d.ProductSubcategory.Name : ""))
                .MapFrom(x => x.Color, d => d.Color)
                .MapFrom(x => x.Size, d => d.Size)
                .MapFrom(x => x.Weight, d => (d.Weight.HasValue ? d.Weight : default(decimal)))
                .MapFrom(x => x.ListPrice, d => d.ListPrice);
        }
    }


}