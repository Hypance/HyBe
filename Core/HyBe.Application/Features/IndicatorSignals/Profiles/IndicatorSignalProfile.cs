﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.Domain.Entities.Indicators;

namespace HyBe.Application.Features.IndicatorSignals.Profiles;
public class IndicatorSignalProfile : Profile
{
    public IndicatorSignalProfile()
    {
        CreateMap<IndicatorSignal, GetListIndicatorSignalResponse>();
        CreateMap<IndicatorSignal, GetByIdIndicatorSignalResponse>();
        CreateMap<CreateIndicatorSignalRequest, IndicatorSignal>();
        CreateMap<UpdateIndicatorSignalRequest, IndicatorSignal>();
    }
}