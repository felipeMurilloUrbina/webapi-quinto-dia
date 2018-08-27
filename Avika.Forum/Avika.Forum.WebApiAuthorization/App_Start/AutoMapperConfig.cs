using AutoMapper;
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
                .ForMember(d => d.Descripcion, o => o.MapFrom(p => p.DescripBod)).ReverseMap();
                cfg.CreateMap<SalidaAlmacenDTO, CoMovInv>()
                    .ForMember(d => d.HoraAsenMoi, o => o.MapFrom(p => p.Hora )) // Guarda la Hora en Formato Decimal.
                    .ForMember(d => d.FecAsenMoi, o => o.MapFrom(p => p.Fecha))  // Guarda la fecha en Formato Decimal.
                    .ForMember(d => d.NumDocMoi, o => o.MapFrom(p => p.Folio)) //Guarda el consecutivo de la salida.
                    .ForMember(d => d.PrefDocMoi, o => o.MapFrom(p => "AJ")) //Guarda el consecutivo de la salida.
                    .ForMember(d => d.NumLineaMoi, o => o.MapFrom(p => p.NumeroFila)) //Guarda el consecutivo de la salida.
                    .ForMember(d => d.NumArtMoi, o => o.MapFrom(p => p.CodigoArticulo)) // Guarda el codigo del articulo.
                    .ForMember(d => d.BodegaMoi, o => o.MapFrom(p => p.CodigoBodega)) // Guarda el codigo de la bodega.
                    .ForMember(d => d.TipoDocMoi, o => o.MapFrom(p => "C")) // Guarda el codigo del tipo de documento.
                    .ForMember(d => d.TipoMovMoi, o => o.MapFrom(p => "S")) // Guarda el codigo del tipo de movimiento.
                    .ForMember(d => d.ComentMoi, o => o.MapFrom(p => p.CodigoCentroCosto1)) // Guarda el codigo del centro costo 1.
                    .ForMember(d => d.NumCteProvMoi, o => o.MapFrom(p => p.CodigoCentroCosto2)) // Guarda el codigo del centro costo 2.
                    .ForMember(d => d.CantidadMoi, o => o.MapFrom(p => p.Cantidad)) // Guarda la cantidad de salida de la bodega.
                    .ForMember(d => d.PrecioMoi, o => o.MapFrom(p => p.CostoPromedio)) // Guarda el costo promedio del articulo.
                    .ForMember(d => d.CtoPromMoi, o => o.MapFrom(p => p.CostoPromedio)) // Guarda el costo promedio del articulo.
                    .ForMember(d => d.CtoUniMoi, o => o.MapFrom(p => p.CostoPromedio)) // Guarda el costo promedio del articulo.
                    .ForMember(d => d.CtoVieMoi, o => o.MapFrom(p => p.CostoPromedio)) // Guarda el costo promedio del articulo.
                    .ForMember(d => d.ImporteMoi, o => o.MapFrom(p => p.CostoPromedio * p.Cantidad)) // Guarda el costo promedio del articulo.
                    .ForMember(d => d.ModuloMoi, o => o.MapFrom(p => "A"))
                    .ForMember(d => d.UsuarioMoi, o => o.MapFrom(p => p.Usuario)); // Guarda el codigo del usuario.
                    //.ForMember(d => d.FechaMovimiento, o => o.MapFrom(p => DateTime.Parse(p.Fecha)));
            }
            );
        }
    }
}