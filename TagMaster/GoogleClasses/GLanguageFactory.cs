using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;


namespace TagMaster.GoogleClasses
{
    internal static class GLanguageFactory
    {
        public static TagMaster_BL.TagList createGLanguageLabels(String textToBeTagged)
        {
            TagMaster_BL.TagList tagList = new TagMaster_BL.TagList();  
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Properties.Settings.Default.GoogleAuthFile);
            LanguageServiceClient langClient = LanguageServiceClient.Create();
            
            try
            {
                foreach (var tag in langClient.AnalyzeEntitySentiment(Document.FromPlainText(textToBeTagged)).Entities)
                {
                    //if (tag.Metadata.ContainsKey("mid"))
                    tagList.Rows.Add(textToBeTagged, tag.Mentions.ToString(), tag.Salience);
                    //tagList.Rows.Add(textToBeTagged, tag.Metadata["content"], tag.Salience);
                    
                    
                    //tagList.Rows.Add(textToBeTagged, tag.Metadata["wikipedia_url"] , tag.Salience) ;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return tagList;
        }

        

    }
}
