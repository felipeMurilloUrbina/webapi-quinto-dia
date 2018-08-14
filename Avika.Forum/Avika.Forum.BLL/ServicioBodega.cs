using AutoMapper;
using Avika.Forum.DAO;
using Avika.Forum.LogDLL;
using Avika.Forum.Model;
using Avika.Forum.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.BLL
{
    public class ServicioBodega
    {
        Context contexto = null;
        public ServicioBodega(Context context, Logger logger) 
        {
            this.contexto = context;
        }
        
        public ICollection<BodegaDto> Get()
        {
            return Mapper.Map<List<CoBodega>, List<BodegaDto>>( this.contexto.Bodegas.ToList());
        }
    }
}
