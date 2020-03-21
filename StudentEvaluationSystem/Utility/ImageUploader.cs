using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace StudentEvaluationSystem.Utility
{
    public class ImageUploader
    {
        public const string ImageFolder = @"images\UserImages";
        public const string DefaultImage = @"\images\UserImages\default_image.png";

        public static string UploadImageToServer(string imageUrl, IFormFileCollection files, string rootPath)
        {

            if (files.Count != 0)
            {
                //Image was uploaded
                var fullImageFolderPath = Path.Combine(rootPath, ImageFolder);

                var extension_new = Path.GetExtension(files[0].FileName);

                var fileNameWithExtension = Path.Combine(fullImageFolderPath, "UserImg_" + DateTime.Now.ToString("yymmssff") +
                        extension_new);

                if (!String.IsNullOrWhiteSpace(imageUrl))
                {

                    var extension_old = Path.GetExtension(imageUrl);

                    if (File.Exists(Path.Combine(fullImageFolderPath, Path.GetFileNameWithoutExtension(imageUrl)
                         + extension_old)))
                    {
                        //There's existing Image in server
                        File.Delete(Path.Combine(fullImageFolderPath, Path.GetFileNameWithoutExtension(imageUrl)
                         + extension_old));
                        fileNameWithExtension = Path.Combine(fullImageFolderPath, Path.GetFileNameWithoutExtension(imageUrl)
                            + extension_new);
                    }
                }

                //Uplaod file to server
                using (var fileStream = new FileStream(fileNameWithExtension, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                return @"\"+ImageFolder+"\\"+ Path.GetFileName(fileNameWithExtension);
            }
            return imageUrl; //No new file Uploaded, make the old value in DB constant
        }
    }
}
