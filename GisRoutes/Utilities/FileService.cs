using GisRoutes.Dto;
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
        public FileService() { }

        public string WriteDeliveryStatus(DeliveryResult deliveryResult)
        {
            string data = string.Empty;
            data = AppendDataArray(data, deliveryResult.NoRegistro, 1, 16);
            data = AppendDataArray(data, deliveryResult.IdResultado, 16, 18);
            data = AppendDataArray(data, deliveryResult.Persona, 18, 58);
            data = AppendDataArray(data, deliveryResult.Fecha.ToString("yyyyMMddhhmm"), 58, -1);

            try
            {
                if (Directory.Exists(@"C:\Users\itcristian\Documents\"))
                {
                    string path = @"C:\Users\itcristian\Documents\" +
                        FileManeDelivery(deliveryResult.Fecha, deliveryResult.NoRegistro) +
                        ".txt";

                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        using StreamWriter sw = File.CreateText(path);
                        sw.Write(data);
                        sw.Close();
                        return "Success";
                    }
                    return "File already created";
                }
                return "Directory not found";
            }
            catch (Exception)
            {
                return "Communication error";
            }
        }

        private string FileManeDelivery(DateTime dateTime, string noRegistro)
        {
            return string.Concat(
                noRegistro,
                "-",
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                "-",
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
                    app += " ";
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
