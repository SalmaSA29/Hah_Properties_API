using ExcelDataReader.Log.Logger;
using Microsoft.AspNetCore.Http;
using PortalAPI.ViewModel;
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
#nullable enable

namespace PortalAPI.Services
{
    /// <summary>
    /// service class that saves/deletes media to local server
    /// </summary>
    public static class Media_Service
    {
        public static async Task<string?> SaveMedia(IFormFile file)
        {
            if (file == null)
                return null;

            if (file.Length == 0)   // file is empty
                return null;

            // only allow pdfs for now
            if (file.ContentType != "application/pdf")
                return null;

            var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName!.Trim('"');
            fileName = $"{Guid.NewGuid()}_{fileName}";
            var filePath = Path.Combine("Uploads", fileName);

            Directory.CreateDirectory("Uploads");

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }

        public static void DeleteMedia(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;

            var filePath = Path.Combine("Uploads", id);

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to delete file {filePath}: {ex.Message}");
                }
            }
        }
    } 
}
