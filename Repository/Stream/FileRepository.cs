using Assets.Dto;
using Assets.Utilities;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Repository.Stream
{
    public class FileRepository
    {
        private readonly ILogger _logger;
        public FileRepository(ILogger<FileRepository> logger)
        {
            _logger = logger;
        }
        public string WriteDeliveryStatus(DeliveryResultDto deliveryResult)
        {
            string data = string.Empty;
            
            data = StringTools.AppendDataArray(data, deliveryResult.NoRegistro, 1, 16);
            data = StringTools.AppendDataArray(data, deliveryResult.IdResultado, 16, 18);
            data = StringTools.AppendDataArray(data, deliveryResult.Persona
                .Trim()
                .Replace(ConstNames.BREACKLINE, ConstNames.SPACE)
                .Replace(ConstNames.RETURNLINE, ConstNames.EMPTY)
                , 18, 58);
            data = StringTools.AppendDataArray(data, deliveryResult.Fecha.ToString(ConstNames.USEDATE), 58, -1);
            try
            {
                if (Directory.Exists(ConstNames.FILESERVER))
                {
                    string path = ConstNames.FILESERVER + @"\" +
                        StringTools.FileManeDelivery(deliveryResult.Fecha, deliveryResult.NoRegistro) +
                        ".txt";
                    _logger.LogInformation("Path " + path);
                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        using StreamWriter sw = File.CreateText(path);
                        sw.Write(data);
                        sw.Close();
                        return ConstNames.SUCCESS;
                    }
                    return ConstNames.FILEEXIST;
                }
                return ConstNames.DIRECTORYNOTFOUND;
            }
            catch (Exception e)
            {
                _logger.LogError(e.StackTrace);
                return e.StackTrace;
            }
        }
    }
}
