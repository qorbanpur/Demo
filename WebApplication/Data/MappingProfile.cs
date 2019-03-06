using AutoMapper;
using SubscriptionServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServiceReference;
//using WcfService.DataInterfaces;
using WebApplication.DtoModels;

namespace WebApplication.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserServiceReference.User, UserDto>();
            CreateMap<UserDto, UserServiceReference.User>();

            CreateMap<SubscriptionServiceReference.Subscription, SubscriptionDto>();
            CreateMap<SubscriptionDto, SubscriptionServiceReference.Subscription>();

            //CreateMap<UserSubscription, UserSubscriptionDto>();
            //CreateMap<UserSubscriptionDto, UserSubscription>();
        }
    }
}