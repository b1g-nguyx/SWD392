using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;

using Mapster;
namespace Common.Mappings
{
    public class PatientMap : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Patient, PatientDto>()
             .Map(dest => dest.Name, src => src.Name)
             .Map(dest => dest.Gender, src => src.Gender)
             .Map(dest => dest.Dob, src => src.Dob)
             .Map(dest => dest.HealthCode, src => src.HealthCode)
             .Map(dest => dest.Address, src => src.Address)
             .Map(dest => dest.PhoneNumber, src => src.PhoneNumber);

            config.NewConfig<PatientDto, Patient>()
              .Map(dest => dest.Name, src => src.Name)
              .Map(dest => dest.Gender, src => src.Gender)
              .Map(dest => dest.Dob, src => src.Dob)
              .Map(dest => dest.HealthCode, src => src.HealthCode)
              .Map(dest => dest.Address, src => src.Address)
              .Map(dest => dest.PhoneNumber, src => src.PhoneNumber);
        }
    }
}
