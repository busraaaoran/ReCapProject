using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {

        public static string Add(IFormFile file)
        {
            var sourcePath = Path.GetTempFileName();

            if (file.Length > 0)
            {
                using (var stream= new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }

            var r = newPath(file);
            var result = (string)r;
            

            File.Move(sourcePath, result);

            return result;
        }
         
        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {

                return new ErrorResult(exception.Message);
            }
            return new SuccessResult();
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var r = newPath(file);
            var result = (string)r;

            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }

        private static object newPath(IFormFile file)
        {
            FileInfo ınfo = new FileInfo(file.FileName);

            string fileExtension = ınfo.Extension;
            string path = Environment.CurrentDirectory + @"\Images";
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }
    }
}
