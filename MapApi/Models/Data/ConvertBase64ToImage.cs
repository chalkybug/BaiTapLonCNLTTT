using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MapApi.Models
{
    static public class ConvertBase64ToImage
    {
        static public string ConvertAndSaveImage(string image,string path)
        {
            string name = "";
            string strBase64 = image;
            int index = strBase64.IndexOf(",");
            strBase64 = image.Remove(0, index + 1);

            byte[] imageBytes = Convert.FromBase64String(strBase64);
            // Convert byte[] to Image
          
            // check path
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            // set name
            //get tik
            string tik = DateTime.Now.Ticks.ToString();
            //get date +time
            string time = DateTime.Now.ToString().Split(' ')[0] + DateTime.Now.ToString().Split(' ')[1];
            Regex reg = new Regex(@"\d");
          
            foreach (Match item in reg.Matches(time))
            {
                name += (item.ToString());
            }
           
            string pathImage = $"{path}\\{name}{tik}.png";
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {

                Image pic = Image.FromStream(ms, true);
                pic.Save(pathImage);
            }
            return pathImage;
        }


    }
}