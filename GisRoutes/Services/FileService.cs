using GisRoutes.Dto;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace GisRoutes.Services
{
    public class FileService
    {
        private const string SPACE = " ";
        private const string GUION = "-";
        private const string USEDATE = "yyyyMMddhhmm";
        private const string SUCCESS = "Success";
        private const string FILEEXIST = "File already created";
        private const string DIRECTORYNOTFOUND = "Directory not found";
        private const string FILESERVER = @"\\srvcatm2\c$\FTPCemaco\LocalUser\ftpdisatel\IN";

        private readonly ILogger _logger;
        public FileService(ILogger<FileService> logger)
        {
            _logger = logger;
        }

        public string WriteDeliveryStatus(DeliveryResult deliveryResult)
        {
            string data = string.Empty;
            data = AppendDataArray(data, deliveryResult.NoRegistro, 1, 16);
            data = AppendDataArray(data, deliveryResult.IdResultado, 16, 18);
            data = AppendDataArray(data, deliveryResult.Persona
                .Trim()
                .Replace("\n"," ")
                .Replace("\r", "")
                , 18, 58);
            data = AppendDataArray(data, deliveryResult.Fecha.ToString(USEDATE), 58, -1);

            try
            {
                if (Directory.Exists(FILESERVER))
                {
                    string path = FILESERVER + @"\" +
                        FileManeDelivery(deliveryResult.Fecha, deliveryResult.NoRegistro) +
                        ".txt";
                    _logger.LogInformation("Path " + path);

                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        using StreamWriter sw = File.CreateText(path);
                        sw.Write(data);
                        sw.Close();
                        return SUCCESS;
                    }
                    return FILEEXIST;
                }
                return DIRECTORYNOTFOUND;
            }
            catch (Exception e)
            {
                _logger.LogError(e.StackTrace);
                return e.StackTrace ;
            }
        }

        private string FileManeDelivery(DateTime dateTime, string noRegistro)
        {
            return string.Concat(
                noRegistro,
                GUION,
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                GUION,
                dateTime.Hour,
                dateTime.Minute,
                dateTime.Second
                );
        }

        private string AppendDataArray(
            string app, 
            string info, 
            int start,
            int finish)
        {
            if (start + info.Length < finish)
            {
                app += info;
                for (int cont = start + info.Length; 
                    cont < finish; 
                    cont++)
                {
                    app += SPACE;
                }
            }
            else if (finish == -1)
            {
                app += info;
            }
            else
            {
                app += info.Substring(0, finish - start);
            }
            return app;
        }

    }
}
