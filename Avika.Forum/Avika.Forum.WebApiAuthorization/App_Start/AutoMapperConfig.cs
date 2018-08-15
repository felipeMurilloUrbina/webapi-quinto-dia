﻿using AutoMapper;
using Avika.Forum.Model;
using Avika.Forum.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avika.Forum.WebApiAuthorization.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Config()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<CoArticu, ArticuloDTO>()
                                                .ForMember(d => d.Id, o => o.MapFrom(p => p.Id))
                                                .ForMember(d => d.Codigo, o => o.MapFrom(p => p.CodigoArt))
                                                .ForMember(d => d.Descripcion, o => o.MapFrom(p => p.DescripArt))
                                                .ForMember(d => d.Existencia, o => o.MapFrom(p => p.Existencia))
                                                .ForMember(d => d.Unidad, o => o.MapFrom(p => p.UniMedArt))
                                                .ForMember(d => d.CostoPromedio, o => o.MapFrom(p => p.CostoPromedio))
                                                .ForMember(d => d.ValorInventario, o => o.MapFrom(p => p.CostoPromedio * p.Existencia))
                                                .ForMember(d => d.TipoMaterial, o => o.MapFrom(p => p.TipoMaterialString))
                                                .ForMember(d => d.Categoria, o => o.MapFrom(p => p.CategoriaString)).ReverseMap();
                cfg.CreateMap<CoBodega, BodegaDto>()
                    .ForMember(d => d.Codigo, o => o.MapFrom(p => p.CodigoBod))
                    .ForMember(d => d.Descripcion, o => o.MapFrom(p => p.DescripBod));
                }
            );
        }
    }
}