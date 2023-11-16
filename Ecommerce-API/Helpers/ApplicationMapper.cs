using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;

namespace Ecommerce_API.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        { 
            CreateMap<Category, CategoryVM>().ReverseMap();
            CreateMap<Developer, DeveloperVM>().ReverseMap();
            CreateMap<Admin, AdminVM>().ReverseMap();
            CreateMap<Client, ClientVM>().ReverseMap();
            CreateMap<Order, OrderVM>().ReverseMap();
            CreateMap<Game, GameVM>().ReverseMap();
            
        
        }
    }
}
