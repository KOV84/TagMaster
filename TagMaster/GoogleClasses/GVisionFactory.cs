using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Vision.V1;

namespace TagMaster.GoogleClasses
{
    internal static class GVisionFactory
    {
        public static IReadOnlyList<Google.Cloud.Vision.V1.EntityAnnotation> createGVisionLabels(byte[] imageToBeTagged, int nbrOfTagsRequested) 
        {            
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Properties.Settings.Default.GoogleAuthFile);
            var client = ImageAnnotatorClient.Create();
            var image = Google.Cloud.Vision.V1.Image.FromBytes(imageToBeTagged);
            //var image = Google.Cloud.Vision.V1.Image.FromFile("C:\\Users\\koenve\\Pictures\\keukenrobot.jpg");//.FromUri("gs://cloud-samples-data/vision/using_curl/shanghai.jpeg");

            return client.DetectLabels(image, maxResults:nbrOfTagsRequested);
            //return client.DetectText(image); ;
            //return client.DetectLogos(image);
        }
    }
}
