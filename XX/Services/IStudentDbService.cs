using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.DTOs.Requests;
using Kolokwium.DTOs.Responses;

namespace Kolokwium.Services
{
    public interface IStudentDbService
    {
        EnrollZadanie2Response EnrollZad1(int request);
  
    }
}
