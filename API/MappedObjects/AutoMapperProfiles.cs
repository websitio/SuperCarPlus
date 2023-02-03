using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using API.Extensions;
using API.Models.Entities;
using API.Models.Dtos;

#pragma warning disable CS8602

namespace API.MappedObjects
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {
            //Domain to Dtos
            CreateMap<Make, MakeDto>();
            CreateMap<Make, MakeWithNoModelsDto>();
            CreateMap<Model, ModelDto>();
            CreateMap<Feature, FeatureDto>();

            CreateMap<Vehicle, SaveVehicleDto>()
                //   .ForMember(vdto => vdto.Contact, opt => opt.MapFrom(v => new ContactDto{ Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone } ))
                //   .ForMember(vdto =>vdto.Features, opt => opt.MapFrom(v => v.Features.Select(vdto => new FeatureDto {  Id=>vdto.Id, Name=>vdto.Name })));
                .ForMember(vdto => vdto.Contact, opt => opt.MapFrom(v => new ContactDto { Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone }))
              .ForMember(vdto => vdto.Features, opt => opt.MapFrom(v => v.Features.Select(vdto => vdto.FeatureId)));


            CreateMap<Vehicle, VehicleDto>()
       .ForMember(vdto => vdto.Make, opt => opt.MapFrom(v => v.Model.Make))
       .ForMember(vdto => vdto.Contact, opt => opt.MapFrom(v => new ContactDto { Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone }))
       .ForMember(vdto => vdto.Features, opt => opt.MapFrom(v => v.Features.Select(vdto => new FeatureDto { Id = vdto.Feature.Id, Name = vdto.Feature.Name })));


            //Dtos to Domain


            CreateMap<SaveVehicleDto, Vehicle>()                                          //VehicleResource to Vehicle
                         .ForMember(v => v.Id, opt => opt.Ignore())
                         .ForMember(v => v.ContactName, opt => opt.MapFrom(vdto => vdto.Contact.Name))
                         .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vdto => vdto.Contact.Email))
                         .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vdto => vdto.Contact.Phone))
                         .ForMember(v => v.Features, opt => opt.Ignore())              //055@2m30
                         .AfterMap((vdto, v) =>
                         {
                             // Remove unselected features
                             var removedFeatures = new List<VehicleFeature>();
                             foreach (var f in v.Features)
                                 if (!vdto.Features.Contains(f.FeatureId))
                                     removedFeatures.Add(f);

                             foreach (var f in removedFeatures)
                                 v.Features.Remove(f);

                             // Add new features
                             foreach (var id in vdto.Features)

                                 if (!v.Features.Any(f => f.FeatureId == id))
                                     v.Features.Add(new VehicleFeature { FeatureId = id });
                         });
        }
    }
}