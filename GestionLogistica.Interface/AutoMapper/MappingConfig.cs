using AutoMapper;
using GestionLogistica.Database.Models;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface.AutoMapper
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<Almacenamiento,AlmacenamientoDTO>();
            CreateMap<AlmacenamientoDTO, Almacenamiento>();
            CreateMap<MedioDeTransporte, MedioDeTransporteDTO>();
            CreateMap<MedioDeTransporteDTO, MedioDeTransporte>();
            CreateMap<Pedido, PedidoDTO>();
            CreateMap<PedidoDTO, Pedido>();
            CreateMap<PlanDeEntrega, PlanDeEntregaDTO>();
            CreateMap<PlanDeEntregaDTO, PlanDeEntrega>();
            CreateMap<Producto, ProductoDTO>();
            CreateMap<ProductoDTO, Producto>();
        }
    }
}
