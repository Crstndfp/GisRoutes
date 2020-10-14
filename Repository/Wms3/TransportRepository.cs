using Assets.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models.ModelsWms3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Wms3
{
    public class TransportRepository
    {
        private readonly WMS3Context _context;
        private readonly ILogger _logger;

        public TransportRepository(
           WMS3Context context,
           ILogger<PreOrdersRepository> logger
           )
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<TransportDto>> GetTransport()
        {
            try
            {
                return await _context.TblTransporte.Select(tt => 
                    new TransportDto { 
                        CodTransport= tt.CodTransporte, 
                        Name= tt.Nombre }
                    ).ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return new List<TransportDto>();
            }
        }
    }
}
