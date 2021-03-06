using AVLTree.Models.WordCount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AVLTree.Controllers
{
    public class WordCountController : Controller
    {
       WordCountModelEngine _modelEngine;

        public WordCountController()
        {
            _modelEngine = new WordCountModelEngine();
        }
        // GET: AVL
        public ActionResult Index()
        {
            return View(_modelEngine.GetWordCount());
        }

        public FileResult Export(string objExportParams)
        {
            List<KeyValuePair<string, int>> exportData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<string, int>>>(objExportParams);

            StringBuilder sb = new StringBuilder();
            sb.Append("Word,Occurrence Count");
            sb.Append("\r\n");
            //sb.Append("Word  -> Occurance Count");
            foreach (var expData in exportData)
            {
                //Append data with separator.
                sb.Append(expData.Key + "," + expData.Value);

                //Append new line character.
                sb.Append("\r\n");
            }

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/csv", "WordCount.csv");
        }
    }
}