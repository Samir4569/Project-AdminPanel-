using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System;

namespace Project_AdminPanel_.Helpers
{
    public static class Extensions
    {
        public static bool IsImage(this IFormFile file)
        {

            return file.ContentType.Contains("image/");
        }
        public static bool IsBigger2MB(this IFormFile file)
        {

            return file.Length / 1024 > 2048;
        }
        public static async Task<string> SaveImageAsync(this IFormFile file, string folder)
        {
            string filename = Guid.NewGuid().ToString() + file.FileName;
            string path = Path.Combine(folder, filename);

            using (FileStream filestream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(filestream);
            }
            return filename;
        }

    }
}
